# AlipaySDKNet.OpenAPI.Api.AlipayEcoMycarParkingParkinglotbizApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Transfer**](AlipayEcoMycarParkingParkinglotbizApi.md#transfer) | **POST** /v3/alipay/eco/mycar/parking/parkinglotbiz/transfer | 车场业务归属配置


<a name="transfer"></a>
# **Transfer**
> Object Transfer (AlipayEcoMycarParkingParkinglotbizTransferModel alipayEcoMycarParkingParkinglotbizTransferModel = null)

车场业务归属配置

解决车场多isv接管问题，可以通过归属灵活控制权限。

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
    public class TransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoMycarParkingParkinglotbizApi(config);

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

            var alipayEcoMycarParkingParkinglotbizTransferModel = new AlipayEcoMycarParkingParkinglotbizTransferModel(); // AlipayEcoMycarParkingParkinglotbizTransferModel |  (optional) 

            try
            {
                // 车场业务归属配置
                Object result = apiInstance.Transfer(alipayEcoMycarParkingParkinglotbizTransferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingParkinglotbizApi.Transfer: " + e.Message );
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
 **alipayEcoMycarParkingParkinglotbizTransferModel** | **AlipayEcoMycarParkingParkinglotbizTransferModel**|  | [optional] 

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

