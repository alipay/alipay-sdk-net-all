# AlipaySDKNet.OpenAPI.Api.AlipaySocialBaseContentlibStandardcontentApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipaySocialBaseContentlibStandardcontentApi.md#batchquery) | **POST** /v3/alipay/social/base/contentlib/standardcontent/batchquery | 内容批量查询接口


<a name="batchquery"></a>
# **Batchquery**
> AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel Batchquery (AlipaySocialBaseContentlibStandardcontentBatchqueryModel alipaySocialBaseContentlibStandardcontentBatchqueryModel = null)

内容批量查询接口

支付宝生活号+查询当前账号下发布过的内容及对应详情信息

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
            var apiInstance = new AlipaySocialBaseContentlibStandardcontentApi(config);

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

            var alipaySocialBaseContentlibStandardcontentBatchqueryModel = new AlipaySocialBaseContentlibStandardcontentBatchqueryModel(); // AlipaySocialBaseContentlibStandardcontentBatchqueryModel |  (optional) 

            try
            {
                // 内容批量查询接口
                AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel result = apiInstance.Batchquery(alipaySocialBaseContentlibStandardcontentBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipaySocialBaseContentlibStandardcontentApi.Batchquery: " + e.Message );
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
 **alipaySocialBaseContentlibStandardcontentBatchqueryModel** | **AlipaySocialBaseContentlibStandardcontentBatchqueryModel**|  | [optional] 

### Return type

**AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel**

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

