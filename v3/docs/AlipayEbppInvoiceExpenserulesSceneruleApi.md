# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpenserulesSceneruleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceExpenserulesSceneruleApi.md#create) | **POST** /v3/alipay/ebpp/invoice/expenserules/scenerule/create | 创建费控规则
[**Modify**](AlipayEbppInvoiceExpenserulesSceneruleApi.md#modify) | **POST** /v3/alipay/ebpp/invoice/expenserules/scenerule/modify | 修改费控规则
[**Query**](AlipayEbppInvoiceExpenserulesSceneruleApi.md#query) | **GET** /v3/alipay/ebpp/invoice/expenserules/scenerule/query | 查询费控规则信息


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceExpenserulesSceneruleCreateResponseModel Create (AlipayEbppInvoiceExpenserulesSceneruleCreateModel alipayEbppInvoiceExpenserulesSceneruleCreateModel = null)

创建费控规则

创建费控规则，例如：创建一条有效期为2021-08-01 00:00:00到2031-08-01 00:00:00的福利餐费控规则，限制对应员工的单日消费金额不超过100元；

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
            var apiInstance = new AlipayEbppInvoiceExpenserulesSceneruleApi(config);

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

            var alipayEbppInvoiceExpenserulesSceneruleCreateModel = new AlipayEbppInvoiceExpenserulesSceneruleCreateModel(); // AlipayEbppInvoiceExpenserulesSceneruleCreateModel |  (optional) 

            try
            {
                // 创建费控规则
                AlipayEbppInvoiceExpenserulesSceneruleCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceExpenserulesSceneruleCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesSceneruleApi.Create: " + e.Message );
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
 **alipayEbppInvoiceExpenserulesSceneruleCreateModel** | **AlipayEbppInvoiceExpenserulesSceneruleCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesSceneruleCreateResponseModel**

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

<a name="modify"></a>
# **Modify**
> AlipayEbppInvoiceExpenserulesSceneruleModifyResponseModel Modify (AlipayEbppInvoiceExpenserulesSceneruleModifyModel alipayEbppInvoiceExpenserulesSceneruleModifyModel = null)

修改费控规则

修改费控规则

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
    public class ModifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceExpenserulesSceneruleApi(config);

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

            var alipayEbppInvoiceExpenserulesSceneruleModifyModel = new AlipayEbppInvoiceExpenserulesSceneruleModifyModel(); // AlipayEbppInvoiceExpenserulesSceneruleModifyModel |  (optional) 

            try
            {
                // 修改费控规则
                AlipayEbppInvoiceExpenserulesSceneruleModifyResponseModel result = apiInstance.Modify(alipayEbppInvoiceExpenserulesSceneruleModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesSceneruleApi.Modify: " + e.Message );
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
 **alipayEbppInvoiceExpenserulesSceneruleModifyModel** | **AlipayEbppInvoiceExpenserulesSceneruleModifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesSceneruleModifyResponseModel**

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
> AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel Query (string accountId = null, string agreementNo = null, string enterpriseId = null, string standardId = null, int? pageNum = null, int? pageSize = null)

查询费控规则信息

查询费控规则信息

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
            var apiInstance = new AlipayEbppInvoiceExpenserulesSceneruleApi(config);

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

            var accountId = 2088000194958956;  // string | 企业ID (optional) 
            var agreementNo = 20215425001112341234;  // string | 授权签约协议号 (optional) 
            var enterpriseId = 2088000194958956;  // string | 企业码企业id (optional) 
            var standardId = 20215425001112341234;  // string | 费控规则ID (optional) 
            var pageNum = 1;  // int? | 页数 (optional) 
            var pageSize = 10;  // int? | 页大小 (optional) 

            try
            {
                // 查询费控规则信息
                AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel result = apiInstance.Query(accountId, agreementNo, enterpriseId, standardId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesSceneruleApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业码企业id | [optional] 
 **standardId** | **string**| 费控规则ID | [optional] 
 **pageNum** | **int?**| 页数 | [optional] 
 **pageSize** | **int?**| 页大小 | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel**

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

