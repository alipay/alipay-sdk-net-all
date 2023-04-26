# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniAppdeployByappversionApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniAppdeployByappversionApi.md#query) | **GET** /v3/alipay/open/mini/appdeploy/byappversion/query | 通过版本查询小程序发布


<a name="query"></a>
# **Query**
> AlipayOpenMiniAppdeployByappversionQueryResponseModel Query (string miniAppId = null, string bundleId = null, string instCode = null, string appVersion = null)

通过版本查询小程序发布

伙伴平台使用，用于向开发者展示小程序发布信息

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
            var apiInstance = new AlipayOpenMiniAppdeployByappversionApi(config);

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

            var miniAppId = 2011XXXXXXX;  // string | 小程序ID (optional) 
            var bundleId = com.amap.app;  // string | 端标识 (optional) 
            var instCode = alipay;  // string | 租户 (optional) 
            var appVersion = 0.0.1;  // string | 小程序版本 (optional) 

            try
            {
                // 通过版本查询小程序发布
                AlipayOpenMiniAppdeployByappversionQueryResponseModel result = apiInstance.Query(miniAppId, bundleId, instCode, appVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniAppdeployByappversionApi.Query: " + e.Message );
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
 **miniAppId** | **string**| 小程序ID | [optional] 
 **bundleId** | **string**| 端标识 | [optional] 
 **instCode** | **string**| 租户 | [optional] 
 **appVersion** | **string**| 小程序版本 | [optional] 

### Return type

**AlipayOpenMiniAppdeployByappversionQueryResponseModel**

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

