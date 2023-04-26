# AlipaySDKNet.OpenAPI.Api.AlipaySecurityDataSssApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipaySecurityDataSssApi.md#create) | **POST** /v3/alipay/security/data/sss/create/{a} | 文档回归测试勿动openapi_openid_post多场景


<a name="create"></a>
# **Create**
> AlipaySecurityDataSssCreateResponseModel Create (int a, string b = null, string bOpenId = null, AlipaySecurityDataSssCreateModel alipaySecurityDataSssCreateModel = null)

文档回归测试勿动openapi_openid_post多场景

文档回归测试勿动openapi_openid_post多场景

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipaySecurityDataSssApi(config);

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

            var a = 1;  // int | path.数字，无枚举，有注意事项
            var b = 12;  // string | 有枚举，必须，有openid，有注意事项 (optional) 
            var bOpenId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 有枚举，必须，有openid，有注意事项 (optional) 
            var alipaySecurityDataSssCreateModel = new AlipaySecurityDataSssCreateModel(); // AlipaySecurityDataSssCreateModel |  (optional) 

            try
            {
                // 文档回归测试勿动openapi_openid_post多场景
                AlipaySecurityDataSssCreateResponseModel result = apiInstance.Create(a, b, bOpenId, alipaySecurityDataSssCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipaySecurityDataSssApi.Create: " + e.Message );
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
 **a** | **int**| path.数字，无枚举，有注意事项 | 
 **b** | **string**| 有枚举，必须，有openid，有注意事项 | [optional] 
 **bOpenId** | **string**| 有枚举，必须，有openid，有注意事项 | [optional] 
 **alipaySecurityDataSssCreateModel** | **AlipaySecurityDataSssCreateModel**|  | [optional] 

### Return type

**AlipaySecurityDataSssCreateResponseModel**

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

