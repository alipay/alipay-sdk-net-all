/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-19
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceInstitutionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 制度新增
        /// </summary>
        /// <remarks>
        /// 制度新增，包含制度下使用规则列表、发放规则列表和适用范围的新增。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceInstitutionCreateResponseModel</returns>
        AlipayEbppInvoiceInstitutionCreateResponseModel Create(AlipayEbppInvoiceInstitutionCreateModel alipayEbppInvoiceInstitutionCreateModel = default(AlipayEbppInvoiceInstitutionCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 制度新增
        /// </summary>
        /// <remarks>
        /// 制度新增，包含制度下使用规则列表、发放规则列表和适用范围的新增。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceInstitutionCreateResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceInstitutionCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceInstitutionCreateModel alipayEbppInvoiceInstitutionCreateModel = default(AlipayEbppInvoiceInstitutionCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 制度删除
        /// </summary>
        /// <remarks>
        /// 制度删除
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="agreementNo">授权签约协议号 （该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="institutionId">制度id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceInstitutionDeleteResponseModel</returns>
        AlipayEbppInvoiceInstitutionDeleteResponseModel Delete(string accountId = default(string), string agreementNo = default(string), string enterpriseId = default(string), string institutionId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 制度删除
        /// </summary>
        /// <remarks>
        /// 制度删除
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="agreementNo">授权签约协议号 （该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="institutionId">制度id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceInstitutionDeleteResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceInstitutionDeleteResponseModel> DeleteWithHttpInfo(string accountId = default(string), string agreementNo = default(string), string enterpriseId = default(string), string institutionId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 制度编辑
        /// </summary>
        /// <remarks>
        /// 制度编辑，支持制度基本信息、制度下适用范围、制度下使用规则和发放规则的修改。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceInstitutionModifyResponseModel</returns>
        AlipayEbppInvoiceInstitutionModifyResponseModel Modify(AlipayEbppInvoiceInstitutionModifyModel alipayEbppInvoiceInstitutionModifyModel = default(AlipayEbppInvoiceInstitutionModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 制度编辑
        /// </summary>
        /// <remarks>
        /// 制度编辑，支持制度基本信息、制度下适用范围、制度下使用规则和发放规则的修改。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceInstitutionModifyResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceInstitutionModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceInstitutionModifyModel alipayEbppInvoiceInstitutionModifyModel = default(AlipayEbppInvoiceInstitutionModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceInstitutionApi : IAlipayEbppInvoiceInstitutionApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceInstitutionApi : IAlipayEbppInvoiceInstitutionApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceInstitutionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceInstitutionApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceInstitutionApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceInstitutionApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }


        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }

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
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
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
        /// 制度新增 制度新增，包含制度下使用规则列表、发放规则列表和适用范围的新增。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceInstitutionCreateResponseModel</returns>
        public AlipayEbppInvoiceInstitutionCreateResponseModel Create(AlipayEbppInvoiceInstitutionCreateModel alipayEbppInvoiceInstitutionCreateModel = default(AlipayEbppInvoiceInstitutionCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceInstitutionCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayEbppInvoiceInstitutionCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 制度新增 制度新增，包含制度下使用规则列表、发放规则列表和适用范围的新增。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceInstitutionCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceInstitutionCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceInstitutionCreateModel alipayEbppInvoiceInstitutionCreateModel = default(AlipayEbppInvoiceInstitutionCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceInstitutionCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceInstitutionApi.Create";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceInstitutionCreateResponseModel>("/v3/alipay/ebpp/invoice/institution/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceInstitutionCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 制度删除 制度删除
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="agreementNo">授权签约协议号 （该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="institutionId">制度id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceInstitutionDeleteResponseModel</returns>
        public AlipayEbppInvoiceInstitutionDeleteResponseModel Delete(string accountId = default(string), string agreementNo = default(string), string enterpriseId = default(string), string institutionId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceInstitutionDeleteResponseModel> localVarResponse = DeleteWithHttpInfo(accountId, agreementNo, enterpriseId, institutionId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 制度删除 制度删除
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="agreementNo">授权签约协议号 （该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换) (optional) (deprecated)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="institutionId">制度id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceInstitutionDeleteResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceInstitutionDeleteResponseModel> DeleteWithHttpInfo(string accountId = default(string), string agreementNo = default(string), string enterpriseId = default(string), string institutionId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (enterpriseId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "enterprise_id", enterpriseId));
            }
            if (institutionId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "institution_id", institutionId));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceInstitutionApi.Delete";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<AlipayEbppInvoiceInstitutionDeleteResponseModel>("/v3/alipay/ebpp/invoice/institution/delete", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceInstitutionDeleteDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 制度编辑 制度编辑，支持制度基本信息、制度下适用范围、制度下使用规则和发放规则的修改。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceInstitutionModifyResponseModel</returns>
        public AlipayEbppInvoiceInstitutionModifyResponseModel Modify(AlipayEbppInvoiceInstitutionModifyModel alipayEbppInvoiceInstitutionModifyModel = default(AlipayEbppInvoiceInstitutionModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceInstitutionModifyResponseModel> localVarResponse = ModifyWithHttpInfo(alipayEbppInvoiceInstitutionModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 制度编辑 制度编辑，支持制度基本信息、制度下适用范围、制度下使用规则和发放规则的修改。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceInstitutionModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceInstitutionModifyResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceInstitutionModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceInstitutionModifyModel alipayEbppInvoiceInstitutionModifyModel = default(AlipayEbppInvoiceInstitutionModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceInstitutionModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceInstitutionApi.Modify";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceInstitutionModifyResponseModel>("/v3/alipay/ebpp/invoice/institution/modify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceInstitutionModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
