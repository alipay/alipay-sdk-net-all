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
    public interface IAlipayFundTransCommonApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 转账业务单据查询接口
        /// </summary>
        /// <remarks>
        /// 商户可通过该接口查询转账业务单据的状态，主要应用于统一转账接口(alipay.fund.trans.uni.transfer)、无线转账接口(alipay.fund.trans.app.pay)、单笔转账到支付宝账户接口（alipay.fund.trans.toaccount.transfer）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡 (optional)</param>
        /// <param name="bizScene">描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账 (optional)</param>
        /// <param name="outBizNo">商户转账唯一订单号，发起转账来源方定义的转账单据ID。  本参数和order_id（支付宝转账单据号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。 当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号。 本参数和out_biz_no（商户转账唯一订单号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。  当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和pay_fund_order_id（支付宝支付资金流水号）同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号。本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和out_biz_no（商户转账唯一订单号）、order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略其余两者； 当本参数和order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundTransCommonQueryResponseModel</returns>
        AlipayFundTransCommonQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string orderId = default(string), string payFundOrderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 转账业务单据查询接口
        /// </summary>
        /// <remarks>
        /// 商户可通过该接口查询转账业务单据的状态，主要应用于统一转账接口(alipay.fund.trans.uni.transfer)、无线转账接口(alipay.fund.trans.app.pay)、单笔转账到支付宝账户接口（alipay.fund.trans.toaccount.transfer）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡 (optional)</param>
        /// <param name="bizScene">描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账 (optional)</param>
        /// <param name="outBizNo">商户转账唯一订单号，发起转账来源方定义的转账单据ID。  本参数和order_id（支付宝转账单据号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。 当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号。 本参数和out_biz_no（商户转账唯一订单号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。  当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和pay_fund_order_id（支付宝支付资金流水号）同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号。本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和out_biz_no（商户转账唯一订单号）、order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略其余两者； 当本参数和order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundTransCommonQueryResponseModel</returns>
        ApiResponse<AlipayFundTransCommonQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string orderId = default(string), string payFundOrderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundTransCommonApi : IAlipayFundTransCommonApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundTransCommonApi : IAlipayFundTransCommonApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransCommonApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundTransCommonApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransCommonApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundTransCommonApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransCommonApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundTransCommonApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayFundTransCommonApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundTransCommonApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 转账业务单据查询接口 商户可通过该接口查询转账业务单据的状态，主要应用于统一转账接口(alipay.fund.trans.uni.transfer)、无线转账接口(alipay.fund.trans.app.pay)、单笔转账到支付宝账户接口（alipay.fund.trans.toaccount.transfer）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡 (optional)</param>
        /// <param name="bizScene">描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账 (optional)</param>
        /// <param name="outBizNo">商户转账唯一订单号，发起转账来源方定义的转账单据ID。  本参数和order_id（支付宝转账单据号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。 当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号。 本参数和out_biz_no（商户转账唯一订单号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。  当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和pay_fund_order_id（支付宝支付资金流水号）同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号。本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和out_biz_no（商户转账唯一订单号）、order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略其余两者； 当本参数和order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundTransCommonQueryResponseModel</returns>
        public AlipayFundTransCommonQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string orderId = default(string), string payFundOrderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundTransCommonQueryResponseModel> localVarResponse = QueryWithHttpInfo(productCode, bizScene, outBizNo, orderId, payFundOrderId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 转账业务单据查询接口 商户可通过该接口查询转账业务单据的状态，主要应用于统一转账接口(alipay.fund.trans.uni.transfer)、无线转账接口(alipay.fund.trans.app.pay)、单笔转账到支付宝账户接口（alipay.fund.trans.toaccount.transfer）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡 (optional)</param>
        /// <param name="bizScene">描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账 (optional)</param>
        /// <param name="outBizNo">商户转账唯一订单号，发起转账来源方定义的转账单据ID。  本参数和order_id（支付宝转账单据号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。 当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号。 本参数和out_biz_no（商户转账唯一订单号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。  当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和pay_fund_order_id（支付宝支付资金流水号）同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号。本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和out_biz_no（商户转账唯一订单号）、order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略其余两者； 当本参数和order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundTransCommonQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundTransCommonQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string orderId = default(string), string payFundOrderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (productCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "product_code", productCode));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }
            if (orderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "order_id", orderId));
            }
            if (payFundOrderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "pay_fund_order_id", payFundOrderId));
            }

            localVarRequestOptions.Operation = "AlipayFundTransCommonApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundTransCommonQueryResponseModel>("/v3/alipay/fund/trans/common/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundTransCommonQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
