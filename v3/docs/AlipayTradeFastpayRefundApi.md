# AlipaySDKNet.OpenAPI.Api.AlipayTradeFastpayRefundApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayTradeFastpayRefundApi.md#query) | **POST** /v3/alipay/trade/fastpay/refund/query | 统一收单交易退款查询


<a name="query"></a>
# **Query**
> AlipayTradeFastpayRefundQueryResponseModel Query (AlipayTradeFastpayRefundQueryModel alipayTradeFastpayRefundQueryModel = null)

统一收单交易退款查询

商户可使用该接口查询自已通过alipay.trade.refund提交的退款请求是否执行成功。

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
            var apiInstance = new AlipayTradeFastpayRefundApi(config);

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

            var alipayTradeFastpayRefundQueryModel = new AlipayTradeFastpayRefundQueryModel(); // AlipayTradeFastpayRefundQueryModel |  (optional) 

            try
            {
                // 统一收单交易退款查询
                AlipayTradeFastpayRefundQueryResponseModel result = apiInstance.Query(alipayTradeFastpayRefundQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeFastpayRefundApi.Query: " + e.Message );
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
 **alipayTradeFastpayRefundQueryModel** | **AlipayTradeFastpayRefundQueryModel**|  | [optional] 

### Return type

**AlipayTradeFastpayRefundQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

