# AlipaySDKNet.OpenAPI.Api.AlipayUserAgreementPermissionApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayUserAgreementPermissionApi.md#create) | **POST** /v3/alipay/user/agreement/permission/create | 支付宝协议支付许可创建、服务变更接口


<a name="create"></a>
# **Create**
> AlipayUserAgreementPermissionCreateResponseModel Create (AlipayUserAgreementPermissionCreateModel alipayUserAgreementPermissionCreateModel = null)

支付宝协议支付许可创建、服务变更接口

支付宝协议支付许可创建接口、服务变更发送消息提醒接口

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
            var apiInstance = new AlipayUserAgreementPermissionApi(config);

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

            var alipayUserAgreementPermissionCreateModel = new AlipayUserAgreementPermissionCreateModel(); // AlipayUserAgreementPermissionCreateModel |  (optional) 

            try
            {
                // 支付宝协议支付许可创建、服务变更接口
                AlipayUserAgreementPermissionCreateResponseModel result = apiInstance.Create(alipayUserAgreementPermissionCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserAgreementPermissionApi.Create: " + e.Message );
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
 **alipayUserAgreementPermissionCreateModel** | **AlipayUserAgreementPermissionCreateModel**|  | [optional] 

### Return type

**AlipayUserAgreementPermissionCreateResponseModel**

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

