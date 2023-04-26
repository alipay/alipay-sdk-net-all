# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceMerchantlistEnterApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayEbppInvoiceMerchantlistEnterApi.md#apply) | **POST** /v3/alipay/ebpp/invoice/merchantlist/enter/apply | 商户批量入驻申请接口


<a name="apply"></a>
# **Apply**
> AlipayEbppInvoiceMerchantlistEnterApplyResponseModel Apply (AlipayEbppInvoiceMerchantlistEnterApplyModel alipayEbppInvoiceMerchantlistEnterApplyModel = null)

商户批量入驻申请接口

针对已经在支付宝入驻的服务方，使用该接口导入服务方后面的开票商户

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
            var apiInstance = new AlipayEbppInvoiceMerchantlistEnterApi(config);

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

            var alipayEbppInvoiceMerchantlistEnterApplyModel = new AlipayEbppInvoiceMerchantlistEnterApplyModel(); // AlipayEbppInvoiceMerchantlistEnterApplyModel |  (optional) 

            try
            {
                // 商户批量入驻申请接口
                AlipayEbppInvoiceMerchantlistEnterApplyResponseModel result = apiInstance.Apply(alipayEbppInvoiceMerchantlistEnterApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceMerchantlistEnterApi.Apply: " + e.Message );
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
 **alipayEbppInvoiceMerchantlistEnterApplyModel** | **AlipayEbppInvoiceMerchantlistEnterApplyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceMerchantlistEnterApplyResponseModel**

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

