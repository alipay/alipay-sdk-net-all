# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpensecontrolEmployeequotaApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceExpensecontrolEmployeequotaApi.md#create) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/employeequota/create | 创建余额（特定场景）


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceExpensecontrolEmployeequotaCreateResponseModel Create (AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel alipayEbppInvoiceExpensecontrolEmployeequotaCreateModel = null)

创建余额（特定场景）

创建余额，该接口开放给特定场景。如果需要使用，请联系技术支持。

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolEmployeequotaApi(config);

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

            var alipayEbppInvoiceExpensecontrolEmployeequotaCreateModel = new AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel(); // AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel |  (optional) 

            try
            {
                // 创建余额（特定场景）
                AlipayEbppInvoiceExpensecontrolEmployeequotaCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceExpensecontrolEmployeequotaCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolEmployeequotaApi.Create: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolEmployeequotaCreateModel** | **AlipayEbppInvoiceExpensecontrolEmployeequotaCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolEmployeequotaCreateResponseModel**

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

