/*
 * Qase.io TestOps API v1
 *
 * Qase TestOps API v1 Specification.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@qase.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Qase.Client.Client;
using Qase.Client.Model;

namespace Qase.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a specific author
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a specific author. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuthorResponse</returns>
        AuthorResponse GetAuthor(int id, int operationIndex = 0);

        /// <summary>
        /// Get a specific author
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a specific author. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuthorResponse</returns>
        ApiResponse<AuthorResponse> GetAuthorWithHttpInfo(int id, int operationIndex = 0);
        /// <summary>
        /// Get all authors
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve all authors in selected project. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuthorListResponse</returns>
        AuthorListResponse GetAuthors(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0);

        /// <summary>
        /// Get all authors
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve all authors in selected project. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuthorListResponse</returns>
        ApiResponse<AuthorListResponse> GetAuthorsWithHttpInfo(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a specific author
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a specific author. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorResponse</returns>
        System.Threading.Tasks.Task<AuthorResponse> GetAuthorAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Get a specific author
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a specific author. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthorResponse>> GetAuthorWithHttpInfoAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Get all authors
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve all authors in selected project. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorListResponse</returns>
        System.Threading.Tasks.Task<AuthorListResponse> GetAuthorsAsync(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Get all authors
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve all authors in selected project. 
        /// </remarks>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthorListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthorListResponse>> GetAuthorsWithHttpInfoAsync(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorsApi : IAuthorsApiSync, IAuthorsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorsApi : IAuthorsApi
    {
        private Qase.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorsApi(string basePath)
        {
            this.Configuration = Qase.Client.Client.Configuration.MergeConfigurations(
                Qase.Client.Client.GlobalConfiguration.Instance,
                new Qase.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Qase.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Qase.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Qase.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorsApi(Qase.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Qase.Client.Client.Configuration.MergeConfigurations(
                Qase.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Qase.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Qase.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Qase.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthorsApi(Qase.Client.Client.ISynchronousClient client, Qase.Client.Client.IAsynchronousClient asyncClient, Qase.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Qase.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Qase.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Qase.Client.Client.ISynchronousClient Client { get; set; }

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
        public Qase.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Qase.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Get a specific author This method allows to retrieve a specific author. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuthorResponse</returns>
        public AuthorResponse GetAuthor(int id, int operationIndex = 0)
        {
            Qase.Client.Client.ApiResponse<AuthorResponse> localVarResponse = GetAuthorWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific author This method allows to retrieve a specific author. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuthorResponse</returns>
        public Qase.Client.Client.ApiResponse<AuthorResponse> GetAuthorWithHttpInfo(int id, int operationIndex = 0)
        {
            Qase.Client.Client.RequestOptions localVarRequestOptions = new Qase.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Qase.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Qase.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Qase.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "AuthorsApi.GetAuthor";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (TokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("Token", this.Configuration.GetApiKeyWithPrefix("Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AuthorResponse>("/author/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAuthor", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific author This method allows to retrieve a specific author. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorResponse</returns>
        public async System.Threading.Tasks.Task<AuthorResponse> GetAuthorAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Qase.Client.Client.ApiResponse<AuthorResponse> localVarResponse = await GetAuthorWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific author This method allows to retrieve a specific author. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthorResponse)</returns>
        public async System.Threading.Tasks.Task<Qase.Client.Client.ApiResponse<AuthorResponse>> GetAuthorWithHttpInfoAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Qase.Client.Client.RequestOptions localVarRequestOptions = new Qase.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Qase.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Qase.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Qase.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "AuthorsApi.GetAuthor";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (TokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("Token", this.Configuration.GetApiKeyWithPrefix("Token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AuthorResponse>("/author/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAuthor", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all authors This method allows to retrieve all authors in selected project. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AuthorListResponse</returns>
        public AuthorListResponse GetAuthors(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0)
        {
            Qase.Client.Client.ApiResponse<AuthorListResponse> localVarResponse = GetAuthorsWithHttpInfo(search, type, limit, offset);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all authors This method allows to retrieve all authors in selected project. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AuthorListResponse</returns>
        public Qase.Client.Client.ApiResponse<AuthorListResponse> GetAuthorsWithHttpInfo(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0)
        {
            Qase.Client.Client.RequestOptions localVarRequestOptions = new Qase.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Qase.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Qase.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            localVarRequestOptions.Operation = "AuthorsApi.GetAuthors";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (TokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("Token", this.Configuration.GetApiKeyWithPrefix("Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AuthorListResponse>("/author", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAuthors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all authors This method allows to retrieve all authors in selected project. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthorListResponse</returns>
        public async System.Threading.Tasks.Task<AuthorListResponse> GetAuthorsAsync(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Qase.Client.Client.ApiResponse<AuthorListResponse> localVarResponse = await GetAuthorsWithHttpInfoAsync(search, type, limit, offset, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all authors This method allows to retrieve all authors in selected project. 
        /// </summary>
        /// <exception cref="Qase.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Provide a string that will be used to search by name. (optional)</param>
        /// <param name="type"> (optional)</param>
        /// <param name="limit">A number of entities in result set. (optional, default to 10)</param>
        /// <param name="offset">How many entities should be skipped. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthorListResponse)</returns>
        public async System.Threading.Tasks.Task<Qase.Client.Client.ApiResponse<AuthorListResponse>> GetAuthorsWithHttpInfoAsync(string? search = default(string?), string? type = default(string?), int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Qase.Client.Client.RequestOptions localVarRequestOptions = new Qase.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Qase.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Qase.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(Qase.Client.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            localVarRequestOptions.Operation = "AuthorsApi.GetAuthors";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (TokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("Token", this.Configuration.GetApiKeyWithPrefix("Token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AuthorListResponse>("/author", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAuthors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
