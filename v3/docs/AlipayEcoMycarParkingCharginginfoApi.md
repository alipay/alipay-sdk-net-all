# AlipaySDKNet.OpenAPI.Api.AlipayEcoMycarParkingCharginginfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](AlipayEcoMycarParkingCharginginfoApi.md#sync) | **POST** /v3/alipay/eco/mycar/parking/charginginfo/sync | 车辆停车计费接口


<a name="sync"></a>
# **Sync**
> Object Sync (AlipayEcoMycarParkingCharginginfoSyncModel alipayEcoMycarParkingCharginginfoSyncModel = null)

车辆停车计费接口

上传车辆在停车场的计费信息，将停车动作推进到计费状态，上传信息通过该接口提交到支付宝，支付宝返回对应的信息

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
            var apiInstance = new AlipayEcoMycarParkingCharginginfoApi(config);

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

            var alipayEcoMycarParkingCharginginfoSyncModel = new AlipayEcoMycarParkingCharginginfoSyncModel(); // AlipayEcoMycarParkingCharginginfoSyncModel |  (optional) 

            try
            {
                // 车辆停车计费接口
                Object result = apiInstance.Sync(alipayEcoMycarParkingCharginginfoSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingCharginginfoApi.Sync: " + e.Message );
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
 **alipayEcoMycarParkingCharginginfoSyncModel** | **AlipayEcoMycarParkingCharginginfoSyncModel**|  | [optional] 

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

