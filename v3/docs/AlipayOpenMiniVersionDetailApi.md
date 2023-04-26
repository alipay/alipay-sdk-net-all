# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniVersionDetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniVersionDetailApi.md#query) | **GET** /v3/alipay/open/mini/version/detail/query | 小程序版本详情查询


<a name="query"></a>
# **Query**
> AlipayOpenMiniVersionDetailQueryResponseModel Query (string appVersion = null, string bundleId = null)

小程序版本详情查询

小程序版本详情查询

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
            var apiInstance = new AlipayOpenMiniVersionDetailApi(config);

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

            var appVersion = 0.0.1;  // string | 小程序版本号 (optional) 
            var bundleId = com.alipay.alipaywallet;  // string | 小程序投放的端参数，支持： com.alipay.iot.xpaas（IoT端）。 com.alipay.alipaywallet（支付宝钱包端）。 例如投放到支付宝钱包是支付宝端。该参数可选，默认支付宝端。 (optional) 

            try
            {
                // 小程序版本详情查询
                AlipayOpenMiniVersionDetailQueryResponseModel result = apiInstance.Query(appVersion, bundleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniVersionDetailApi.Query: " + e.Message );
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
 **appVersion** | **string**| 小程序版本号 | [optional] 
 **bundleId** | **string**| 小程序投放的端参数，支持： com.alipay.iot.xpaas（IoT端）。 com.alipay.alipaywallet（支付宝钱包端）。 例如投放到支付宝钱包是支付宝端。该参数可选，默认支付宝端。 | [optional] 

### Return type

**AlipayOpenMiniVersionDetailQueryResponseModel**

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

