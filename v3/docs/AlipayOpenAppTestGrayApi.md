# AlipaySDKNet.OpenAPI.Api.AlipayOpenAppTestGrayApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayOpenAppTestGrayApi.md#create) | **POST** /v3/alipay/open/app/test/gray/create | openapi-oas3.0灰度
[**Query**](AlipayOpenAppTestGrayApi.md#query) | **GET** /v3/alipay/open/app/test/gray/query | GET方法测试


<a name="create"></a>
# **Create**
> AlipayOpenAppTestGrayCreateResponseModel Create (string a = null, string oid = null, string b = null, string c = null, AlipayOpenAppTestGrayCreateModel alipayOpenAppTestGrayCreateModel = null)

openapi-oas3.0灰度

openapi，oas3.0灰度

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAppTestGrayApi(config);

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

            var a = a1;  // string | a (optional) 
            var oid = 111;  // string | 1 (optional) 
            var b = b2;  // string | 生 (optional) 
            var c = c1;  // string | c1 (optional) 
            var alipayOpenAppTestGrayCreateModel = new AlipayOpenAppTestGrayCreateModel(); // AlipayOpenAppTestGrayCreateModel |  (optional) 

            try
            {
                // openapi-oas3.0灰度
                AlipayOpenAppTestGrayCreateResponseModel result = apiInstance.Create(a, oid, b, c, alipayOpenAppTestGrayCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAppTestGrayApi.Create: " + e.Message );
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
 **a** | **string**| a | [optional] 
 **oid** | **string**| 1 | [optional] 
 **b** | **string**| 生 | [optional] 
 **c** | **string**| c1 | [optional] 
 **alipayOpenAppTestGrayCreateModel** | **AlipayOpenAppTestGrayCreateModel**|  | [optional] 

### Return type

**AlipayOpenAppTestGrayCreateResponseModel**

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

<a name="query"></a>
# **Query**
> AlipayOpenAppTestGrayQueryResponseModel Query (string latitude = null, string cityId = null, string uid = null, string buyOpenId = null)

GET方法测试

oas get

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
            var apiInstance = new AlipayOpenAppTestGrayApi(config);

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

            var latitude = 123;  // string | 纬度 (optional) 
            var cityId = 1;  // string | 1 (optional) 
            var uid = 1;  // string | 1 (optional) 
            var buyOpenId = 1;  // string | 1 (optional) 

            try
            {
                // GET方法测试
                AlipayOpenAppTestGrayQueryResponseModel result = apiInstance.Query(latitude, cityId, uid, buyOpenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAppTestGrayApi.Query: " + e.Message );
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
 **latitude** | **string**| 纬度 | [optional] 
 **cityId** | **string**| 1 | [optional] 
 **uid** | **string**| 1 | [optional] 
 **buyOpenId** | **string**| 1 | [optional] 

### Return type

**AlipayOpenAppTestGrayQueryResponseModel**

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

