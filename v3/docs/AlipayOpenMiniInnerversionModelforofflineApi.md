# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionModelforofflineApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniInnerversionModelforofflineApi.md#query) | **GET** /v3/alipay/open/mini/innerversion/modelforoffline/query | 小程序线上版本包数据同步线下场景查询


<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerversionModelforofflineQueryResponseModel Query (string miniAppId = null, string appVersion = null, string bundleId = null, string instCode = null)

小程序线上版本包数据同步线下场景查询

用于查询线上的版本包数据，同步到线下

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
            var apiInstance = new AlipayOpenMiniInnerversionModelforofflineApi(config);

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

            var miniAppId = 2018********;  // string | 小程序ID (optional) 
            var appVersion = 0.0.1;  // string | 版本号 (optional) 
            var bundleId = com.alipay.alipaywallet;  // string | com.alipay.alipaywallet:支付包 (optional) 
            var instCode = alipay;  // string | alipay:支付宝 (optional) 

            try
            {
                // 小程序线上版本包数据同步线下场景查询
                AlipayOpenMiniInnerversionModelforofflineQueryResponseModel result = apiInstance.Query(miniAppId, appVersion, bundleId, instCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionModelforofflineApi.Query: " + e.Message );
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
 **appVersion** | **string**| 版本号 | [optional] 
 **bundleId** | **string**| com.alipay.alipaywallet:支付包 | [optional] 
 **instCode** | **string**| alipay:支付宝 | [optional] 

### Return type

**AlipayOpenMiniInnerversionModelforofflineQueryResponseModel**

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

