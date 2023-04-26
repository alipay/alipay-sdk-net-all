# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpenserulesEmployeeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceExpenserulesEmployeeApi.md#query) | **GET** /v3/alipay/ebpp/invoice/expenserules/employee/query | 查询费控规则员工


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceExpenserulesEmployeeQueryResponseModel Query (string accountId = null, string agreementNo = null, string enterpriseId = null, string standardId = null, int? pageNum = null, int? pageSize = null)

查询费控规则员工

查询费控规则员工

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
            var apiInstance = new AlipayEbppInvoiceExpenserulesEmployeeApi(config);

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

            var accountId = 2088123456789000;  // string | 共同账号ID (optional) 
            var agreementNo = 20205820659822371223;  // string | 授权签约协议号 (optional) 
            var enterpriseId = 2088000194958956;  // string | 企业码企业id (optional) 
            var standardId = 2021081900152601000000000101;  // string | 费控规则ID (optional) 
            var pageNum = 1;  // int? | 页数 (optional) 
            var pageSize = 20;  // int? | 页大小 (optional) 

            try
            {
                // 查询费控规则员工
                AlipayEbppInvoiceExpenserulesEmployeeQueryResponseModel result = apiInstance.Query(accountId, agreementNo, enterpriseId, standardId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesEmployeeApi.Query: " + e.Message );
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
 **accountId** | **string**| 共同账号ID | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **enterpriseId** | **string**| 企业码企业id | [optional] 
 **standardId** | **string**| 费控规则ID | [optional] 
 **pageNum** | **int?**| 页数 | [optional] 
 **pageSize** | **int?**| 页大小 | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesEmployeeQueryResponseModel**

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

