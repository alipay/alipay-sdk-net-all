# AlipaySDKNet.OpenAPI.Api.AlipayBossFncInvoiceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayBossFncInvoiceApi.md#apply) | **POST** /v3/alipay/boss/fnc/invoice/apply | 应收开票申请(根据账单申请)
[**Batchquery**](AlipayBossFncInvoiceApi.md#batchquery) | **POST** /v3/alipay/boss/fnc/invoice/batchquery | 应收发票综合查询
[**Query**](AlipayBossFncInvoiceApi.md#query) | **GET** /v3/alipay/boss/fnc/invoice/query | 根据发票ID查询发票信息


<a name="apply"></a>
# **Apply**
> AlipayBossFncInvoiceApplyResponseModel Apply (AlipayBossFncInvoiceApplyModel alipayBossFncInvoiceApplyModel = null)

应收开票申请(根据账单申请)

根据账单申请应收发票开票

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
    public class ApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayBossFncInvoiceApi(config);

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

            var alipayBossFncInvoiceApplyModel = new AlipayBossFncInvoiceApplyModel(); // AlipayBossFncInvoiceApplyModel |  (optional) 

            try
            {
                // 应收开票申请(根据账单申请)
                AlipayBossFncInvoiceApplyResponseModel result = apiInstance.Apply(alipayBossFncInvoiceApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncInvoiceApi.Apply: " + e.Message );
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
 **alipayBossFncInvoiceApplyModel** | **AlipayBossFncInvoiceApplyModel**|  | [optional] 

### Return type

**AlipayBossFncInvoiceApplyResponseModel**

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

<a name="batchquery"></a>
# **Batchquery**
> AlipayBossFncInvoiceBatchqueryResponseModel Batchquery (AlipayBossFncInvoiceBatchqueryModel alipayBossFncInvoiceBatchqueryModel = null)

应收发票综合查询

根据综合查询条件查询对应发票信息

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
            var apiInstance = new AlipayBossFncInvoiceApi(config);

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

            var alipayBossFncInvoiceBatchqueryModel = new AlipayBossFncInvoiceBatchqueryModel(); // AlipayBossFncInvoiceBatchqueryModel |  (optional) 

            try
            {
                // 应收发票综合查询
                AlipayBossFncInvoiceBatchqueryResponseModel result = apiInstance.Batchquery(alipayBossFncInvoiceBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncInvoiceApi.Batchquery: " + e.Message );
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
 **alipayBossFncInvoiceBatchqueryModel** | **AlipayBossFncInvoiceBatchqueryModel**|  | [optional] 

### Return type

**AlipayBossFncInvoiceBatchqueryResponseModel**

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
> AlipayBossFncInvoiceQueryResponseModel Query (string invoiceId = null)

根据发票ID查询发票信息

根据发票综合查询接口（alipay.boss.fnc.invoice.batchquery）查询到发票列表后，再根据每个发票对应的发票id查询发票的详细信息

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
            var apiInstance = new AlipayBossFncInvoiceApi(config);

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

            var invoiceId = 如：2017060210122000040400270002815483;  // string | 查询ID：用于标示一张发票，通过发票综合查询可以查询到该ID。 (optional) 

            try
            {
                // 根据发票ID查询发票信息
                AlipayBossFncInvoiceQueryResponseModel result = apiInstance.Query(invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncInvoiceApi.Query: " + e.Message );
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
 **invoiceId** | **string**| 查询ID：用于标示一张发票，通过发票综合查询可以查询到该ID。 | [optional] 

### Return type

**AlipayBossFncInvoiceQueryResponseModel**

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

