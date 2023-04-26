# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerbaseinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniInnerbaseinfoApi.md#query) | **GET** /v3/alipay/open/mini/innerbaseinfo/query | 内部小程序-应用信息查询


<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerbaseinfoQueryResponseModel Query (string miniAppId = null, string instCode = null, string miniAppName = null, string appSubType = null)

内部小程序-应用信息查询

查询小程序应用信息

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
            var apiInstance = new AlipayOpenMiniInnerbaseinfoApi(config);

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

            var miniAppId = 2014060600164699;  // string | 小程序ID，mini_app_id 和 mini_app_name 两个需要有其中一个必填，当填了mini_app_id时只使用id去进行查询。 (optional) 
            var instCode = taobao;  // string | 租户code，alipay or taobao (optional) 
            var miniAppName = test;  // string | 小程序name，mini_app_id 和 mini_app_name 两个需要有其中一个必填，当填了mini_app_id时只使用id去进行查询。 (optional) 
            var appSubType = TINYAPP_TEMPLATE;  // string | 小程序类型，TINYAPP_TEMPLATE，TINYAPP_NORMAL，TINYAPP_PLUGIN，使用mini_app_name查询的时候，该字段要求必传。 (optional) 

            try
            {
                // 内部小程序-应用信息查询
                AlipayOpenMiniInnerbaseinfoQueryResponseModel result = apiInstance.Query(miniAppId, instCode, miniAppName, appSubType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerbaseinfoApi.Query: " + e.Message );
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
 **miniAppId** | **string**| 小程序ID，mini_app_id 和 mini_app_name 两个需要有其中一个必填，当填了mini_app_id时只使用id去进行查询。 | [optional] 
 **instCode** | **string**| 租户code，alipay or taobao | [optional] 
 **miniAppName** | **string**| 小程序name，mini_app_id 和 mini_app_name 两个需要有其中一个必填，当填了mini_app_id时只使用id去进行查询。 | [optional] 
 **appSubType** | **string**| 小程序类型，TINYAPP_TEMPLATE，TINYAPP_NORMAL，TINYAPP_PLUGIN，使用mini_app_name查询的时候，该字段要求必传。 | [optional] 

### Return type

**AlipayOpenMiniInnerbaseinfoQueryResponseModel**

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

