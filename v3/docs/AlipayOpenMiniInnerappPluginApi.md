# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerappPluginApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Order**](AlipayOpenMiniInnerappPluginApi.md#order) | **POST** /v3/alipay/open/mini/innerapp/plugin/order | 小程序代商户订购插件


<a name="order"></a>
# **Order**
> AlipayOpenMiniInnerappPluginOrderResponseModel Order (AlipayOpenMiniInnerappPluginOrderModel alipayOpenMiniInnerappPluginOrderModel = null)

小程序代商户订购插件

提供给二方场景下，代商家小程序订购、授权与签约插件

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
    public class OrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniInnerappPluginApi(config);

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

            var alipayOpenMiniInnerappPluginOrderModel = new AlipayOpenMiniInnerappPluginOrderModel(); // AlipayOpenMiniInnerappPluginOrderModel |  (optional) 

            try
            {
                // 小程序代商户订购插件
                AlipayOpenMiniInnerappPluginOrderResponseModel result = apiInstance.Order(alipayOpenMiniInnerappPluginOrderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappPluginApi.Order: " + e.Message );
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
 **alipayOpenMiniInnerappPluginOrderModel** | **AlipayOpenMiniInnerappPluginOrderModel**|  | [optional] 

### Return type

**AlipayOpenMiniInnerappPluginOrderResponseModel**

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

