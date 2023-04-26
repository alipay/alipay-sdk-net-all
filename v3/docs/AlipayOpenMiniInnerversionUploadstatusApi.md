# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionUploadstatusApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniInnerversionUploadstatusApi.md#query) | **GET** /v3/alipay/open/mini/innerversion/uploadstatus/query | 多端小程序-查询构建状态


<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerversionUploadstatusQueryResponseModel Query (string buildPackageId = null, string miniAppId = null, string buildVersion = null, string instCode = null, string bundleId = null)

多端小程序-查询构建状态

查询构建状态

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
            var apiInstance = new AlipayOpenMiniInnerversionUploadstatusApi(config);

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

            var buildPackageId = 34818;  // string | 包管理ID，用于查询打包状态 (optional) 
            var miniAppId = 2018012201365222;  // string | 小程序ID (optional) 
            var buildVersion = 0.0.5;  // string | 小程序版本 (optional) 
            var instCode = taobao;  // string | 租户id (optional) 
            var bundleId = com.taobao.app;  // string | 端信息 (optional) 

            try
            {
                // 多端小程序-查询构建状态
                AlipayOpenMiniInnerversionUploadstatusQueryResponseModel result = apiInstance.Query(buildPackageId, miniAppId, buildVersion, instCode, bundleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionUploadstatusApi.Query: " + e.Message );
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
 **buildPackageId** | **string**| 包管理ID，用于查询打包状态 | [optional] 
 **miniAppId** | **string**| 小程序ID | [optional] 
 **buildVersion** | **string**| 小程序版本 | [optional] 
 **instCode** | **string**| 租户id | [optional] 
 **bundleId** | **string**| 端信息 | [optional] 

### Return type

**AlipayOpenMiniInnerversionUploadstatusQueryResponseModel**

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

