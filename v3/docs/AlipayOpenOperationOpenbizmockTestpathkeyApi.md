# AlipaySDKNet.OpenAPI.Api.AlipayOpenOperationOpenbizmockTestpathkeyApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenOperationOpenbizmockTestpathkeyApi.md#query) | **POST** /v3/alipay/open/operation/openbizmock/testpathkey/query/{keykey}/{a} | 测试网关协议3.0key和path


<a name="query"></a>
# **Query**
> AlipayOpenOperationOpenbizmockTestpathkeyQueryResponseModel Query (string keykey, string a, string b = null, string c = null, AlipayOpenOperationOpenbizmockTestpathkeyQueryModel data = null, System.IO.Stream f = null)

测试网关协议3.0key和path

测试网关协议3.0key和path

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
            var apiInstance = new AlipayOpenOperationOpenbizmockTestpathkeyApi(config);

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

            var keykey = keykey;  // string | ceshi
            var a = a;  // string | 测试
            var b = b;  // string | ceshi (optional) 
            var c = c;  // string | 测试 (optional) 
            var data = new AlipayOpenOperationOpenbizmockTestpathkeyQueryModel(); // AlipayOpenOperationOpenbizmockTestpathkeyQueryModel |  (optional) 
            var f = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 测试网关协议3.0key和path
                AlipayOpenOperationOpenbizmockTestpathkeyQueryResponseModel result = apiInstance.Query(keykey, a, b, c, data, f);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenOperationOpenbizmockTestpathkeyApi.Query: " + e.Message );
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
 **keykey** | **string**| ceshi | 
 **a** | **string**| 测试 | 
 **b** | **string**| ceshi | [optional] 
 **c** | **string**| 测试 | [optional] 
 **data** | **AlipayOpenOperationOpenbizmockTestpathkeyQueryModel**|  | [optional] 
 **f** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

**AlipayOpenOperationOpenbizmockTestpathkeyQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

