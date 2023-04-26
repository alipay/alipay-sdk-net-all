# AlipaySDKNet.OpenAPI.Api.AlipayMerchantTradecomplainSupplementApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Submit**](AlipayMerchantTradecomplainSupplementApi.md#submit) | **POST** /v3/alipay/merchant/tradecomplain/supplement | 商家补充凭证


<a name="submit"></a>
# **Submit**
> Object Submit (AlipayMerchantTradecomplainSupplementSubmitModel alipayMerchantTradecomplainSupplementSubmitModel = null)

商家补充凭证

投诉进入平台处理中状态时，为保证客服能准确判定责任方，可使用此接口补充文字或图片说明问题及处理经过

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
            var apiInstance = new AlipayMerchantTradecomplainSupplementApi(config);

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

            var alipayMerchantTradecomplainSupplementSubmitModel = new AlipayMerchantTradecomplainSupplementSubmitModel(); // AlipayMerchantTradecomplainSupplementSubmitModel |  (optional) 

            try
            {
                // 商家补充凭证
                Object result = apiInstance.Submit(alipayMerchantTradecomplainSupplementSubmitModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantTradecomplainSupplementApi.Submit: " + e.Message );
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
 **alipayMerchantTradecomplainSupplementSubmitModel** | **AlipayMerchantTradecomplainSupplementSubmitModel**|  | [optional] 

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

