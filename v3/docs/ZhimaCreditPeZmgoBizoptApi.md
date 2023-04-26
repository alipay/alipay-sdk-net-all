# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPeZmgoBizoptApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Close**](ZhimaCreditPeZmgoBizoptApi.md#close) | **POST** /v3/zhima/credit/pe/zmgo/bizopt/close | 芝麻GO签约关单


<a name="close"></a>
# **Close**
> ZhimaCreditPeZmgoBizoptCloseResponseModel Close (ZhimaCreditPeZmgoBizoptCloseModel zhimaCreditPeZmgoBizoptCloseModel = null)

芝麻GO签约关单

签约芝麻GO时，在签约申请时会生初始状态的签约单，如果后续不进行签约确认，可通过此接口关闭签约单

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
    public class CloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaCreditPeZmgoBizoptApi(config);

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

            var zhimaCreditPeZmgoBizoptCloseModel = new ZhimaCreditPeZmgoBizoptCloseModel(); // ZhimaCreditPeZmgoBizoptCloseModel |  (optional) 

            try
            {
                // 芝麻GO签约关单
                ZhimaCreditPeZmgoBizoptCloseResponseModel result = apiInstance.Close(zhimaCreditPeZmgoBizoptCloseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoBizoptApi.Close: " + e.Message );
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
 **zhimaCreditPeZmgoBizoptCloseModel** | **ZhimaCreditPeZmgoBizoptCloseModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoBizoptCloseResponseModel**

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

