# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceTokenApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayEbppInvoiceTokenApi.md#batchquery) | **GET** /v3/alipay/ebpp/invoice/token/batchquery | 根据查询令牌获取发票要素列表


<a name="batchquery"></a>
# **Batchquery**
> AlipayEbppInvoiceTokenBatchqueryResponseModel Batchquery (string invoiceToken = null, string scene = null)

根据查询令牌获取发票要素列表

根据用户通过发票管家选择发票列表产生的请求令牌获取用户选择发票要素列表

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
            var apiInstance = new AlipayEbppInvoiceTokenApi(config);

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

            var invoiceToken = 0136d80096e34a07a528db7cc5bc442888s;  // string | 查询请求令牌。通过唤起支付宝钱包后用户进入发票管家选择发票列表后创建，并通过isv接收url回传给isv。详见 <a href=\"https://opendocs.alipay.com/open/01m6z5\">\"选\"模式发票报销</a>。 (optional) 
            var scene = INVOICE_EXPENSE;  // string | 发票要素获取应用场景。固定为 INVOICE_EXPENSE 表示发票报销。 (optional) 

            try
            {
                // 根据查询令牌获取发票要素列表
                AlipayEbppInvoiceTokenBatchqueryResponseModel result = apiInstance.Batchquery(invoiceToken, scene);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceTokenApi.Batchquery: " + e.Message );
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
 **invoiceToken** | **string**| 查询请求令牌。通过唤起支付宝钱包后用户进入发票管家选择发票列表后创建，并通过isv接收url回传给isv。详见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01m6z5\&quot;&gt;\&quot;选\&quot;模式发票报销&lt;/a&gt;。 | [optional] 
 **scene** | **string**| 发票要素获取应用场景。固定为 INVOICE_EXPENSE 表示发票报销。 | [optional] 

### Return type

**AlipayEbppInvoiceTokenBatchqueryResponseModel**

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

