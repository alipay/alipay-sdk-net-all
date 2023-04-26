# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPeZmgoCumulationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sync**](ZhimaCreditPeZmgoCumulationApi.md#sync) | **POST** /v3/zhima/credit/pe/zmgo/cumulation/sync | 芝麻go用户数据回传


<a name="sync"></a>
# **Sync**
> ZhimaCreditPeZmgoCumulationSyncResponseModel Sync (ZhimaCreditPeZmgoCumulationSyncModel zhimaCreditPeZmgoCumulationSyncModel = null)

芝麻go用户数据回传

芝麻go商户通过此api接口，将用户行为数据回传到芝麻侧，数据包括：交易型数据（订单信息、优惠信息）和非交易型数据（用户完成任务次数）。芝麻侧将回传的数据在C端向用户展示，并且在结算时对结算金额进行校验（可选）。

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
            var apiInstance = new ZhimaCreditPeZmgoCumulationApi(config);

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

            var zhimaCreditPeZmgoCumulationSyncModel = new ZhimaCreditPeZmgoCumulationSyncModel(); // ZhimaCreditPeZmgoCumulationSyncModel |  (optional) 

            try
            {
                // 芝麻go用户数据回传
                ZhimaCreditPeZmgoCumulationSyncResponseModel result = apiInstance.Sync(zhimaCreditPeZmgoCumulationSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoCumulationApi.Sync: " + e.Message );
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
 **zhimaCreditPeZmgoCumulationSyncModel** | **ZhimaCreditPeZmgoCumulationSyncModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoCumulationSyncResponseModel**

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

