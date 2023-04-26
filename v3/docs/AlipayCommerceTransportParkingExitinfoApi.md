# AlipaySDKNet.OpenAPI.Api.AlipayCommerceTransportParkingExitinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayCommerceTransportParkingExitinfoApi.md#sync) | **POST** /v3/alipay/commerce/transport/parking/exitinfo/sync | 停车离场消息模板配置


<a name="sync"></a>
# **Sync**
> AlipayCommerceTransportParkingExitinfoSyncResponseModel Sync (AlipayCommerceTransportParkingExitinfoSyncModel alipayCommerceTransportParkingExitinfoSyncModel = null)

停车离场消息模板配置

用户要驶离停车场时，服务商通过此接口配置消息模板内容告知支付宝发送给用户

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
            var apiInstance = new AlipayCommerceTransportParkingExitinfoApi(config);

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

            var alipayCommerceTransportParkingExitinfoSyncModel = new AlipayCommerceTransportParkingExitinfoSyncModel(); // AlipayCommerceTransportParkingExitinfoSyncModel |  (optional) 

            try
            {
                // 停车离场消息模板配置
                AlipayCommerceTransportParkingExitinfoSyncResponseModel result = apiInstance.Sync(alipayCommerceTransportParkingExitinfoSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceTransportParkingExitinfoApi.Sync: " + e.Message );
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
 **alipayCommerceTransportParkingExitinfoSyncModel** | **AlipayCommerceTransportParkingExitinfoSyncModel**|  | [optional] 

### Return type

**AlipayCommerceTransportParkingExitinfoSyncResponseModel**

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

