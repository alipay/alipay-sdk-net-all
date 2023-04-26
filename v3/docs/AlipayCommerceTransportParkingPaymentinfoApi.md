# AlipaySDKNet.OpenAPI.Api.AlipayCommerceTransportParkingPaymentinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayCommerceTransportParkingPaymentinfoApi.md#sync) | **POST** /v3/alipay/commerce/transport/parking/paymentinfo/sync | 停车支付模板消息配置


<a name="sync"></a>
# **Sync**
> AlipayCommerceTransportParkingPaymentinfoSyncResponseModel Sync (AlipayCommerceTransportParkingPaymentinfoSyncModel alipayCommerceTransportParkingPaymentinfoSyncModel = null)

停车支付模板消息配置

用户在场内支付时，服务商通过此接口配置消息模板内容告知支付宝发送给用户

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
            var apiInstance = new AlipayCommerceTransportParkingPaymentinfoApi(config);

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

            var alipayCommerceTransportParkingPaymentinfoSyncModel = new AlipayCommerceTransportParkingPaymentinfoSyncModel(); // AlipayCommerceTransportParkingPaymentinfoSyncModel |  (optional) 

            try
            {
                // 停车支付模板消息配置
                AlipayCommerceTransportParkingPaymentinfoSyncResponseModel result = apiInstance.Sync(alipayCommerceTransportParkingPaymentinfoSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceTransportParkingPaymentinfoApi.Sync: " + e.Message );
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
 **alipayCommerceTransportParkingPaymentinfoSyncModel** | **AlipayCommerceTransportParkingPaymentinfoSyncModel**|  | [optional] 

### Return type

**AlipayCommerceTransportParkingPaymentinfoSyncResponseModel**

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

