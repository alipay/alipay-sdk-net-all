# AlipaySDKNet.OpenAPI.Api.AlipayOpenServicemarketPromotiontaskRelationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenServicemarketPromotiontaskRelationApi.md#query) | **GET** /v3/alipay/open/servicemarket/promotiontask/relation/query | 服务商推广关系查询


<a name="query"></a>
# **Query**
> AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel Query (string commodityId = null, int? pageSize = null, int? pageNum = null)

服务商推广关系查询

用于开发服务商查询已与其达成推广关系的地推服务商信息

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
            var apiInstance = new AlipayOpenServicemarketPromotiontaskRelationApi(config);

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

            var commodityId = SS010101000000003954;  // string | 服务商品ID，并不是uid，取值来源于前端的获取 (optional) 
            var pageSize = 10;  // int? | 每页数量，范围(1-100)。默认：10 (optional) 
            var pageNum = 1;  // int? | 当前页码，从1开始。默认：1 (optional) 

            try
            {
                // 服务商推广关系查询
                AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel result = apiInstance.Query(commodityId, pageSize, pageNum);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenServicemarketPromotiontaskRelationApi.Query: " + e.Message );
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
 **commodityId** | **string**| 服务商品ID，并不是uid，取值来源于前端的获取 | [optional] 
 **pageSize** | **int?**| 每页数量，范围(1-100)。默认：10 | [optional] 
 **pageNum** | **int?**| 当前页码，从1开始。默认：1 | [optional] 

### Return type

**AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel**

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

