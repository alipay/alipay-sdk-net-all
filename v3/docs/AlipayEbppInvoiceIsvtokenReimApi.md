# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceIsvtokenReimApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayEbppInvoiceIsvtokenReimApi.md#apply) | **POST** /v3/alipay/ebpp/invoice/isvtoken/reim/apply | 获取报销授权令牌


<a name="apply"></a>
# **Apply**
> AlipayEbppInvoiceIsvtokenReimApplyResponseModel Apply (AlipayEbppInvoiceIsvtokenReimApplyModel alipayEbppInvoiceIsvtokenReimApplyModel = null)

获取报销授权令牌

当报销软件跳转支付宝报销助手，需要通过授权令牌进行身份认证，该接口用于ISV获取报销助手的授权令牌

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
            var apiInstance = new AlipayEbppInvoiceIsvtokenReimApi(config);

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

            var alipayEbppInvoiceIsvtokenReimApplyModel = new AlipayEbppInvoiceIsvtokenReimApplyModel(); // AlipayEbppInvoiceIsvtokenReimApplyModel |  (optional) 

            try
            {
                // 获取报销授权令牌
                AlipayEbppInvoiceIsvtokenReimApplyResponseModel result = apiInstance.Apply(alipayEbppInvoiceIsvtokenReimApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceIsvtokenReimApi.Apply: " + e.Message );
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
 **alipayEbppInvoiceIsvtokenReimApplyModel** | **AlipayEbppInvoiceIsvtokenReimApplyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceIsvtokenReimApplyResponseModel**

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

