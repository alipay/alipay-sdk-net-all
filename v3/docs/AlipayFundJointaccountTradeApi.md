# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountTradeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundJointaccountTradeApi.md#query) | **GET** /v3/alipay/fund/jointaccount/trade/query | 共同账户交易查询


<a name="query"></a>
# **Query**
> AlipayFundJointaccountTradeQueryResponseModel Query (string productCode = null, string bizScene = null, string memberId = null, string memberOpenId = null, string accountId = null, string agreementNo = null, string tradeNo = null, string platformOrderId = null)

共同账户交易查询

共同账户交易查询

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
            var apiInstance = new AlipayFundJointaccountTradeApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 销售产品码 (optional) 
            var bizScene = ELE_ONLINE;  // string | 业务场景 (optional) 
            var memberId = 208811123123;  // string | 成员ID，消费发起人 (optional) 
            var memberOpenId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 消费发起人的openId (optional) 
            var accountId = 208811123123;  // string | 企业账户ID (optional) 
            var agreementNo = 12312312313123;  // string | 三方授权协议号 (optional) 
            var tradeNo = 12312313123;  // string | 支付宝交易订单号 (optional) 
            var platformOrderId = 781773393333012410369282;  // string | 外部平台订单号。使用该参数查询时，返回结果见trade_info_list (optional) 

            try
            {
                // 共同账户交易查询
                AlipayFundJointaccountTradeQueryResponseModel result = apiInstance.Query(productCode, bizScene, memberId, memberOpenId, accountId, agreementNo, tradeNo, platformOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountTradeApi.Query: " + e.Message );
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
 **productCode** | **string**| 销售产品码 | [optional] 
 **bizScene** | **string**| 业务场景 | [optional] 
 **memberId** | **string**| 成员ID，消费发起人 | [optional] 
 **memberOpenId** | **string**| 消费发起人的openId | [optional] 
 **accountId** | **string**| 企业账户ID | [optional] 
 **agreementNo** | **string**| 三方授权协议号 | [optional] 
 **tradeNo** | **string**| 支付宝交易订单号 | [optional] 
 **platformOrderId** | **string**| 外部平台订单号。使用该参数查询时，返回结果见trade_info_list | [optional] 

### Return type

**AlipayFundJointaccountTradeQueryResponseModel**

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

