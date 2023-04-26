# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpensecontrolQuotaApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceExpensecontrolQuotaApi.md#create) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/quota/create | 创建余额/点券
[**Modify**](AlipayEbppInvoiceExpensecontrolQuotaApi.md#modify) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/quota/modify | 修改余额/点券
[**Query**](AlipayEbppInvoiceExpensecontrolQuotaApi.md#query) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/quota/query | 查询余额/点券


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel Create (AlipayEbppInvoiceExpensecontrolQuotaCreateModel alipayEbppInvoiceExpensecontrolQuotaCreateModel = null)

创建余额/点券

创建余额或者点券

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolQuotaApi(config);

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

            var alipayEbppInvoiceExpensecontrolQuotaCreateModel = new AlipayEbppInvoiceExpensecontrolQuotaCreateModel(); // AlipayEbppInvoiceExpensecontrolQuotaCreateModel |  (optional) 

            try
            {
                // 创建余额/点券
                AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceExpensecontrolQuotaCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolQuotaApi.Create: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolQuotaCreateModel** | **AlipayEbppInvoiceExpensecontrolQuotaCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel**

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
> AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel Modify (AlipayEbppInvoiceExpensecontrolQuotaModifyModel alipayEbppInvoiceExpensecontrolQuotaModifyModel = null)

修改余额/点券

修改余额或点券

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolQuotaApi(config);

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

            var alipayEbppInvoiceExpensecontrolQuotaModifyModel = new AlipayEbppInvoiceExpensecontrolQuotaModifyModel(); // AlipayEbppInvoiceExpensecontrolQuotaModifyModel |  (optional) 

            try
            {
                // 修改余额/点券
                AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel result = apiInstance.Modify(alipayEbppInvoiceExpensecontrolQuotaModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolQuotaApi.Modify: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolQuotaModifyModel** | **AlipayEbppInvoiceExpensecontrolQuotaModifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel**

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
> AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel Query (AlipayEbppInvoiceExpensecontrolQuotaQueryModel alipayEbppInvoiceExpensecontrolQuotaQueryModel = null)

查询余额/点券

查询余额或者点券

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolQuotaApi(config);

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

            var alipayEbppInvoiceExpensecontrolQuotaQueryModel = new AlipayEbppInvoiceExpensecontrolQuotaQueryModel(); // AlipayEbppInvoiceExpensecontrolQuotaQueryModel |  (optional) 

            try
            {
                // 查询余额/点券
                AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel result = apiInstance.Query(alipayEbppInvoiceExpensecontrolQuotaQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolQuotaApi.Query: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolQuotaQueryModel** | **AlipayEbppInvoiceExpensecontrolQuotaQueryModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel**

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

