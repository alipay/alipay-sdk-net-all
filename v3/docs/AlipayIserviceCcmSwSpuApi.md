# AlipaySDKNet.OpenAPI.Api.AlipayIserviceCcmSwSpuApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayIserviceCcmSwSpuApi.md#sync) | **POST** /v3/alipay/iservice/ccm/sw/spu/sync | 商品库-商品信息同步


<a name="sync"></a>
# **Sync**
> AlipayIserviceCcmSwSpuSyncResponseModel Sync (AlipayIserviceCcmSwSpuSyncModel alipayIserviceCcmSwSpuSyncModel = null)

商品库-商品信息同步

商品库-商品信息同步

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
            var apiInstance = new AlipayIserviceCcmSwSpuApi(config);

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

            var alipayIserviceCcmSwSpuSyncModel = new AlipayIserviceCcmSwSpuSyncModel(); // AlipayIserviceCcmSwSpuSyncModel |  (optional) 

            try
            {
                // 商品库-商品信息同步
                AlipayIserviceCcmSwSpuSyncResponseModel result = apiInstance.Sync(alipayIserviceCcmSwSpuSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayIserviceCcmSwSpuApi.Sync: " + e.Message );
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
 **alipayIserviceCcmSwSpuSyncModel** | **AlipayIserviceCcmSwSpuSyncModel**|  | [optional] 

### Return type

**AlipayIserviceCcmSwSpuSyncResponseModel**

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

