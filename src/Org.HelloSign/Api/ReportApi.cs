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
using Org.HelloSign.Client;
using Org.HelloSign.Model;

namespace Org.HelloSign.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </remarks>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReportCreateResponse</returns>
        ReportCreateResponse ReportCreate(ReportCreateRequest reportCreateRequest, int operationIndex = 0);

        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </remarks>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReportCreateResponse</returns>
        ApiResponse<ReportCreateResponse> ReportCreateWithHttpInfo(ReportCreateRequest reportCreateRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </remarks>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportCreateResponse</returns>
        System.Threading.Tasks.Task<ReportCreateResponse> ReportCreateAsync(ReportCreateRequest reportCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create Report
        /// </summary>
        /// <remarks>
        /// Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </remarks>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportCreateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportCreateResponse>> ReportCreateWithHttpInfoAsync(ReportCreateRequest reportCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportApi : IReportApiSync, IReportApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportApi : IReportApi
    {
        private Org.HelloSign.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportApi(string basePath)
        {
            this.Configuration = Org.HelloSign.Client.Configuration.MergeConfigurations(
                Org.HelloSign.Client.GlobalConfiguration.Instance,
                new Org.HelloSign.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.HelloSign.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.HelloSign.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.HelloSign.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportApi(Org.HelloSign.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.HelloSign.Client.Configuration.MergeConfigurations(
                Org.HelloSign.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.HelloSign.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.HelloSign.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.HelloSign.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ReportApi(Org.HelloSign.Client.ISynchronousClient client, Org.HelloSign.Client.IAsynchronousClient asyncClient, Org.HelloSign.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.HelloSign.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.HelloSign.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.HelloSign.Client.ISynchronousClient Client { get; set; }

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
        public Org.HelloSign.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.HelloSign.Client.ExceptionFactory ExceptionFactory
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
        /// Create Report Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </summary>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReportCreateResponse</returns>
        public ReportCreateResponse ReportCreate(ReportCreateRequest reportCreateRequest, int operationIndex = 0)
        {
            Org.HelloSign.Client.ApiResponse<ReportCreateResponse> localVarResponse = ReportCreateWithHttpInfo(reportCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Report Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </summary>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReportCreateResponse</returns>
        public Org.HelloSign.Client.ApiResponse<ReportCreateResponse> ReportCreateWithHttpInfo(ReportCreateRequest reportCreateRequest, int operationIndex = 0)
        {
            // verify the required parameter 'reportCreateRequest' is set
            if (reportCreateRequest == null)
            {
                throw new Org.HelloSign.Client.ApiException(400, "Missing required parameter 'reportCreateRequest' when calling ReportApi->ReportCreate");
            }

            Org.HelloSign.Client.RequestOptions localVarRequestOptions = new Org.HelloSign.Client.RequestOptions();

            var localVarContentType = "";
            var openApiTypes = reportCreateRequest.GetOpenApiTypes();
            if (ClientUtils.HasFileType(openApiTypes))
            {
                ClientUtils.SetFormData(localVarRequestOptions, openApiTypes);
                localVarContentType = "multipart/form-data";
            }
            else
            {
                localVarContentType = "application/json";
                localVarRequestOptions.Data = reportCreateRequest;
            }

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.HelloSign.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = "ReportApi.ReportCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Org.HelloSign.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ReportCreateResponse>("/report/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Report Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </summary>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReportCreateResponse</returns>
        public async System.Threading.Tasks.Task<ReportCreateResponse> ReportCreateAsync(ReportCreateRequest reportCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.HelloSign.Client.ApiResponse<ReportCreateResponse> localVarResponse = await ReportCreateWithHttpInfoAsync(reportCreateRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Report Request the creation of one or more report(s).  When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and &#x60;start_date&#x60; must not be more than 10 years in the past.
        /// </summary>
        /// <exception cref="Org.HelloSign.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportCreateRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReportCreateResponse)</returns>
        public async System.Threading.Tasks.Task<Org.HelloSign.Client.ApiResponse<ReportCreateResponse>> ReportCreateWithHttpInfoAsync(ReportCreateRequest reportCreateRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'reportCreateRequest' is set
            if (reportCreateRequest == null)
            {
                throw new Org.HelloSign.Client.ApiException(400, "Missing required parameter 'reportCreateRequest' when calling ReportApi->ReportCreate");
            }


            Org.HelloSign.Client.RequestOptions localVarRequestOptions = new Org.HelloSign.Client.RequestOptions();

            var localVarContentType = "";
            var openApiTypes = reportCreateRequest.GetOpenApiTypes();
            if (ClientUtils.HasFileType(openApiTypes))
            {
                ClientUtils.SetFormData(localVarRequestOptions, openApiTypes);
                localVarContentType = "multipart/form-data";
            }
            else
            {
                localVarContentType = "application/json";
                localVarRequestOptions.Data = reportCreateRequest;
            }

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.HelloSign.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Operation = "ReportApi.ReportCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Org.HelloSign.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ReportCreateResponse>("/report/create", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReportCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}