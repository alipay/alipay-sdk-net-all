# AlipaySDKNet.OpenAPI.Api.AlipayFundTransCommonApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundTransCommonApi.md#query) | **GET** /v3/alipay/fund/trans/common/query | 转账业务单据查询接口


<a name="query"></a>
# **Query**
> AlipayFundTransCommonQueryResponseModel Query (string productCode = null, string bizScene = null, string outBizNo = null, string orderId = null, string payFundOrderId = null)

转账业务单据查询接口

商户可通过该接口查询转账业务单据的状态，主要应用于统一转账接口(alipay.fund.trans.uni.transfer)、无线转账接口(alipay.fund.trans.app.pay)、单笔转账到支付宝账户接口（alipay.fund.trans.toaccount.transfer）

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AlipaySDKNet.OpenAPI.Api;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace Example
{
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundTransCommonApi(config);

            // 设置alipayConfig参数
            AlipayConfig alipayConfig = new AlipayConfig();
            alipayConfig.AppId = "app_id";
            alipayConfig.PrivateKey = "private_key";
            // 密钥模式
            alipayConfig.AlipayPublicKey = "alipay_public_key";
            // 证书模式
            // alipayConfig.AppCertPath = "../appCertPublicKey.crt";
            // alipayConfig.AlipayPublicCertPath = "../alipayCertPublicKey_RSA2.crt";
            // alipayConfig.RootCertPath = "../alipayRootCert.crt";
            alipayConfig.EncryptKey = "encrypt_key";
            AlipayConfigUtil alipayConfigUtil = new AlipayConfigUtil(alipayConfig);
            apiInstance.Client.SetAlipayConfigUtil(alipayConfigUtil);

            var productCode = STD_RED_PACKET;  // string | 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡 (optional) 
            var bizScene = PERSONAL_PAY;  // string | 描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账 (optional) 
            var outBizNo = 201808080001;  // string | 商户转账唯一订单号，发起转账来源方定义的转账单据ID。  本参数和order_id（支付宝转账单据号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。 当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional) 
            var orderId = 20190801110070000006380000250621;  // string | 支付宝转账单据号。 本参数和out_biz_no（商户转账唯一订单号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。  当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和pay_fund_order_id（支付宝支付资金流水号）同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional) 
            var payFundOrderId = 20190801110070001506380000251556;  // string | 支付宝支付资金流水号。本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和out_biz_no（商户转账唯一订单号）、order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略其余两者； 当本参数和order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional) 

            try
            {
                // 转账业务单据查询接口
                AlipayFundTransCommonQueryResponseModel result = apiInstance.Query(productCode, bizScene, outBizNo, orderId, payFundOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundTransCommonApi.Query: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productCode** | **string**| 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下： STD_RED_PACKET：现金红包 TRANS_ACCOUNT_NO_PWD：单笔无密转账到支付宝账户 TRANS_BANKCARD_NO_PWD：单笔无密转账到银行卡 | [optional] 
 **bizScene** | **string**| 描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账 | [optional] 
 **outBizNo** | **string**| 商户转账唯一订单号，发起转账来源方定义的转账单据ID。  本参数和order_id（支付宝转账单据号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。 当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 | [optional] 
 **orderId** | **string**| 支付宝转账单据号。 本参数和out_biz_no（商户转账唯一订单号）、pay_fund_order_id（支付宝支付资金流水号）三者不能同时为空。  当三者同时传入时，将用pay_fund_order_id（支付宝支付资金流水号）进行查询，忽略其余两者； 当本参数和pay_fund_order_id（支付宝支付资金流水号）同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 | [optional] 
 **payFundOrderId** | **string**| 支付宝支付资金流水号。本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和out_biz_no（商户转账唯一订单号）、order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略其余两者； 当本参数和order_id（支付宝转账单据号）同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和out_biz_no（商户转账唯一订单号）同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 | [optional] 

### Return type

**AlipayFundTransCommonQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

