# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicSinglearticleDataApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenPublicSinglearticleDataApi.md#batchquery) | **POST** /v3/alipay/open/public/singlearticle/data/batchquery | 图文分析-按文章查询数据接口


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenPublicSinglearticleDataBatchqueryResponseModel Batchquery (AlipayOpenPublicSinglearticleDataBatchqueryModel alipayOpenPublicSinglearticleDataBatchqueryModel = null)

图文分析-按文章查询数据接口

开发者可以通过本接口查询最近30天内发布的图文消息的数据，数据包括：发布时间、送达人数、阅读人数、分享人数等。

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
            var apiInstance = new AlipayOpenPublicSinglearticleDataApi(config);

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

            var alipayOpenPublicSinglearticleDataBatchqueryModel = new AlipayOpenPublicSinglearticleDataBatchqueryModel(); // AlipayOpenPublicSinglearticleDataBatchqueryModel |  (optional) 

            try
            {
                // 图文分析-按文章查询数据接口
                AlipayOpenPublicSinglearticleDataBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenPublicSinglearticleDataBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicSinglearticleDataApi.Batchquery: " + e.Message );
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
 **alipayOpenPublicSinglearticleDataBatchqueryModel** | **AlipayOpenPublicSinglearticleDataBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenPublicSinglearticleDataBatchqueryResponseModel**

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

