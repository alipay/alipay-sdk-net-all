# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionBetainfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniInnerversionBetainfoApi.md#query) | **GET** /v3/alipay/open/mini/innerversion/betainfo/query | 查看可邀测状态接口


<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerversionBetainfoQueryResponseModel Query (string pluginId = null, string bundleId = null, string pluginVersion = null, string appOrigin = null)

查看可邀测状态接口

查看插件可邀测版本状态,邀测结果

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
            var apiInstance = new AlipayOpenMiniInnerversionBetainfoApi(config);

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

            var pluginId = 2021xxxx;  // string | 插件ID (optional) 
            var bundleId = com.alipay.alipaywallet;  // string | 端信息 (optional) 
            var pluginVersion = 0.0.1;  // string | 查询版本号 (optional) 
            var appOrigin = ASTORE;  // string | 业务来源 (optional) 

            try
            {
                // 查看可邀测状态接口
                AlipayOpenMiniInnerversionBetainfoQueryResponseModel result = apiInstance.Query(pluginId, bundleId, pluginVersion, appOrigin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionBetainfoApi.Query: " + e.Message );
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
 **pluginId** | **string**| 插件ID | [optional] 
 **bundleId** | **string**| 端信息 | [optional] 
 **pluginVersion** | **string**| 查询版本号 | [optional] 
 **appOrigin** | **string**| 业务来源 | [optional] 

### Return type

**AlipayOpenMiniInnerversionBetainfoQueryResponseModel**

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

