# AlipaySDKNet.OpenAPI.Api.AlipayMerchantTradecomplainFeedbackApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Submit**](AlipayMerchantTradecomplainFeedbackApi.md#submit) | **POST** /v3/alipay/merchant/tradecomplain/feedback | 商家处理交易投诉


<a name="submit"></a>
# **Submit**
> Object Submit (AlipayMerchantTradecomplainFeedbackSubmitModel alipayMerchantTradecomplainFeedbackSubmitModel = null)

商家处理交易投诉

商户请求交易投诉处理API，上传处理类型、处理内容描述及图片凭证。其中上传图片凭证需要先通过\"商户上传处理图片\"接口获取图片id，再将图片id设置到接口请求中。

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
            var apiInstance = new AlipayMerchantTradecomplainFeedbackApi(config);

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

            var alipayMerchantTradecomplainFeedbackSubmitModel = new AlipayMerchantTradecomplainFeedbackSubmitModel(); // AlipayMerchantTradecomplainFeedbackSubmitModel |  (optional) 

            try
            {
                // 商家处理交易投诉
                Object result = apiInstance.Submit(alipayMerchantTradecomplainFeedbackSubmitModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantTradecomplainFeedbackApi.Submit: " + e.Message );
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
 **alipayMerchantTradecomplainFeedbackSubmitModel** | **AlipayMerchantTradecomplainFeedbackSubmitModel**|  | [optional] 

### Return type

**Object**

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

