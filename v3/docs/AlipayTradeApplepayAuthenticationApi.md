# AlipaySDKNet.OpenAPI.Api.AlipayTradeApplepayAuthenticationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Submit**](AlipayTradeApplepayAuthenticationApi.md#submit) | **POST** /v3/alipay/trade/applepay/authentication/submit | ApplePay支付鉴权提交


<a name="submit"></a>
# **Submit**
> AlipayTradeApplepayAuthenticationSubmitResponseModel Submit (AlipayTradeApplepayAuthenticationSubmitModel alipayTradeApplepayAuthenticationSubmitModel = null)

ApplePay支付鉴权提交

ApplePay定义的接口，支付宝进行适配。ApplePay端支付核身完毕后，提交到支付宝进行核身验证+支付推进。

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
    public class SubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayTradeApplepayAuthenticationApi(config);

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

            var alipayTradeApplepayAuthenticationSubmitModel = new AlipayTradeApplepayAuthenticationSubmitModel(); // AlipayTradeApplepayAuthenticationSubmitModel |  (optional) 

            try
            {
                // ApplePay支付鉴权提交
                AlipayTradeApplepayAuthenticationSubmitResponseModel result = apiInstance.Submit(alipayTradeApplepayAuthenticationSubmitModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeApplepayAuthenticationApi.Submit: " + e.Message );
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
 **alipayTradeApplepayAuthenticationSubmitModel** | **AlipayTradeApplepayAuthenticationSubmitModel**|  | [optional] 

### Return type

**AlipayTradeApplepayAuthenticationSubmitResponseModel**

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

