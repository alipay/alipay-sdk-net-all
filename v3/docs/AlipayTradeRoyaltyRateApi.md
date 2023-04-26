# AlipaySDKNet.OpenAPI.Api.AlipayTradeRoyaltyRateApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayTradeRoyaltyRateApi.md#query) | **GET** /v3/alipay/trade/royalty/rate/query | 分账比例查询


<a name="query"></a>
# **Query**
> AlipayTradeRoyaltyRateQueryResponseModel Query (string outRequestNo = null)

分账比例查询

商户签约分账产品后，商户或其授权ISV可对分账比例进行查询。

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
            var apiInstance = new AlipayTradeRoyaltyRateApi(config);

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

            var outRequestNo = 20220823165400001;  // string | 外部请求号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。 (optional) 

            try
            {
                // 分账比例查询
                AlipayTradeRoyaltyRateQueryResponseModel result = apiInstance.Query(outRequestNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeRoyaltyRateApi.Query: " + e.Message );
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
 **outRequestNo** | **string**| 外部请求号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。 | [optional] 

### Return type

**AlipayTradeRoyaltyRateQueryResponseModel**

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

