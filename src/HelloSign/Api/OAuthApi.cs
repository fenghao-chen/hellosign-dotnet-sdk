/*
 * HelloSign API
 *
 * HelloSign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using HelloSign.Client;
using HelloSign.Model;

namespace HelloSign.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// OAuth Token Generate
        /// </summary>
        /// <remarks>
        /// Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthTokenResponse</returns>
        OAuthTokenResponse OauthTokenGenerate(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0);

        /// <summary>
        /// OAuth Token Generate
        /// </summary>
        /// <remarks>
        /// Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthTokenResponse</returns>
        ApiResponse<OAuthTokenResponse> OauthTokenGenerateWithHttpInfo(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0);
        /// <summary>
        /// OAuth Token Refresh
        /// </summary>
        /// <remarks>
        /// Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthTokenResponse</returns>
        OAuthTokenResponse OauthTokenRefresh(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0);

        /// <summary>
        /// OAuth Token Refresh
        /// </summary>
        /// <remarks>
        /// Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthTokenResponse</returns>
        ApiResponse<OAuthTokenResponse> OauthTokenRefreshWithHttpInfo(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// OAuth Token Generate
        /// </summary>
        /// <remarks>
        /// Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OAuthTokenResponse</returns>
        System.Threading.Tasks.Task<OAuthTokenResponse> OauthTokenGenerateAsync(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// OAuth Token Generate
        /// </summary>
        /// <remarks>
        /// Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OAuthTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthTokenResponse>> OauthTokenGenerateWithHttpInfoAsync(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// OAuth Token Refresh
        /// </summary>
        /// <remarks>
        /// Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OAuthTokenResponse</returns>
        System.Threading.Tasks.Task<OAuthTokenResponse> OauthTokenRefreshAsync(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// OAuth Token Refresh
        /// </summary>
        /// <remarks>
        /// Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </remarks>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OAuthTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OAuthTokenResponse>> OauthTokenRefreshWithHttpInfoAsync(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthApi : IOAuthApiSync, IOAuthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OAuthApi : IOAuthApi
    {
        private HelloSign.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi(string basePath)
        {
            this.Configuration = HelloSign.Client.Configuration.MergeConfigurations(
                HelloSign.Client.GlobalConfiguration.Instance,
                new HelloSign.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HelloSign.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HelloSign.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HelloSign.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OAuthApi(HelloSign.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HelloSign.Client.Configuration.MergeConfigurations(
                HelloSign.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HelloSign.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HelloSign.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HelloSign.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OAuthApi(HelloSign.Client.ISynchronousClient client, HelloSign.Client.IAsynchronousClient asyncClient, HelloSign.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HelloSign.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HelloSign.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HelloSign.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public HelloSign.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HelloSign.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// OAuth Token Generate Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthTokenResponse</returns>
        public OAuthTokenResponse OauthTokenGenerate(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0)
        {
            HelloSign.Client.ApiResponse<OAuthTokenResponse> localVarResponse = OauthTokenGenerateWithHttpInfo(oAuthTokenGenerateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth Token Generate Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthTokenResponse</returns>
        public HelloSign.Client.ApiResponse<OAuthTokenResponse> OauthTokenGenerateWithHttpInfo(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0)
        {
            // verify the required parameter 'oAuthTokenGenerateRequest' is set
            if (oAuthTokenGenerateRequest == null)
            {
                throw new HelloSign.Client.ApiException(400, "Missing required parameter 'oAuthTokenGenerateRequest' when calling OAuthApi->OauthTokenGenerate");
            }

            HelloSign.Client.RequestOptions localVarRequestOptions = new HelloSign.Client.RequestOptions();

            var localVarContentType = "";
            var openApiTypes = oAuthTokenGenerateRequest.GetOpenApiTypes();
            if (ClientUtils.HasFileType(openApiTypes))
            {
                ClientUtils.SetFormData(localVarRequestOptions, openApiTypes);
                localVarContentType = "multipart/form-data";
            }
            else
            {
                localVarContentType = "application/json";
                localVarRequestOptions.Data = oAuthTokenGenerateRequest;
            }

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HelloSign.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = "OAuthApi.OauthTokenGenerate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<OAuthTokenResponse>("/oauth/token", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OauthTokenGenerate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth Token Generate Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OAuthTokenResponse</returns>
        public async System.Threading.Tasks.Task<OAuthTokenResponse> OauthTokenGenerateAsync(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HelloSign.Client.ApiResponse<OAuthTokenResponse> localVarResponse = await OauthTokenGenerateWithHttpInfoAsync(oAuthTokenGenerateRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth Token Generate Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenGenerateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OAuthTokenResponse)</returns>
        public async System.Threading.Tasks.Task<HelloSign.Client.ApiResponse<OAuthTokenResponse>> OauthTokenGenerateWithHttpInfoAsync(OAuthTokenGenerateRequest oAuthTokenGenerateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oAuthTokenGenerateRequest' is set
            if (oAuthTokenGenerateRequest == null)
            {
                throw new HelloSign.Client.ApiException(400, "Missing required parameter 'oAuthTokenGenerateRequest' when calling OAuthApi->OauthTokenGenerate");
            }


            HelloSign.Client.RequestOptions localVarRequestOptions = new HelloSign.Client.RequestOptions();

            var localVarContentType = "";
            var openApiTypes = oAuthTokenGenerateRequest.GetOpenApiTypes();
            if (ClientUtils.HasFileType(openApiTypes))
            {
                ClientUtils.SetFormData(localVarRequestOptions, openApiTypes);
                localVarContentType = "multipart/form-data";
            }
            else
            {
                localVarContentType = "application/json";
                localVarRequestOptions.Data = oAuthTokenGenerateRequest;
            }

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HelloSign.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = "OAuthApi.OauthTokenGenerate";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<OAuthTokenResponse>("/oauth/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OauthTokenGenerate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth Token Refresh Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthTokenResponse</returns>
        public OAuthTokenResponse OauthTokenRefresh(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0)
        {
            HelloSign.Client.ApiResponse<OAuthTokenResponse> localVarResponse = OauthTokenRefreshWithHttpInfo(oAuthTokenRefreshRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth Token Refresh Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthTokenResponse</returns>
        public HelloSign.Client.ApiResponse<OAuthTokenResponse> OauthTokenRefreshWithHttpInfo(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0)
        {
            // verify the required parameter 'oAuthTokenRefreshRequest' is set
            if (oAuthTokenRefreshRequest == null)
            {
                throw new HelloSign.Client.ApiException(400, "Missing required parameter 'oAuthTokenRefreshRequest' when calling OAuthApi->OauthTokenRefresh");
            }

            HelloSign.Client.RequestOptions localVarRequestOptions = new HelloSign.Client.RequestOptions();

            var localVarContentType = "";
            var openApiTypes = oAuthTokenRefreshRequest.GetOpenApiTypes();
            if (ClientUtils.HasFileType(openApiTypes))
            {
                ClientUtils.SetFormData(localVarRequestOptions, openApiTypes);
                localVarContentType = "multipart/form-data";
            }
            else
            {
                localVarContentType = "application/json";
                localVarRequestOptions.Data = oAuthTokenRefreshRequest;
            }

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HelloSign.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = "OAuthApi.OauthTokenRefresh";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<OAuthTokenResponse>("/oauth/token?refresh", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OauthTokenRefresh", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth Token Refresh Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OAuthTokenResponse</returns>
        public async System.Threading.Tasks.Task<OAuthTokenResponse> OauthTokenRefreshAsync(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            HelloSign.Client.ApiResponse<OAuthTokenResponse> localVarResponse = await OauthTokenRefreshWithHttpInfoAsync(oAuthTokenRefreshRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth Token Refresh Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see &#x60;expires_in&#x60;), along with a refresh token that can be used to acquire a new access token after the current one has expired.
        /// </summary>
        /// <exception cref="HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthTokenRefreshRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OAuthTokenResponse)</returns>
        public async System.Threading.Tasks.Task<HelloSign.Client.ApiResponse<OAuthTokenResponse>> OauthTokenRefreshWithHttpInfoAsync(OAuthTokenRefreshRequest oAuthTokenRefreshRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'oAuthTokenRefreshRequest' is set
            if (oAuthTokenRefreshRequest == null)
            {
                throw new HelloSign.Client.ApiException(400, "Missing required parameter 'oAuthTokenRefreshRequest' when calling OAuthApi->OauthTokenRefresh");
            }


            HelloSign.Client.RequestOptions localVarRequestOptions = new HelloSign.Client.RequestOptions();

            var localVarContentType = "";
            var openApiTypes = oAuthTokenRefreshRequest.GetOpenApiTypes();
            if (ClientUtils.HasFileType(openApiTypes))
            {
                ClientUtils.SetFormData(localVarRequestOptions, openApiTypes);
                localVarContentType = "multipart/form-data";
            }
            else
            {
                localVarContentType = "application/json";
                localVarRequestOptions.Data = oAuthTokenRefreshRequest;
            }

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = HelloSign.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = "OAuthApi.OauthTokenRefresh";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<OAuthTokenResponse>("/oauth/token?refresh", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OauthTokenRefresh", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
