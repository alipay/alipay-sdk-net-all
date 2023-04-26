# AlipaySDKNet.OpenAPI.Api.AlipayOpenAppMessagetemplateSubscribeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenAppMessagetemplateSubscribeApi.md#query) | **POST** /v3/alipay/open/app/messagetemplate/subscribe/query | 模板订阅关系查询


<a name="query"></a>
# **Query**
> AlipayOpenAppMessagetemplateSubscribeQueryResponseModel Query (AlipayOpenAppMessagetemplateSubscribeQueryModel alipayOpenAppMessagetemplateSubscribeQueryModel = null)

模板订阅关系查询

商户使用该接口可以查询用户对其消息模板的订阅关系，可以根据是否订阅引导用户进行订阅和精准触达消息

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
            var apiInstance = new AlipayOpenAppMessagetemplateSubscribeApi(config);

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

            var alipayOpenAppMessagetemplateSubscribeQueryModel = new AlipayOpenAppMessagetemplateSubscribeQueryModel(); // AlipayOpenAppMessagetemplateSubscribeQueryModel |  (optional) 

            try
            {
                // 模板订阅关系查询
                AlipayOpenAppMessagetemplateSubscribeQueryResponseModel result = apiInstance.Query(alipayOpenAppMessagetemplateSubscribeQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAppMessagetemplateSubscribeApi.Query: " + e.Message );
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
 **alipayOpenAppMessagetemplateSubscribeQueryModel** | **AlipayOpenAppMessagetemplateSubscribeQueryModel**|  | [optional] 

### Return type

**AlipayOpenAppMessagetemplateSubscribeQueryResponseModel**

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

