# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpensecomsueOutsourceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Notify**](AlipayEbppInvoiceExpensecomsueOutsourceApi.md#notify) | **POST** /v3/alipay/ebpp/invoice/expensecomsue/outsource/notify | 同步外部额度变更（交易形式）


<a name="notify"></a>
# **Notify**
> AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel Notify (AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel alipayEbppInvoiceExpensecomsueOutsourceNotifyModel = null)

同步外部额度变更（交易形式）

外部和企业码进行额度共管的时候，外部以交易的形式（支付、退款）将外部发生的额度变更同步给企业码

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
    public class NotifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceExpensecomsueOutsourceApi(config);

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

            var alipayEbppInvoiceExpensecomsueOutsourceNotifyModel = new AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel(); // AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel |  (optional) 

            try
            {
                // 同步外部额度变更（交易形式）
                AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel result = apiInstance.Notify(alipayEbppInvoiceExpensecomsueOutsourceNotifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecomsueOutsourceApi.Notify: " + e.Message );
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
 **alipayEbppInvoiceExpensecomsueOutsourceNotifyModel** | **AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel**

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

