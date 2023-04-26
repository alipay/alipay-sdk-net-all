# AlipaySDKNet.OpenAPI.Api.AlipayMerchantTradecomplainReplyApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Submit**](AlipayMerchantTradecomplainReplyApi.md#submit) | **POST** /v3/alipay/merchant/tradecomplain/reply | 商家留言回复


<a name="submit"></a>
# **Submit**
> Object Submit (AlipayMerchantTradecomplainReplySubmitModel alipayMerchantTradecomplainReplySubmitModel = null)

商家留言回复

投诉单状态在“商家待处理”或“商家已反馈”或“商家处理超时”状态下，若有内容需要补充说明，可使用此接口提交文字或图片

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
            var apiInstance = new AlipayMerchantTradecomplainReplyApi(config);

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

            var alipayMerchantTradecomplainReplySubmitModel = new AlipayMerchantTradecomplainReplySubmitModel(); // AlipayMerchantTradecomplainReplySubmitModel |  (optional) 

            try
            {
                // 商家留言回复
                Object result = apiInstance.Submit(alipayMerchantTradecomplainReplySubmitModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantTradecomplainReplyApi.Submit: " + e.Message );
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
 **alipayMerchantTradecomplainReplySubmitModel** | **AlipayMerchantTradecomplainReplySubmitModel**|  | [optional] 

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

