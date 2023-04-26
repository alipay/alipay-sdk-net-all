# AlipaySDKNet.OpenAPI.Api.AlipaySecurityRiskVerifyidentityMiniappApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Confirm**](AlipaySecurityRiskVerifyidentityMiniappApi.md#confirm) | **POST** /v3/alipay/security/risk/verifyidentity/miniapp/confirm | 小程序核验服务结果确认接口


<a name="confirm"></a>
# **Confirm**
> AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel Confirm (AlipaySecurityRiskVerifyidentityMiniappConfirmModel alipaySecurityRiskVerifyidentityMiniappConfirmModel = null)

小程序核验服务结果确认接口

确认身份核验结果接口

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
    public class ConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipaySecurityRiskVerifyidentityMiniappApi(config);

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

            var alipaySecurityRiskVerifyidentityMiniappConfirmModel = new AlipaySecurityRiskVerifyidentityMiniappConfirmModel(); // AlipaySecurityRiskVerifyidentityMiniappConfirmModel |  (optional) 

            try
            {
                // 小程序核验服务结果确认接口
                AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel result = apiInstance.Confirm(alipaySecurityRiskVerifyidentityMiniappConfirmModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipaySecurityRiskVerifyidentityMiniappApi.Confirm: " + e.Message );
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
 **alipaySecurityRiskVerifyidentityMiniappConfirmModel** | **AlipaySecurityRiskVerifyidentityMiniappConfirmModel**|  | [optional] 

### Return type

**AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel**

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

