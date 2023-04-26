# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceFileOutputApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceFileOutputApi.md#query) | **GET** /v3/alipay/ebpp/invoice/file/output/query | 获取电子发票原文件


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceFileOutputQueryResponseModel Query (string userId = null, string openId = null, string invoiceCode = null, string invoiceNo = null, string scene = null, bool? skipExpenseProgressSync = null)

获取电子发票原文件

根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）

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
            var apiInstance = new AlipayEbppInvoiceFileOutputApi(config);

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

            var userId = 2088550000000;  // string | 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional) 
            var invoiceCode = 123;  // string | 发票代码 字段长度（10-12位），全电票时为空 (optional) 
            var invoiceNo = 111;  // string | 发票号码 字段长度（8-10位），全电票时为20位 (optional) 
            var scene = INVOICE_EXPENSE;  // string | 发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional) 
            var skipExpenseProgressSync = false;  // bool? | 是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional) 

            try
            {
                // 获取电子发票原文件
                AlipayEbppInvoiceFileOutputQueryResponseModel result = apiInstance.Query(userId, openId, invoiceCode, invoiceNo, scene, skipExpenseProgressSync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceFileOutputApi.Query: " + e.Message );
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
 **userId** | **string**| 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 | [optional] 
 **openId** | **string**| 发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 | [optional] 
 **invoiceCode** | **string**| 发票代码 字段长度（10-12位），全电票时为空 | [optional] 
 **invoiceNo** | **string**| 发票号码 字段长度（8-10位），全电票时为20位 | [optional] 
 **scene** | **string**| 发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 | [optional] 
 **skipExpenseProgressSync** | **bool?**| 是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 | [optional] 

### Return type

**AlipayEbppInvoiceFileOutputQueryResponseModel**

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

