# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEnterpriseconsumeRelatedetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceEnterpriseconsumeRelatedetailApi.md#query) | **GET** /v3/alipay/ebpp/invoice/enterpriseconsume/relatedetail/query | 合花账单关联详情查询


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponseModel Query (string accountId = null, string agreementNo = null, string voucherId = null)

合花账单关联详情查询

合花账单关联详情查询，通过凭证ID获取这个账单详细信息和关联的凭证详细信息

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseconsumeRelatedetailApi(config);

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

            var accountId = 2088123456789000;  // string | 企业ID (optional) 
            var agreementNo = 20205820659822371223;  // string | 授权签约协议号 (optional) 
            var voucherId = 2020123100152601930000003650;  // string | 账单凭证ID (optional) 

            try
            {
                // 合花账单关联详情查询
                AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponseModel result = apiInstance.Query(accountId, agreementNo, voucherId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseconsumeRelatedetailApi.Query: " + e.Message );
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
 **accountId** | **string**| 企业ID | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **voucherId** | **string**| 账单凭证ID | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponseModel**

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

