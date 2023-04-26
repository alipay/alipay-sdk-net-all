# AlipaySDKNet.OpenAPI.Api.AlipayOpenAuthTokenAppApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenAuthTokenAppApi.md#query) | **GET** /v3/alipay/open/auth/token/app/query | 查询某个应用授权AppAuthToken的授权信息


<a name="query"></a>
# **Query**
> AlipayOpenAuthTokenAppQueryResponseModel Query (string appAuthToken = null)

查询某个应用授权AppAuthToken的授权信息

当商户把服务窗、店铺等接口的权限授权给ISV之后，支付宝会给ISV颁发一个app_auth_token。如若授权成功之后，ISV想知道用户的授权信息，如授权者、授权接口列表等信息，可以调用本接口查询某个app_auth_token对应的授权信息

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
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAuthTokenAppApi(config);

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

            var appAuthToken = 201509BBeff9351ad1874306903e96b91d248A36;  // string | 应用授权令牌 (optional) 

            try
            {
                // 查询某个应用授权AppAuthToken的授权信息
                AlipayOpenAuthTokenAppQueryResponseModel result = apiInstance.Query(appAuthToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAuthTokenAppApi.Query: " + e.Message );
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
 **appAuthToken** | **string**| 应用授权令牌 | [optional] 

### Return type

**AlipayOpenAuthTokenAppQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

