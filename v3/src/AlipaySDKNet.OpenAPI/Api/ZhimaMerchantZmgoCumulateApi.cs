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
    public interface IZhimaMerchantZmgoCumulateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 商家芝麻GO累计数据查询接口
        /// </summary>
        /// <remarks>
        /// 芝麻GO数据累计查询接口，包含汇总和明细信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">芝麻go协议号，唯一标识一个芝麻go协议。 (optional)</param>
        /// <param name="userId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="providerPid">数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="needDetail">是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。 (optional)</param>
        /// <param name="pageNo">分页参数，当need_detail&#x3D;true时需要，代表当前页数，从1开始。 (optional)</param>
        /// <param name="pageSize">分页参数，当need_detail&#x3D;true时需要，代表每页大小，不能大于20。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaMerchantZmgoCumulateQueryResponseModel</returns>
        ZhimaMerchantZmgoCumulateQueryResponseModel Query(string agreementId = default(string), string userId = default(string), string openId = default(string), string providerPid = default(string), bool? needDetail = default(bool?), int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 商家芝麻GO累计数据查询接口
        /// </summary>
        /// <remarks>
        /// 芝麻GO数据累计查询接口，包含汇总和明细信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">芝麻go协议号，唯一标识一个芝麻go协议。 (optional)</param>
        /// <param name="userId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="providerPid">数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="needDetail">是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。 (optional)</param>
        /// <param name="pageNo">分页参数，当need_detail&#x3D;true时需要，代表当前页数，从1开始。 (optional)</param>
        /// <param name="pageSize">分页参数，当need_detail&#x3D;true时需要，代表每页大小，不能大于20。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaMerchantZmgoCumulateQueryResponseModel</returns>
        ApiResponse<ZhimaMerchantZmgoCumulateQueryResponseModel> QueryWithHttpInfo(string agreementId = default(string), string userId = default(string), string openId = default(string), string providerPid = default(string), bool? needDetail = default(bool?), int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 商家芝麻GO累计数据回传接口
        /// </summary>
        /// <remarks>
        /// 外部商家接入芝麻GO场景下，回传用户行为履约数据给芝麻。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaMerchantZmgoCumulateSyncModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaMerchantZmgoCumulateSyncResponseModel</returns>
        ZhimaMerchantZmgoCumulateSyncResponseModel Sync(ZhimaMerchantZmgoCumulateSyncModel zhimaMerchantZmgoCumulateSyncModel = default(ZhimaMerchantZmgoCumulateSyncModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 商家芝麻GO累计数据回传接口
        /// </summary>
        /// <remarks>
        /// 外部商家接入芝麻GO场景下，回传用户行为履约数据给芝麻。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaMerchantZmgoCumulateSyncModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaMerchantZmgoCumulateSyncResponseModel</returns>
        ApiResponse<ZhimaMerchantZmgoCumulateSyncResponseModel> SyncWithHttpInfo(ZhimaMerchantZmgoCumulateSyncModel zhimaMerchantZmgoCumulateSyncModel = default(ZhimaMerchantZmgoCumulateSyncModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaMerchantZmgoCumulateApi : IZhimaMerchantZmgoCumulateApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZhimaMerchantZmgoCumulateApi : IZhimaMerchantZmgoCumulateApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoCumulateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaMerchantZmgoCumulateApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoCumulateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaMerchantZmgoCumulateApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoCumulateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZhimaMerchantZmgoCumulateApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoCumulateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ZhimaMerchantZmgoCumulateApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 商家芝麻GO累计数据查询接口 芝麻GO数据累计查询接口，包含汇总和明细信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">芝麻go协议号，唯一标识一个芝麻go协议。 (optional)</param>
        /// <param name="userId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="providerPid">数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="needDetail">是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。 (optional)</param>
        /// <param name="pageNo">分页参数，当need_detail&#x3D;true时需要，代表当前页数，从1开始。 (optional)</param>
        /// <param name="pageSize">分页参数，当need_detail&#x3D;true时需要，代表每页大小，不能大于20。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaMerchantZmgoCumulateQueryResponseModel</returns>
        public ZhimaMerchantZmgoCumulateQueryResponseModel Query(string agreementId = default(string), string userId = default(string), string openId = default(string), string providerPid = default(string), bool? needDetail = default(bool?), int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaMerchantZmgoCumulateQueryResponseModel> localVarResponse = QueryWithHttpInfo(agreementId, userId, openId, providerPid, needDetail, pageNo, pageSize, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 商家芝麻GO累计数据查询接口 芝麻GO数据累计查询接口，包含汇总和明细信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">芝麻go协议号，唯一标识一个芝麻go协议。 (optional)</param>
        /// <param name="userId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="providerPid">数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="needDetail">是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。 (optional)</param>
        /// <param name="pageNo">分页参数，当need_detail&#x3D;true时需要，代表当前页数，从1开始。 (optional)</param>
        /// <param name="pageSize">分页参数，当need_detail&#x3D;true时需要，代表每页大小，不能大于20。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaMerchantZmgoCumulateQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaMerchantZmgoCumulateQueryResponseModel> QueryWithHttpInfo(string agreementId = default(string), string userId = default(string), string openId = default(string), string providerPid = default(string), bool? needDetail = default(bool?), int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (agreementId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_id", agreementId));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (providerPid != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "provider_pid", providerPid));
            }
            if (needDetail != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "need_detail", needDetail));
            }
            if (pageNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_no", pageNo));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "ZhimaMerchantZmgoCumulateApi.Query";
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
            var localVarResponse = this.Client.Get<ZhimaMerchantZmgoCumulateQueryResponseModel>("/v3/zhima/merchant/zmgo/cumulate/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaMerchantZmgoCumulateQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 商家芝麻GO累计数据回传接口 外部商家接入芝麻GO场景下，回传用户行为履约数据给芝麻。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaMerchantZmgoCumulateSyncModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaMerchantZmgoCumulateSyncResponseModel</returns>
        public ZhimaMerchantZmgoCumulateSyncResponseModel Sync(ZhimaMerchantZmgoCumulateSyncModel zhimaMerchantZmgoCumulateSyncModel = default(ZhimaMerchantZmgoCumulateSyncModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaMerchantZmgoCumulateSyncResponseModel> localVarResponse = SyncWithHttpInfo(zhimaMerchantZmgoCumulateSyncModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 商家芝麻GO累计数据回传接口 外部商家接入芝麻GO场景下，回传用户行为履约数据给芝麻。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaMerchantZmgoCumulateSyncModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaMerchantZmgoCumulateSyncResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaMerchantZmgoCumulateSyncResponseModel> SyncWithHttpInfo(ZhimaMerchantZmgoCumulateSyncModel zhimaMerchantZmgoCumulateSyncModel = default(ZhimaMerchantZmgoCumulateSyncModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = zhimaMerchantZmgoCumulateSyncModel;
            }

            localVarRequestOptions.Operation = "ZhimaMerchantZmgoCumulateApi.Sync";
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
            var localVarResponse = this.Client.Post<ZhimaMerchantZmgoCumulateSyncResponseModel>("/v3/zhima/merchant/zmgo/cumulate/sync", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Sync", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaMerchantZmgoCumulateSyncDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
