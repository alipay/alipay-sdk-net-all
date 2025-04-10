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
    public interface IAlipayDataDataserviceBillDownloadurlApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询对账单下载地址
        /// </summary>
        /// <remarks>
        /// 为方便商户快速查账，支持商户通过本接口获取商户离线账单下载地址
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billType">账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型。 (optional)</param>
        /// <param name="billDate">账单时间：  * 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。  * 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。 * 当biz_type为settlementMerge时候，时间为汇总批次结算资金到账的日期，日期格式为yyyy-MM-dd，最早可下载2023年4月17日及以后的账单。 (optional)</param>
        /// <param name="smid">二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataDataserviceBillDownloadurlQueryResponseModel</returns>
        AlipayDataDataserviceBillDownloadurlQueryResponseModel Query(string billType = default(string), string billDate = default(string), string smid = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询对账单下载地址
        /// </summary>
        /// <remarks>
        /// 为方便商户快速查账，支持商户通过本接口获取商户离线账单下载地址
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billType">账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型。 (optional)</param>
        /// <param name="billDate">账单时间：  * 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。  * 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。 * 当biz_type为settlementMerge时候，时间为汇总批次结算资金到账的日期，日期格式为yyyy-MM-dd，最早可下载2023年4月17日及以后的账单。 (optional)</param>
        /// <param name="smid">二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataDataserviceBillDownloadurlQueryResponseModel</returns>
        ApiResponse<AlipayDataDataserviceBillDownloadurlQueryResponseModel> QueryWithHttpInfo(string billType = default(string), string billDate = default(string), string smid = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataDataserviceBillDownloadurlApi : IAlipayDataDataserviceBillDownloadurlApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayDataDataserviceBillDownloadurlApi : IAlipayDataDataserviceBillDownloadurlApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceBillDownloadurlApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataDataserviceBillDownloadurlApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceBillDownloadurlApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataDataserviceBillDownloadurlApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceBillDownloadurlApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayDataDataserviceBillDownloadurlApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceBillDownloadurlApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayDataDataserviceBillDownloadurlApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 查询对账单下载地址 为方便商户快速查账，支持商户通过本接口获取商户离线账单下载地址
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billType">账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型。 (optional)</param>
        /// <param name="billDate">账单时间：  * 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。  * 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。 * 当biz_type为settlementMerge时候，时间为汇总批次结算资金到账的日期，日期格式为yyyy-MM-dd，最早可下载2023年4月17日及以后的账单。 (optional)</param>
        /// <param name="smid">二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataDataserviceBillDownloadurlQueryResponseModel</returns>
        public AlipayDataDataserviceBillDownloadurlQueryResponseModel Query(string billType = default(string), string billDate = default(string), string smid = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataDataserviceBillDownloadurlQueryResponseModel> localVarResponse = QueryWithHttpInfo(billType, billDate, smid, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询对账单下载地址 为方便商户快速查账，支持商户通过本接口获取商户离线账单下载地址
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billType">账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型。 (optional)</param>
        /// <param name="billDate">账单时间：  * 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。  * 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。 * 当biz_type为settlementMerge时候，时间为汇总批次结算资金到账的日期，日期格式为yyyy-MM-dd，最早可下载2023年4月17日及以后的账单。 (optional)</param>
        /// <param name="smid">二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataDataserviceBillDownloadurlQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataDataserviceBillDownloadurlQueryResponseModel> QueryWithHttpInfo(string billType = default(string), string billDate = default(string), string smid = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (billType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "bill_type", billType));
            }
            if (billDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "bill_date", billDate));
            }
            if (smid != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "smid", smid));
            }

            localVarRequestOptions.Operation = "AlipayDataDataserviceBillDownloadurlApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayDataDataserviceBillDownloadurlQueryResponseModel>("/v3/alipay/data/dataservice/bill/downloadurl/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayDataDataserviceBillDownloadurlQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
