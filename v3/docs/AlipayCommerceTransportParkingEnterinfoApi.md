# AlipaySDKNet.OpenAPI.Api.AlipayCommerceTransportParkingEnterinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayCommerceTransportParkingEnterinfoApi.md#sync) | **POST** /v3/alipay/commerce/transport/parking/enterinfo/sync | 停车入场模板消息配置


<a name="sync"></a>
# **Sync**
> AlipayCommerceTransportParkingEnterinfoSyncResponseModel Sync (AlipayCommerceTransportParkingEnterinfoSyncModel alipayCommerceTransportParkingEnterinfoSyncModel = null)

停车入场模板消息配置

车辆驶入停车场时，服务商通过此接口配置消息模板内容告知支付宝发送给用户

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
            var apiInstance = new AlipayCommerceTransportParkingEnterinfoApi(config);

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

            var alipayCommerceTransportParkingEnterinfoSyncModel = new AlipayCommerceTransportParkingEnterinfoSyncModel(); // AlipayCommerceTransportParkingEnterinfoSyncModel |  (optional) 

            try
            {
                // 停车入场模板消息配置
                AlipayCommerceTransportParkingEnterinfoSyncResponseModel result = apiInstance.Sync(alipayCommerceTransportParkingEnterinfoSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceTransportParkingEnterinfoApi.Sync: " + e.Message );
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
 **alipayCommerceTransportParkingEnterinfoSyncModel** | **AlipayCommerceTransportParkingEnterinfoSyncModel**|  | [optional] 

### Return type

**AlipayCommerceTransportParkingEnterinfoSyncResponseModel**

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

