﻿using System;
using System.Collections.Generic;
using System.Net;
using RestSharp;

namespace HelloSign
{
    public class Client
    {
        /// <summary>
        /// Specifies different HelloSign environments that can be reached.
        /// </summary>
        public enum Environment {
            Prod,
            Staging,
        }

        private RestClient client;

        /// <summary>
        /// Default constructor with no authentication.
        /// Limited to unauthenticated calls only.
        /// </summary>
        public Client()
        {
            client = new RestClient();
            SetEnvironment(Environment.Prod);
        }

        /// <summary>
        /// Constructor initialized with API key authentication.
        /// </summary>
        /// <param name="apiKey">Your HelloSign account API key.</param>
        public Client(string apiKey) : this()
        {
            client.Authenticator = new HttpBasicAuthenticator(apiKey, "");
        }

        /// <summary>
        /// Constructor initialized with username/password authentication.
        /// Not preferred; Please use API key authentication instead.
        /// </summary>
        /// <param name="username">Your HelloSign account email address.</param>
        /// <param name="password">Your HelloSign account password.</param>
        public Client(string username, string password) : this()
        {
            client.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        /// <summary>
        /// Execute an API call using RestSharp and deserialize the response
        /// into a native object of class T.
        /// </summary>
        /// <typeparam name="T">The class to deserialize the response into.</typeparam>
        /// <param name="request">The RestRequest object to execute.</param>
        /// <returns></returns>
        private T Execute<T>(RestRequest request) where T : new()
        {
            var response = client.Execute<T>(request);
            
            // Handle errors
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                throw new ApplicationException(message, response.ErrorException);
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ApplicationException("Received status " + response.StatusCode.GetHashCode() + " from server. Full response:\n" + response.Content);
            }

            return response.Data;
        }

        /// <summary>
        /// Set the client to point to a different environment.
        /// Not useful to the general public.
        /// </summary>
        /// <param name="env"></param>
        public void SetEnvironment(Environment env)
        {
            string baseUrl;
            switch (env)
            {
                case Environment.Prod:
                    baseUrl = "https://api.hellosign.com/v3";
                    break;
                case Environment.Staging:
                    baseUrl = "https://api-staging.hellosign.com/v3";
                    break;
                default:
                    throw new ArgumentException("Unsupported environment given");
            }
            client.BaseUrl = new Uri(baseUrl);
        }

        #region Account Methods

        /// <summary>
        /// Create a new HelloSign account.
        /// The account must not already exist, and the user must confirm their
        /// email address before actions can be performed on this user's
        /// behalf.
        /// </summary>
        /// <param name="email_address"></param>
        /// <returns>The new Account</returns>
        public Account CreateAccount(string emailAddress)
        {
            if (String.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("email_address is required");
            }

            var request = new RestRequest("account/create", Method.POST);
            request.AddParameter("email_address", emailAddress); 
            request.RootElement = "account";
            return Execute<Account>(request);
        }

        /// <summary>
        /// Get information about the currently authenticated account.
        /// </summary>
        /// <returns>Your Account</returns>
        public Account GetAccount()
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("account");
            request.RootElement = "account";
            return Execute<Account>(request);
        }

