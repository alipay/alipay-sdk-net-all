# AlipaySDKNet.OpenAPI.Api.AlipayOpenAppServiceSchemaApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenAppServiceSchemaApi.md#query) | **GET** /v3/alipay/open/app/service/schema/query | 服务schema下发


<a name="query"></a>
# **Query**
> AlipayOpenAppServiceSchemaQueryResponseModel Query (string categoryId = null, string templateType = null)

服务schema下发

服务schema查询下发

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
            var apiInstance = new AlipayOpenAppServiceSchemaApi(config);

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

            var categoryId = c11111;  // string | 类目id, 获取请参考<a href=\"https://opendocs.alipay.com/mini/03ci0w?pathHash=ed3c875c\">各个行业场景服务接入资料</a> (optional) 
            var templateType = DEFAULT;  // string | 服务模版类型，默认值:DEFAULT (optional) 

            try
            {
                // 服务schema下发
                AlipayOpenAppServiceSchemaQueryResponseModel result = apiInstance.Query(categoryId, templateType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAppServiceSchemaApi.Query: " + e.Message );
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
 **categoryId** | **string**| 类目id, 获取请参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03ci0w?pathHash&#x3D;ed3c875c\&quot;&gt;各个行业场景服务接入资料&lt;/a&gt; | [optional] 
 **templateType** | **string**| 服务模版类型，默认值:DEFAULT | [optional] 

### Return type

**AlipayOpenAppServiceSchemaQueryResponseModel**

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

