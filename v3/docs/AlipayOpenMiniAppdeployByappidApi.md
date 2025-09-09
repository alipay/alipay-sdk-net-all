# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniAppdeployByappidApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniAppdeployByappidApi.md#query) | **GET** /v3/alipay/open/mini/appdeploy/byappid/query | 根据APPID分页查询小程序发布信息


<a name="query"></a>
# **Query**
> AlipayOpenMiniAppdeployByappidQueryResponseModel Query (string miniAppId = null, string bundleId = null, string instCode = null, int? pageNum = null, int? pageSize = null)

根据APPID分页查询小程序发布信息

用于伙伴平台面向开发者提供查询小程序发布能力

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
            var apiInstance = new AlipayOpenMiniAppdeployByappidApi(config);

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

            var miniAppId = 2018XXXXXX;  // string | 小程序应用ID (optional) 
            var bundleId = com.amap.app;  // string | 端标识 (optional) 
            var instCode = alipay;  // string | 租户标识 (optional) 
            var pageNum = 1;  // int? | 当前页，从1开始 (optional) 
            var pageSize = 20;  // int? | 每页个数 (optional) 

            try
            {
                // 根据APPID分页查询小程序发布信息
                AlipayOpenMiniAppdeployByappidQueryResponseModel result = apiInstance.Query(miniAppId, bundleId, instCode, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniAppdeployByappidApi.Query: " + e.Message );
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
 **miniAppId** | **string**| 小程序应用ID | [optional] 
 **bundleId** | **string**| 端标识 | [optional] 
 **instCode** | **string**| 租户标识 | [optional] 
 **pageNum** | **int?**| 当前页，从1开始 | [optional] 
 **pageSize** | **int?**| 每页个数 | [optional] 

### Return type

**AlipayOpenMiniAppdeployByappidQueryResponseModel**

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

