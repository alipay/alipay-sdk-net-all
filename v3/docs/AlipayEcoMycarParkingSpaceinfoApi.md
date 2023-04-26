# AlipaySDKNet.OpenAPI.Api.AlipayEcoMycarParkingSpaceinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayEcoMycarParkingSpaceinfoApi.md#sync) | **POST** /v3/alipay/eco/mycar/parking/spaceinfo/sync | 停车场车位信息同步


<a name="sync"></a>
# **Sync**
> AlipayEcoMycarParkingSpaceinfoSyncResponseModel Sync (AlipayEcoMycarParkingSpaceinfoSyncModel alipayEcoMycarParkingSpaceinfoSyncModel = null)

停车场车位信息同步

停车场位置信息同步

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
            var apiInstance = new AlipayEcoMycarParkingSpaceinfoApi(config);

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

            var alipayEcoMycarParkingSpaceinfoSyncModel = new AlipayEcoMycarParkingSpaceinfoSyncModel(); // AlipayEcoMycarParkingSpaceinfoSyncModel |  (optional) 

            try
            {
                // 停车场车位信息同步
                AlipayEcoMycarParkingSpaceinfoSyncResponseModel result = apiInstance.Sync(alipayEcoMycarParkingSpaceinfoSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingSpaceinfoApi.Sync: " + e.Message );
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
 **alipayEcoMycarParkingSpaceinfoSyncModel** | **AlipayEcoMycarParkingSpaceinfoSyncModel**|  | [optional] 

### Return type

**AlipayEcoMycarParkingSpaceinfoSyncResponseModel**

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

