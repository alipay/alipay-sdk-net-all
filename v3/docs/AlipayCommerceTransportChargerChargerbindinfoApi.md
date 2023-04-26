# AlipaySDKNet.OpenAPI.Api.AlipayCommerceTransportChargerChargerbindinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayCommerceTransportChargerChargerbindinfoApi.md#sync) | **POST** /v3/alipay/commerce/transport/charger/chargerbindinfo/sync | 充电运营商同步用户绑定充电桩信息接口


<a name="sync"></a>
# **Sync**
> AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel Sync (string authToken = null, AlipayCommerceTransportChargerChargerbindinfoSyncModel alipayCommerceTransportChargerChargerbindinfoSyncModel = null)

充电运营商同步用户绑定充电桩信息接口

设备运营商通过该接口同步自己阵地中用户绑定充电桩的信息，包含绑定信息，解绑信息，设备状态等等设备信息

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
            var apiInstance = new AlipayCommerceTransportChargerChargerbindinfoApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var alipayCommerceTransportChargerChargerbindinfoSyncModel = new AlipayCommerceTransportChargerChargerbindinfoSyncModel(); // AlipayCommerceTransportChargerChargerbindinfoSyncModel |  (optional) 

            try
            {
                // 充电运营商同步用户绑定充电桩信息接口
                AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel result = apiInstance.Sync(authToken, alipayCommerceTransportChargerChargerbindinfoSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceTransportChargerChargerbindinfoApi.Sync: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **alipayCommerceTransportChargerChargerbindinfoSyncModel** | **AlipayCommerceTransportChargerChargerbindinfoSyncModel**|  | [optional] 

### Return type

**AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel**

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

