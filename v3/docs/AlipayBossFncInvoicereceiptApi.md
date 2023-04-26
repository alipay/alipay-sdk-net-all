# AlipaySDKNet.OpenAPI.Api.AlipayBossFncInvoicereceiptApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayBossFncInvoicereceiptApi.md#batchquery) | **POST** /v3/alipay/boss/fnc/invoicereceipt/batchquery | 根据月账单号集合和来源查询开票单据及金额汇总
[**Create**](AlipayBossFncInvoicereceiptApi.md#create) | **POST** /v3/alipay/boss/fnc/invoicereceipt/create | 账单变更同步接口月帐单创建消息同步


<a name="batchquery"></a>
# **Batchquery**
> AlipayBossFncInvoicereceiptBatchqueryResponseModel Batchquery (AlipayBossFncInvoicereceiptBatchqueryModel alipayBossFncInvoicereceiptBatchqueryModel = null)

根据月账单号集合和来源查询开票单据及金额汇总

根据月账单号集合和来源查询开票单据及金额汇总

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
            var apiInstance = new AlipayBossFncInvoicereceiptApi(config);

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

            var alipayBossFncInvoicereceiptBatchqueryModel = new AlipayBossFncInvoicereceiptBatchqueryModel(); // AlipayBossFncInvoicereceiptBatchqueryModel |  (optional) 

            try
            {
                // 根据月账单号集合和来源查询开票单据及金额汇总
                AlipayBossFncInvoicereceiptBatchqueryResponseModel result = apiInstance.Batchquery(alipayBossFncInvoicereceiptBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncInvoicereceiptApi.Batchquery: " + e.Message );
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
 **alipayBossFncInvoicereceiptBatchqueryModel** | **AlipayBossFncInvoicereceiptBatchqueryModel**|  | [optional] 

### Return type

**AlipayBossFncInvoicereceiptBatchqueryResponseModel**

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

<a name="create"></a>
# **Create**
> Object Create (AlipayBossFncInvoicereceiptCreateModel alipayBossFncInvoicereceiptCreateModel = null)

账单变更同步接口月帐单创建消息同步

月帐单创建消息同步

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
            var apiInstance = new AlipayBossFncInvoicereceiptApi(config);

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

            var alipayBossFncInvoicereceiptCreateModel = new AlipayBossFncInvoicereceiptCreateModel(); // AlipayBossFncInvoicereceiptCreateModel |  (optional) 

            try
            {
                // 账单变更同步接口月帐单创建消息同步
                Object result = apiInstance.Create(alipayBossFncInvoicereceiptCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncInvoicereceiptApi.Create: " + e.Message );
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
 **alipayBossFncInvoicereceiptCreateModel** | **AlipayBossFncInvoicereceiptCreateModel**|  | [optional] 

### Return type

**Object**

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

