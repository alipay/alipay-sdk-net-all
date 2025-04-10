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
    public interface IAlipayEbppInvoiceApplyInvApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 发票回传
        /// </summary>
        /// <remarks>
        /// 发票回传接口适用于以下场景： 1、间联开票模式：阿里发票平台向ISV提交了原始发票申请，商户在ISV后台开具发票成功后，基于申请ID(apply_id)回传发票至阿里发票平台归集与交付。 2、直连开票模式：阿里发票平台请求ISV开票，ISV系统异步执行开票事务后，基于开票流水号(serial_no)回传开票结果至阿里发票平台归集与交付。 3、ISV直接回传发票给阿里发票平台，进行归集，并交付给业务前台和用户。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceApplyInvUploadModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceApplyInvUploadResponseModel</returns>
        AlipayEbppInvoiceApplyInvUploadResponseModel Upload(AlipayEbppInvoiceApplyInvUploadModel alipayEbppInvoiceApplyInvUploadModel = default(AlipayEbppInvoiceApplyInvUploadModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 发票回传
        /// </summary>
        /// <remarks>
        /// 发票回传接口适用于以下场景： 1、间联开票模式：阿里发票平台向ISV提交了原始发票申请，商户在ISV后台开具发票成功后，基于申请ID(apply_id)回传发票至阿里发票平台归集与交付。 2、直连开票模式：阿里发票平台请求ISV开票，ISV系统异步执行开票事务后，基于开票流水号(serial_no)回传开票结果至阿里发票平台归集与交付。 3、ISV直接回传发票给阿里发票平台，进行归集，并交付给业务前台和用户。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceApplyInvUploadModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceApplyInvUploadResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceApplyInvUploadResponseModel> UploadWithHttpInfo(AlipayEbppInvoiceApplyInvUploadModel alipayEbppInvoiceApplyInvUploadModel = default(AlipayEbppInvoiceApplyInvUploadModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceApplyInvApi : IAlipayEbppInvoiceApplyInvApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceApplyInvApi : IAlipayEbppInvoiceApplyInvApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyInvApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceApplyInvApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyInvApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceApplyInvApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyInvApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceApplyInvApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyInvApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceApplyInvApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 发票回传 发票回传接口适用于以下场景： 1、间联开票模式：阿里发票平台向ISV提交了原始发票申请，商户在ISV后台开具发票成功后，基于申请ID(apply_id)回传发票至阿里发票平台归集与交付。 2、直连开票模式：阿里发票平台请求ISV开票，ISV系统异步执行开票事务后，基于开票流水号(serial_no)回传开票结果至阿里发票平台归集与交付。 3、ISV直接回传发票给阿里发票平台，进行归集，并交付给业务前台和用户。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceApplyInvUploadModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceApplyInvUploadResponseModel</returns>
        public AlipayEbppInvoiceApplyInvUploadResponseModel Upload(AlipayEbppInvoiceApplyInvUploadModel alipayEbppInvoiceApplyInvUploadModel = default(AlipayEbppInvoiceApplyInvUploadModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceApplyInvUploadResponseModel> localVarResponse = UploadWithHttpInfo(alipayEbppInvoiceApplyInvUploadModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 发票回传 发票回传接口适用于以下场景： 1、间联开票模式：阿里发票平台向ISV提交了原始发票申请，商户在ISV后台开具发票成功后，基于申请ID(apply_id)回传发票至阿里发票平台归集与交付。 2、直连开票模式：阿里发票平台请求ISV开票，ISV系统异步执行开票事务后，基于开票流水号(serial_no)回传开票结果至阿里发票平台归集与交付。 3、ISV直接回传发票给阿里发票平台，进行归集，并交付给业务前台和用户。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceApplyInvUploadModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceApplyInvUploadResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceApplyInvUploadResponseModel> UploadWithHttpInfo(AlipayEbppInvoiceApplyInvUploadModel alipayEbppInvoiceApplyInvUploadModel = default(AlipayEbppInvoiceApplyInvUploadModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayEbppInvoiceApplyInvUploadModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceApplyInvApi.Upload";
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
            var localVarResponse = this.Client.Put<AlipayEbppInvoiceApplyInvUploadResponseModel>("/v3/alipay/ebpp/invoice/apply/inv/upload", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Upload", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceApplyInvUploadDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
