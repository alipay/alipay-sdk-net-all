# AlipaySDKNet.OpenAPI.Api.AlipaySecurityProdTianwutestApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipaySecurityProdTianwutestApi.md#modify) | **POST** /v3/alipay/security/prod/tianwutest/modify | tianwutest


<a name="modify"></a>
# **Modify**
> AlipaySecurityProdTianwutestModifyResponseModel Modify (AlipaySecurityProdTianwutestModifyModel alipaySecurityProdTianwutestModifyModel = null)

tianwutest

tianwutest

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
    public class ModifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipaySecurityProdTianwutestApi(config);

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

            var alipaySecurityProdTianwutestModifyModel = new AlipaySecurityProdTianwutestModifyModel(); // AlipaySecurityProdTianwutestModifyModel |  (optional) 

            try
            {
                // tianwutest
                AlipaySecurityProdTianwutestModifyResponseModel result = apiInstance.Modify(alipaySecurityProdTianwutestModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipaySecurityProdTianwutestApi.Modify: " + e.Message );
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
 **alipaySecurityProdTianwutestModifyModel** | **AlipaySecurityProdTianwutestModifyModel**|  | [optional] 

### Return type

**AlipaySecurityProdTianwutestModifyResponseModel**

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

