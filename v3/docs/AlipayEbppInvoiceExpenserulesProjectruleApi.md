# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpenserulesProjectruleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceExpenserulesProjectruleApi.md#create) | **POST** /v3/alipay/ebpp/invoice/expenserules/projectrule/create | 创建项目费控规则
[**Query**](AlipayEbppInvoiceExpenserulesProjectruleApi.md#query) | **GET** /v3/alipay/ebpp/invoice/expenserules/projectrule/query | 查询项目费控规则


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel Create (AlipayEbppInvoiceExpenserulesProjectruleCreateModel alipayEbppInvoiceExpenserulesProjectruleCreateModel = null)

创建项目费控规则

创建项目费控规则

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceExpenserulesProjectruleApi(config);

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

            var alipayEbppInvoiceExpenserulesProjectruleCreateModel = new AlipayEbppInvoiceExpenserulesProjectruleCreateModel(); // AlipayEbppInvoiceExpenserulesProjectruleCreateModel |  (optional) 

            try
            {
                // 创建项目费控规则
                AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceExpenserulesProjectruleCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesProjectruleApi.Create: " + e.Message );
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
 **alipayEbppInvoiceExpenserulesProjectruleCreateModel** | **AlipayEbppInvoiceExpenserulesProjectruleCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel**

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

<a name="query"></a>
# **Query**
> AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel Query (string accountId = null, string agreementNo = null, string projectId = null, string employeeId = null, string employeeOpenId = null, int? pageNum = null, int? pageSize = null)

查询项目费控规则

查询项目费控规则

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
            var apiInstance = new AlipayEbppInvoiceExpenserulesProjectruleApi(config);

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

            var accountId = 2088000194958956;  // string | 共同账号ID (optional) 
            var agreementNo = 20215425001112341234;  // string | 授权签约协议号 (optional) 
            var projectId = 2021063000152700000000000000;  // string | 项目id（可空） (optional) 
            var employeeId = 2088123412341234;  // string | 员工UID（可空） (optional) 
            var employeeOpenId = abcdxxxx;  // string | 切换open_id后请使用：员工open_id（可空） (optional) 
            var pageNum = 1;  // int? | 页数 (optional) 
            var pageSize = 20;  // int? | 页大小 (optional) 

            try
            {
                // 查询项目费控规则
                AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel result = apiInstance.Query(accountId, agreementNo, projectId, employeeId, employeeOpenId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesProjectruleApi.Query: " + e.Message );
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
 **projectId** | **string**| 项目id（可空） | [optional] 
 **employeeId** | **string**| 员工UID（可空） | [optional] 
 **employeeOpenId** | **string**| 切换open_id后请使用：员工open_id（可空） | [optional] 
 **pageNum** | **int?**| 页数 | [optional] 
 **pageSize** | **int?**| 页大小 | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel**

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

