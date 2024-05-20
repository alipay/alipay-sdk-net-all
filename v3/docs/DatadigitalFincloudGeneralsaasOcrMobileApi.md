# AlipaySDKNet.OpenAPI.Api.DatadigitalFincloudGeneralsaasOcrMobileApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Initialize**](DatadigitalFincloudGeneralsaasOcrMobileApi.md#initialize) | **POST** /v3/datadigital/fincloud/generalsaas/ocr/mobile/initialize | App端OCR初始化


<a name="initialize"></a>
# **Initialize**
> DatadigitalFincloudGeneralsaasOcrMobileInitializeResponseModel Initialize (DatadigitalFincloudGeneralsaasOcrMobileInitializeModel datadigitalFincloudGeneralsaasOcrMobileInitializeModel = null)

App端OCR初始化

OCR端云一体化识别

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
    public class InitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new DatadigitalFincloudGeneralsaasOcrMobileApi(config);

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

            var datadigitalFincloudGeneralsaasOcrMobileInitializeModel = new DatadigitalFincloudGeneralsaasOcrMobileInitializeModel(); // DatadigitalFincloudGeneralsaasOcrMobileInitializeModel |  (optional) 

            try
            {
                // App端OCR初始化
                DatadigitalFincloudGeneralsaasOcrMobileInitializeResponseModel result = apiInstance.Initialize(datadigitalFincloudGeneralsaasOcrMobileInitializeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasOcrMobileApi.Initialize: " + e.Message );
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
 **datadigitalFincloudGeneralsaasOcrMobileInitializeModel** | **DatadigitalFincloudGeneralsaasOcrMobileInitializeModel**|  | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasOcrMobileInitializeResponseModel**

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

