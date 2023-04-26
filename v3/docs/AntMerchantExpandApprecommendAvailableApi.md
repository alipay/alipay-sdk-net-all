# AlipaySDKNet.OpenAPI.Api.AntMerchantExpandApprecommendAvailableApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AntMerchantExpandApprecommendAvailableApi.md#query) | **GET** /v3/ant/merchant/expand/apprecommend/available/query | 查询可关联APP的账号列表


<a name="query"></a>
# **Query**
> AntMerchantExpandApprecommendAvailableQueryResponseModel Query (int? pageSize = null, int? pageNumber = null)

查询可关联APP的账号列表

查询可关联APP的账号列表，用于支付推荐场景

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
            var apiInstance = new AntMerchantExpandApprecommendAvailableApi(config);

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

            var pageSize = 10;  // int? | 单页行数，不能超过100行 (optional) 
            var pageNumber = 1;  // int? | 页码 (optional) 

            try
            {
                // 查询可关联APP的账号列表
                AntMerchantExpandApprecommendAvailableQueryResponseModel result = apiInstance.Query(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandApprecommendAvailableApi.Query: " + e.Message );
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
 **pageSize** | **int?**| 单页行数，不能超过100行 | [optional] 
 **pageNumber** | **int?**| 页码 | [optional] 

### Return type

**AntMerchantExpandApprecommendAvailableQueryResponseModel**

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

