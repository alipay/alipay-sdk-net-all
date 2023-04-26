# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionInstantiationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniInnerversionInstantiationApi.md#query) | **GET** /v3/alipay/open/mini/innerversion/instantiation/query | 小程序实例化关系查询


<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerversionInstantiationQueryResponseModel Query (string appOrigin = null, string bundleId = null, string miniAppId = null, string appVersion = null)

小程序实例化关系查询

用于通过模板实例化的小程序版本查询实例化关系

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
            var apiInstance = new AlipayOpenMiniInnerversionInstantiationApi(config);

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

            var appOrigin = AAA;  // string | 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入，申请方式请参见接入手册。 (optional) 
            var bundleId = com.alipay.alipaywallet;  // string | 端id (optional) 
            var miniAppId = 2021000116680014;  // string | 小程序ID，特殊场景专用，普通业务方无需关注该参数。 (optional) 
            var appVersion = 0.0.1;  // string | 实例化小程序版本号 (optional) 

            try
            {
                // 小程序实例化关系查询
                AlipayOpenMiniInnerversionInstantiationQueryResponseModel result = apiInstance.Query(appOrigin, bundleId, miniAppId, appVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionInstantiationApi.Query: " + e.Message );
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
 **appOrigin** | **string**| 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入，申请方式请参见接入手册。 | [optional] 
 **bundleId** | **string**| 端id | [optional] 
 **miniAppId** | **string**| 小程序ID，特殊场景专用，普通业务方无需关注该参数。 | [optional] 
 **appVersion** | **string**| 实例化小程序版本号 | [optional] 

### Return type

**AlipayOpenMiniInnerversionInstantiationQueryResponseModel**

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

