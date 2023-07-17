# AlipaySDKNet.OpenAPI.Api.AlipayTradeOrderSettleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayTradeOrderSettleApi.md#query) | **GET** /v3/alipay/trade/order/settle/query | 交易分账查询接口


<a name="query"></a>
# **Query**
> AlipayTradeOrderSettleQueryResponseModel Query (string settleNo = null, string outRequestNo = null, string tradeNo = null)

交易分账查询接口

根据分账请求号查询交易分账结果

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
            var apiInstance = new AlipayTradeOrderSettleApi(config);

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

            var settleNo = 20210706002530020036530021395831;  // string | 支付宝分账请求单号，传入该字段，无需再传外部请求号和支付宝交易号 (optional) 
            var outRequestNo = 20210727001;  // string | 调用分账接口时指定的外部请求号。分账查询时需要和支付宝交易号一起传入 (optional) 
            var tradeNo = 2021112611001004680 073956707;  // string | 支付宝交易号，传入该字段，需要和外部请求号一起传入 (optional) 

            try
            {
                // 交易分账查询接口
                AlipayTradeOrderSettleQueryResponseModel result = apiInstance.Query(settleNo, outRequestNo, tradeNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeOrderSettleApi.Query: " + e.Message );
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
 **settleNo** | **string**| 支付宝分账请求单号，传入该字段，无需再传外部请求号和支付宝交易号 | [optional] 
 **outRequestNo** | **string**| 调用分账接口时指定的外部请求号。分账查询时需要和支付宝交易号一起传入 | [optional] 
 **tradeNo** | **string**| 支付宝交易号，传入该字段，需要和外部请求号一起传入 | [optional] 

### Return type

**AlipayTradeOrderSettleQueryResponseModel**

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

