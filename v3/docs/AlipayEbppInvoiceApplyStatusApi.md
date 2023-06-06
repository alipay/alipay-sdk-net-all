# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceApplyStatusApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Notify**](AlipayEbppInvoiceApplyStatusApi.md#notify) | **PUT** /v3/alipay/ebpp/invoice/apply/status/notify | 发票申请状态变更


<a name="notify"></a>
# **Notify**
> AlipayEbppInvoiceApplyStatusNotifyResponseModel Notify (AlipayEbppInvoiceApplyStatusNotifyModel alipayEbppInvoiceApplyStatusNotifyModel = null)

发票申请状态变更

发票申请状态变更通知

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
            var apiInstance = new AlipayEbppInvoiceApplyStatusApi(config);

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

            var alipayEbppInvoiceApplyStatusNotifyModel = new AlipayEbppInvoiceApplyStatusNotifyModel(); // AlipayEbppInvoiceApplyStatusNotifyModel |  (optional) 

            try
            {
                // 发票申请状态变更
                AlipayEbppInvoiceApplyStatusNotifyResponseModel result = apiInstance.Notify(alipayEbppInvoiceApplyStatusNotifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceApplyStatusApi.Notify: " + e.Message );
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
 **alipayEbppInvoiceApplyStatusNotifyModel** | **AlipayEbppInvoiceApplyStatusNotifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceApplyStatusNotifyResponseModel**

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

