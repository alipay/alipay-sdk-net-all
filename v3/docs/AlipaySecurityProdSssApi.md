# AlipaySDKNet.OpenAPI.Api.AlipaySecurityProdSssApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipaySecurityProdSssApi.md#query) | **POST** /v3/alipay/security/prod/sss/query/{bbb} | 金柚测试3.0接口


<a name="query"></a>
# **Query**
> AlipaySecurityProdSssQueryResponseModel Query (string bbb, string aaa = null, string aaaOpenId = null, AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = null)

金柚测试3.0接口

金柚测试3.0接口

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
            var apiInstance = new AlipaySecurityProdSssApi(config);

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

            var bbb = 1;  // string | activity_id 词条描述
            var aaa = 3333;  // string | 1 (optional) 
            var aaaOpenId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 1 (optional) 
            var alipaySecurityProdSssQueryModel = new AlipaySecurityProdSssQueryModel(); // AlipaySecurityProdSssQueryModel |  (optional) 

            try
            {
                // 金柚测试3.0接口
                AlipaySecurityProdSssQueryResponseModel result = apiInstance.Query(bbb, aaa, aaaOpenId, alipaySecurityProdSssQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipaySecurityProdSssApi.Query: " + e.Message );
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
 **bbb** | **string**| activity_id 词条描述 | 
 **aaa** | **string**| 1 | [optional] 
 **aaaOpenId** | **string**| 1 | [optional] 
 **alipaySecurityProdSssQueryModel** | **AlipaySecurityProdSssQueryModel**|  | [optional] 

### Return type

**AlipaySecurityProdSssQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