        /// <summary>
        /// Update your account settings (callback URL).
        /// </summary>
        /// <param name="callback_url">Your new account callback URL.</param>
        /// <returns>Your Account</returns>
        public Account UpdateAccount(Uri callbackUrl)
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("account", Method.POST);
            request.AddParameter("callback_url", callbackUrl);
            request.RootElement = "account";
            return Execute<Account>(request);
        }

        #endregion

        #region Signature Request Methods

        /// <summary>
        /// Get information about a Signature Request.
        /// </summary>
        /// <param name="signatureRequestId">The alphanumeric Signature Request ID (Document ID).</param>
        /// <returns>The Signature Request</returns>
        public SignatureRequest GetSignatureRequest(string signatureRequestId)
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("signature_request/{id}");
            request.AddUrlSegment("id", signatureRequestId);
            request.RootElement = "signature_request";
            return Execute<SignatureRequest>(request);
        }

        /// <summary>
        /// Send a new Signature Request.
        /// 
        /// Create a new SignatureRequest object, set its properties, and pass
        /// it to this method.
        /// </summary>
        /// <param name="signatureRequest"></param>
        /// <returns></returns>
        public SignatureRequest SendSignatureRequest(SignatureRequest signatureRequest)
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("signature_request/send", Method.POST);
            if (signatureRequest.Title != null) request.AddParameter("title", signatureRequest.Title);
            if (signatureRequest.Subject != null) request.AddParameter("subject", signatureRequest.Subject);
            if (signatureRequest.Message != null) request.AddParameter("message", signatureRequest.Message);

            // Add Signers
            var i = 0;
            foreach (var signer in signatureRequest.Signers)
            {
                string prefix = String.Format("signers[{0}]", i);
                request.AddParameter(prefix + "[email_address]", signer.EmailAddress);
                request.AddParameter(prefix + "[name]", signer.Name);
                if (signer.Order != null) request.AddParameter(prefix + "[order]", signer.Order);
                if (signer.Pin != null) request.AddParameter(prefix + "[pin]", signer.Pin);
                i++;
            }

            // Add CCs
            i = 0;
            foreach (var cc in signatureRequest.Ccs)
            {
                request.AddParameter(String.Format("cc_email_addresses[{0}]", i), cc);
                i++;
            }

            // Add Files/FileUrls
            if (signatureRequest.Files.Count > 0)
            {
                i = 0;
                foreach (var file in signatureRequest.Files)
                {
                    file.AddToRequest(request, String.Format("file[{0}]", i));
                    i++;
                }
            }
            else if (signatureRequest.FileUrls.Count > 0)
            {
                i = 0;
                foreach (var fileUrl in signatureRequest.FileUrls)
                {
                    request.AddParameter(String.Format("file_url[{0}]", i), fileUrl);
                    i++;
                }
            }

            // Add Metadata
            foreach (var entry in signatureRequest.Metadata)
            {
                request.AddParameter(String.Format("metadata[{0}]", entry.Key), entry.Value); // TODO: Escape characters in key
            }

            // Add Test Mode
            if (signatureRequest.TestMode)
            {
                request.AddParameter("test_mode", "1");
            }

            request.RootElement = "signature_request";
            return Execute<SignatureRequest>(request);
        }

        /// <summary>
        /// Send a new Signature Request based on a Template.
        /// 
        /// Create a new TemplateSignatureRequest object, set its properties,
        /// and pass it to this method.
        /// </summary>
        /// <param name="signatureRequest"></param>
        /// <returns></returns>
        public TemplateSignatureRequest SendSignatureRequest(TemplateSignatureRequest signatureRequest)
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("signature_request/send", Method.POST);
            request.AddParameter("template_id", signatureRequest.TemplateId);
            if (signatureRequest.Title != null) request.AddParameter("title", signatureRequest.Title);
            if (signatureRequest.Subject != null) request.AddParameter("subject", signatureRequest.Subject);
            if (signatureRequest.Message != null) request.AddParameter("message", signatureRequest.Message);
            if (signatureRequest.SigningRedirectUrl != null) request.AddParameter("signing_redirect_url", signatureRequest.SigningRedirectUrl);

            // Add Signers
            foreach (var signer in signatureRequest.Signers)
            {
                string prefix = String.Format("signers[{0}]", signer.Role); // TODO: Escape characters in key
                request.AddParameter(prefix + "[email_address]", signer.EmailAddress);
                request.AddParameter(prefix + "[name]", signer.Name);
                if (signer.Order != null) request.AddParameter(prefix + "[order]", signer.Order);
                if (signer.Pin != null) request.AddParameter(prefix + "[pin]", signer.Pin);
            }

            // Add CCs
            foreach (var entry in signatureRequest.Ccs)
            {
                request.AddParameter(String.Format("cc_email_addresses[{0}]", entry.Key), entry.Value); // TODO: Escape characters in key
            }

            // Add Custom Fields
            foreach (var entry in signatureRequest.CustomFields)
            {
                request.AddParameter(String.Format("custom_fields[{0}]", entry.Key), entry.Value); // TODO: Escape characters in key
            }

            // Add Metadata
            foreach (var entry in signatureRequest.Metadata)
            {
                request.AddParameter(String.Format("metadata[{0}]", entry.Key), entry.Value); // TODO: Escape characters in key
            }

            // Add Test Mode
            if (signatureRequest.TestMode)
            {
                request.AddParameter("test_mode", "1");
            }

            request.RootElement = "signature_request";
            return Execute<TemplateSignatureRequest>(request);
        }

        /// <summary>
        /// Send a reminder to the specified email address to sign the
        /// specified Signature Request.
        /// </summary>
        /// <param name="signatureRequestId"></param>
        /// <param name="emailAddress"></param>
        public void RemindSignatureRequest(string signatureRequestId, string emailAddress)
        {
            var request = new RestRequest("signature_request/cancel/{id}", Method.POST);
            request.AddUrlSegment("id", signatureRequestId);
            request.AddParameter("email_address", emailAddress);
            client.Execute(request);
        }

        /// <summary>
        /// Cancel the specified Signature Request.
        /// </summary>
        /// <param name="signatureRequestId"></param>
        public void CancelSignatureRequest(string signatureRequestId)
        {
            var request = new RestRequest("signature_request/cancel/{id}", Method.POST);
            request.AddUrlSegment("id", signatureRequestId);
            client.Execute(request);
        }

        #endregion
    }
}