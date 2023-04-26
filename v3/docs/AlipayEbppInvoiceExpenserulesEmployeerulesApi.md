# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpenserulesEmployeerulesApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceExpenserulesEmployeerulesApi.md#query) | **GET** /v3/alipay/ebpp/invoice/expenserules/employeerules/query | 查询员工绑定的所有费控规则


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel Query (string accountId = null, string agreementNo = null, string employeeId = null, string employeeOpenId = null, int? pageNum = null, int? pageSize = null)

查询员工绑定的所有费控规则

分页查询指定员工绑定的所有费控规则，默认返回所有有效和无效规则，查询结果按费控规则的创建时间倒序

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
            var apiInstance = new AlipayEbppInvoiceExpenserulesEmployeerulesApi(config);

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

            var accountId = 208800019495xxxx;  // string | 企业ID (optional) 
            var agreementNo = 2021542500111234xxxx;  // string | 授权签约协议号 (optional) 
            var employeeId = 208852286537xxxx;  // string | 未切换open_id时使用此字段：员工ID (optional) 
            var employeeOpenId = abcdxxxx;  // string | 切换open_id后使用此字段：员工的open_id (optional) 
            var pageNum = 1;  // int? | 页码，默认值为1 (optional) 
            var pageSize = 20;  // int? | 每页行数，默认值为20 (optional) 

            try
            {
                // 查询员工绑定的所有费控规则
                AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel result = apiInstance.Query(accountId, agreementNo, employeeId, employeeOpenId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesEmployeerulesApi.Query: " + e.Message );
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
 **employeeId** | **string**| 未切换open_id时使用此字段：员工ID | [optional] 
 **employeeOpenId** | **string**| 切换open_id后使用此字段：员工的open_id | [optional] 
 **pageNum** | **int?**| 页码，默认值为1 | [optional] 
 **pageSize** | **int?**| 每页行数，默认值为20 | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel**

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

