# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sycn**](AlipayEbppInvoiceApi.md#sycn) | **POST** /v3/alipay/ebpp/invoice/sycn | 发票信息同步至支付宝


<a name="sycn"></a>
# **Sycn**
> AlipayEbppInvoiceSycnResponseModel Sycn (AlipayEbppInvoiceSycnModel alipayEbppInvoiceSycnModel = null)

发票信息同步至支付宝

外部商户开蓝票/冲红执行成功后将发票信息及原件（如有）同步至支付宝，由支付宝通知用户查看已开具的发票。

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
    public class SycnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceApi(config);

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

            var alipayEbppInvoiceSycnModel = new AlipayEbppInvoiceSycnModel(); // AlipayEbppInvoiceSycnModel |  (optional) 

            try
            {
                // 发票信息同步至支付宝
                AlipayEbppInvoiceSycnResponseModel result = apiInstance.Sycn(alipayEbppInvoiceSycnModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceApi.Sycn: " + e.Message );
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
 **alipayEbppInvoiceSycnModel** | **AlipayEbppInvoiceSycnModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceSycnResponseModel**

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

