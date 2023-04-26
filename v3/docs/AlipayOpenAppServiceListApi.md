# AlipaySDKNet.OpenAPI.Api.AlipayOpenAppServiceListApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenAppServiceListApi.md#query) | **GET** /v3/alipay/open/app/service/list/query | 服务批量查询


<a name="query"></a>
# **Query**
> AlipayOpenAppServiceListQueryResponseModel Query (string serviceName = null, string categoryId = null, int? pageSize = null, int? pageNum = null)

服务批量查询

服务批量分页查询

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
            var apiInstance = new AlipayOpenAppServiceListApi(config);

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

            var serviceName = 肯德基;  // string | 服务名称 (optional) 
            var categoryId = C15484611;  // string | 类目 (optional) 
            var pageSize = 10;  // int? | 每页记录数 (optional) 
            var pageNum = 1;  // int? | 页码 (optional) 

            try
            {
                // 服务批量查询
                AlipayOpenAppServiceListQueryResponseModel result = apiInstance.Query(serviceName, categoryId, pageSize, pageNum);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAppServiceListApi.Query: " + e.Message );
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
 **serviceName** | **string**| 服务名称 | [optional] 
 **categoryId** | **string**| 类目 | [optional] 
 **pageSize** | **int?**| 每页记录数 | [optional] 
 **pageNum** | **int?**| 页码 | [optional] 

### Return type

**AlipayOpenAppServiceListQueryResponseModel**

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

