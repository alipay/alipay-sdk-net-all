# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniWidgetDataApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayOpenMiniWidgetDataApi.md#sync) | **POST** /v3/alipay/open/mini/widget/data/sync | 小程序橱窗数据同步


<a name="sync"></a>
# **Sync**
> AlipayOpenMiniWidgetDataSyncResponseModel Sync (AlipayOpenMiniWidgetDataSyncModel alipayOpenMiniWidgetDataSyncModel = null)

小程序橱窗数据同步

面向商品售卖类的小程序橱窗，提供的橱窗内展示数据同步能力，同步后会进行文本和图片信息审核，审核完成后通知结果通过openmq消息通知

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
    public class SyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniWidgetDataApi(config);

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

            var alipayOpenMiniWidgetDataSyncModel = new AlipayOpenMiniWidgetDataSyncModel(); // AlipayOpenMiniWidgetDataSyncModel |  (optional) 

            try
            {
                // 小程序橱窗数据同步
                AlipayOpenMiniWidgetDataSyncResponseModel result = apiInstance.Sync(alipayOpenMiniWidgetDataSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniWidgetDataApi.Sync: " + e.Message );
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
 **alipayOpenMiniWidgetDataSyncModel** | **AlipayOpenMiniWidgetDataSyncModel**|  | [optional] 

### Return type

**AlipayOpenMiniWidgetDataSyncResponseModel**

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

