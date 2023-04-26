# AlipaySDKNet.OpenAPI.Api.AlipayOfflineMarketShopCategoryApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOfflineMarketShopCategoryApi.md#query) | **GET** /v3/alipay/offline/market/shop/category/query | 门店类目配置查询接口


<a name="query"></a>
# **Query**
> AlipayOfflineMarketShopCategoryQueryResponseModel Query (string categoryId = null, string opRole = null)

门店类目配置查询接口

用于查询可用于开店的类目，以及类目上的配置约束信息

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
            var apiInstance = new AlipayOfflineMarketShopCategoryApi(config);

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

            var categoryId = 2015050700000000;  // string | 类目ID，如果为空则查询全部类目。 (optional) 
            var opRole = ISV;  // string | 表示接口业务的调用方身份,默认不填标识为ISV。 (optional) 

            try
            {
                // 门店类目配置查询接口
                AlipayOfflineMarketShopCategoryQueryResponseModel result = apiInstance.Query(categoryId, opRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOfflineMarketShopCategoryApi.Query: " + e.Message );
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
 **categoryId** | **string**| 类目ID，如果为空则查询全部类目。 | [optional] 
 **opRole** | **string**| 表示接口业务的调用方身份,默认不填标识为ISV。 | [optional] 

### Return type

**AlipayOfflineMarketShopCategoryQueryResponseModel**

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

