# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniVersionBuildApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniVersionBuildApi.md#query) | **GET** /v3/alipay/open/mini/version/build/query | 小程序查询版本构建状态


<a name="query"></a>
# **Query**
> AlipayOpenMiniVersionBuildQueryResponseModel Query (string appVersion = null, string bundleId = null)

小程序查询版本构建状态

小程序查询版本构建状态

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
            var apiInstance = new AlipayOpenMiniVersionBuildApi(config);

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
            var bundleId = com.alipay.alipaywallet;  // string | 小程序投放的端参数，默认为支付宝端。支持：  com.alipay.alipaywallet：支付宝端。 com.alipay.iot.xpaas：IOT端。 例如：投放到支付宝钱包为支付宝端需传入 com.alipay.alipaywallet。 (optional) 

            try
            {
                // 小程序查询版本构建状态
                AlipayOpenMiniVersionBuildQueryResponseModel result = apiInstance.Query(appVersion, bundleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniVersionBuildApi.Query: " + e.Message );
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
 **bundleId** | **string**| 小程序投放的端参数，默认为支付宝端。支持：  com.alipay.alipaywallet：支付宝端。 com.alipay.iot.xpaas：IOT端。 例如：投放到支付宝钱包为支付宝端需传入 com.alipay.alipaywallet。 | [optional] 

### Return type

**AlipayOpenMiniVersionBuildQueryResponseModel**

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

