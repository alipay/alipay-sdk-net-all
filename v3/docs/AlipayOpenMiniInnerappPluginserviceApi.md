# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerappPluginserviceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Publish**](AlipayOpenMiniInnerappPluginserviceApi.md#publish) | **POST** /v3/alipay/open/mini/innerapp/pluginservice/publish | 插件发布能力中心


<a name="publish"></a>
# **Publish**
> AlipayOpenMiniInnerappPluginservicePublishResponseModel Publish (AlipayOpenMiniInnerappPluginservicePublishModel alipayOpenMiniInnerappPluginservicePublishModel = null)

插件发布能力中心

插件发布能力中心

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
    public class PublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniInnerappPluginserviceApi(config);

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

            var alipayOpenMiniInnerappPluginservicePublishModel = new AlipayOpenMiniInnerappPluginservicePublishModel(); // AlipayOpenMiniInnerappPluginservicePublishModel |  (optional) 

            try
            {
                // 插件发布能力中心
                AlipayOpenMiniInnerappPluginservicePublishResponseModel result = apiInstance.Publish(alipayOpenMiniInnerappPluginservicePublishModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappPluginserviceApi.Publish: " + e.Message );
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
 **alipayOpenMiniInnerappPluginservicePublishModel** | **AlipayOpenMiniInnerappPluginservicePublishModel**|  | [optional] 

### Return type

**AlipayOpenMiniInnerappPluginservicePublishResponseModel**

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

