# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpensecontrolAggregationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceExpensecontrolAggregationApi.md#create) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/aggregation/create | 创建费控规则聚合关系


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel Create (AlipayEbppInvoiceExpensecontrolAggregationCreateModel alipayEbppInvoiceExpensecontrolAggregationCreateModel = null)

创建费控规则聚合关系

创建费控规则聚合关系

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolAggregationApi(config);

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

            var alipayEbppInvoiceExpensecontrolAggregationCreateModel = new AlipayEbppInvoiceExpensecontrolAggregationCreateModel(); // AlipayEbppInvoiceExpensecontrolAggregationCreateModel |  (optional) 

            try
            {
                // 创建费控规则聚合关系
                AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceExpensecontrolAggregationCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolAggregationApi.Create: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolAggregationCreateModel** | **AlipayEbppInvoiceExpensecontrolAggregationCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel**

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

