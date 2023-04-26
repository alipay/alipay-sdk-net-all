# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceInfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Send**](AlipayEbppInvoiceInfoApi.md#send) | **POST** /v3/alipay/ebpp/invoice/info/send | 发票信息回传接口（新版）


<a name="send"></a>
# **Send**
> AlipayEbppInvoiceInfoSendResponseModel Send (AlipayEbppInvoiceInfoSendModel alipayEbppInvoiceInfoSendModel = null)

发票信息回传接口（新版）

商户或ISV将发票信息发送至发票管家。例如：商户为用户开出发票之后，通过该接口将发票发送到买家支付宝的发票管家中，买家可在发票管家中查看发票。

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
    public class SendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceInfoApi(config);

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

            var alipayEbppInvoiceInfoSendModel = new AlipayEbppInvoiceInfoSendModel(); // AlipayEbppInvoiceInfoSendModel |  (optional) 

            try
            {
                // 发票信息回传接口（新版）
                AlipayEbppInvoiceInfoSendResponseModel result = apiInstance.Send(alipayEbppInvoiceInfoSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceInfoApi.Send: " + e.Message );
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
 **alipayEbppInvoiceInfoSendModel** | **AlipayEbppInvoiceInfoSendModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceInfoSendResponseModel**

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

