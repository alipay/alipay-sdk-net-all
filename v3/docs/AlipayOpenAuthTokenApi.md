# AlipaySDKNet.OpenAPI.Api.AlipayOpenAuthTokenApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**App**](AlipayOpenAuthTokenApi.md#app) | **POST** /v3/alipay/open/auth/token/app | 换取应用授权令牌


<a name="app"></a>
# **App**
> AlipayOpenAuthTokenAppResponseModel App (AlipayOpenAuthTokenAppModel alipayOpenAuthTokenAppModel = null)

换取应用授权令牌

换取应用授权令牌。在应用授权的场景下，商户把名下应用授权给ISV后，支付宝会给ISV颁发应用授权码app_auth_code，ISV可通过获取到的app_auth_code换取app_auth_token。app_auth_code作为换取app_auth_token的票据，每次用户授权带上的app_auth_code将不一样，app_auth_code只能使用一次，一天（从当前时间算起的24小时）未被使用自动过期。  刷新应用授权令牌，ISV可通过获取到的refresh_token刷新app_auth_token，刷新后老的refresh_token会在一段时间后失效（失效时间为接口返回的re_expires_in）。

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
    public class AppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAuthTokenApi(config);

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

            var alipayOpenAuthTokenAppModel = new AlipayOpenAuthTokenAppModel(); // AlipayOpenAuthTokenAppModel |  (optional) 

            try
            {
                // 换取应用授权令牌
                AlipayOpenAuthTokenAppResponseModel result = apiInstance.App(alipayOpenAuthTokenAppModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAuthTokenApi.App: " + e.Message );
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
 **alipayOpenAuthTokenAppModel** | **AlipayOpenAuthTokenAppModel**|  | [optional] 

### Return type

**AlipayOpenAuthTokenAppResponseModel**

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

