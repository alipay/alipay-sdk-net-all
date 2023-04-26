# AlipaySDKNet.OpenAPI.Api.AlipayMobilePublicQrcodeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayMobilePublicQrcodeApi.md#create) | **POST** /v3/alipay/mobile/public/qrcode/create | 生成带参数的二维码


<a name="create"></a>
# **Create**
> AlipayMobilePublicQrcodeCreateResponseModel Create (AlipayMobilePublicQrcodeCreateModel alipayMobilePublicQrcodeCreateModel = null)

生成带参数的二维码

为了满足用户渠道推广分析的需要，公众平台提供了生成带参数二维码的接口。使用该接口可以获得多个带不同场景值的二维码，用户扫描后，公众号可以接收到事件推送。目前有2种类型的二维码，分别是临时二维码、和永久二维码，前者有过期时间，最大为1800秒。  每次创建二维码ticket需要提供一个开发者自行设定的参数（scene_id）。

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMobilePublicQrcodeApi(config);

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

            var alipayMobilePublicQrcodeCreateModel = new AlipayMobilePublicQrcodeCreateModel(); // AlipayMobilePublicQrcodeCreateModel |  (optional) 

            try
            {
                // 生成带参数的二维码
                AlipayMobilePublicQrcodeCreateResponseModel result = apiInstance.Create(alipayMobilePublicQrcodeCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMobilePublicQrcodeApi.Create: " + e.Message );
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
 **alipayMobilePublicQrcodeCreateModel** | **AlipayMobilePublicQrcodeCreateModel**|  | [optional] 

### Return type

**AlipayMobilePublicQrcodeCreateResponseModel**

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

