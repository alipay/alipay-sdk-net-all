# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicArticlesummaryDataApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenPublicArticlesummaryDataApi.md#batchquery) | **POST** /v3/alipay/open/public/articlesummary/data/batchquery | 图文分析-按时间查询数据接口


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenPublicArticlesummaryDataBatchqueryResponseModel Batchquery (AlipayOpenPublicArticlesummaryDataBatchqueryModel alipayOpenPublicArticlesummaryDataBatchqueryModel = null)

图文分析-按时间查询数据接口

开发者可以通过图文分析接口查询30天内，所有历史发布的图文消息的数据，包括送达人数、曝光人数、图文阅读人数、分享人数等信息。

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenPublicArticlesummaryDataApi(config);

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

            var alipayOpenPublicArticlesummaryDataBatchqueryModel = new AlipayOpenPublicArticlesummaryDataBatchqueryModel(); // AlipayOpenPublicArticlesummaryDataBatchqueryModel |  (optional) 

            try
            {
                // 图文分析-按时间查询数据接口
                AlipayOpenPublicArticlesummaryDataBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenPublicArticlesummaryDataBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicArticlesummaryDataApi.Batchquery: " + e.Message );
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
 **alipayOpenPublicArticlesummaryDataBatchqueryModel** | **AlipayOpenPublicArticlesummaryDataBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenPublicArticlesummaryDataBatchqueryResponseModel**

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

