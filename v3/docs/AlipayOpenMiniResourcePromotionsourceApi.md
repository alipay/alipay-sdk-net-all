# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniResourcePromotionsourceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Notify**](AlipayOpenMiniResourcePromotionsourceApi.md#notify) | **POST** /v3/alipay/open/mini/resource/promotionsource/notify | 提供给淘联盟推广位信息接口


<a name="notify"></a>
# **Notify**
> Object Notify (AlipayOpenMiniResourcePromotionsourceNotifyModel alipayOpenMiniResourcePromotionsourceNotifyModel = null)

提供给淘联盟推广位信息接口

淘联盟定制回调接口，用户流量插件账号打通场景

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
    public class NotifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniResourcePromotionsourceApi(config);

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

            var alipayOpenMiniResourcePromotionsourceNotifyModel = new AlipayOpenMiniResourcePromotionsourceNotifyModel(); // AlipayOpenMiniResourcePromotionsourceNotifyModel |  (optional) 

            try
            {
                // 提供给淘联盟推广位信息接口
                Object result = apiInstance.Notify(alipayOpenMiniResourcePromotionsourceNotifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniResourcePromotionsourceApi.Notify: " + e.Message );
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
 **alipayOpenMiniResourcePromotionsourceNotifyModel** | **AlipayOpenMiniResourcePromotionsourceNotifyModel**|  | [optional] 

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

