# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailApi.md#query) | **GET** /v3/alipay/ebpp/invoice/enterpriseconsume/summaryinvoicedetail/query | 查询汇总发票详情


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryResponseModel Query (string accountId = null, string agreementNo = null, string summaryId = null)

查询汇总发票详情

根据汇总开票通知拿到的开票批次ID查询汇总发票详情

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailApi(config);

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

            var accountId = 2088000237836238;  // string | 企业 ID (optional) 
            var agreementNo = 20205820659822371223;  // string | 授权签约协议号 (optional) 
            var summaryId = 2021080400152500230000000881;  // string | 开票批次 ID (optional) 

            try
            {
                // 查询汇总发票详情
                AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryResponseModel result = apiInstance.Query(accountId, agreementNo, summaryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailApi.Query: " + e.Message );
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
 **accountId** | **string**| 企业 ID | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **summaryId** | **string**| 开票批次 ID | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseconsumeSummaryinvoicedetailQueryResponseModel**

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

