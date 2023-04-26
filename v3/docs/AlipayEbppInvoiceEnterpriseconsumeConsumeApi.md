# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEnterpriseconsumeConsumeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayEbppInvoiceEnterpriseconsumeConsumeApi.md#batchquery) | **POST** /v3/alipay/ebpp/invoice/enterpriseconsume/consume/batchquery | 企业因公账单查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel Batchquery (AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel alipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel = null)

企业因公账单查询

基于企业ID和员工UID，在指定时间段（时间间隔不超过24小时）内获取因公账单数据

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseconsumeConsumeApi(config);

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

            var alipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel = new AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel(); // AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel |  (optional) 

            try
            {
                // 企业因公账单查询
                AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel result = apiInstance.Batchquery(alipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseconsumeConsumeApi.Batchquery: " + e.Message );
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
 **alipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel** | **AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel**

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

