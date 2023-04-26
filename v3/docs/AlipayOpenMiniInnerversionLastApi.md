# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionLastApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniInnerversionLastApi.md#query) | **GET** /v3/alipay/open/mini/innerversion/last/query | 内部链路查询最新版本号


<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerversionLastQueryResponseModel Query (string miniAppId = null, string bundleId = null, string appOrigin = null, string pid = null)

内部链路查询最新版本号

针对一二方场景的开发者，小程序提供一套统一的内部能力体系，定向输出赋能，本接口主要用于查询最新版本号 

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
            var apiInstance = new AlipayOpenMiniInnerversionLastApi(config);

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

            var miniAppId = 2018********;  // string | 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。 (optional) 
            var bundleId = com.alipay.alipaywallet;  // string | 端信息 (optional) 
            var appOrigin = AAA;  // string | 业务来源场景 (optional) 
            var pid = 2088*******;  // string | 小程序主体 (optional) 

            try
            {
                // 内部链路查询最新版本号
                AlipayOpenMiniInnerversionLastQueryResponseModel result = apiInstance.Query(miniAppId, bundleId, appOrigin, pid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionLastApi.Query: " + e.Message );
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
 **miniAppId** | **string**| 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。 | [optional] 
 **bundleId** | **string**| 端信息 | [optional] 
 **appOrigin** | **string**| 业务来源场景 | [optional] 
 **pid** | **string**| 小程序主体 | [optional] 

### Return type

**AlipayOpenMiniInnerversionLastQueryResponseModel**

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

