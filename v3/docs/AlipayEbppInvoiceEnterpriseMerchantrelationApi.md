# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEnterpriseMerchantrelationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceEnterpriseMerchantrelationApi.md#create) | **POST** /v3/alipay/ebpp/invoice/enterprise/merchantrelation/create | 创建企业商户关系


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel Create (string enterpriseId = null, AlipayEbppInvoiceEnterpriseMerchantrelationCreateModel alipayEbppInvoiceEnterpriseMerchantrelationCreateModel = null)

创建企业商户关系

根据交易流水号创建企业商户绑定关系

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseMerchantrelationApi(config);

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

            var enterpriseId = 2088xxx;  // string | 企业ID (optional) 
            var alipayEbppInvoiceEnterpriseMerchantrelationCreateModel = new AlipayEbppInvoiceEnterpriseMerchantrelationCreateModel(); // AlipayEbppInvoiceEnterpriseMerchantrelationCreateModel |  (optional) 

            try
            {
                // 创建企业商户关系
                AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel result = apiInstance.Create(enterpriseId, alipayEbppInvoiceEnterpriseMerchantrelationCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseMerchantrelationApi.Create: " + e.Message );
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
 **enterpriseId** | **string**| 企业ID | [optional] 
 **alipayEbppInvoiceEnterpriseMerchantrelationCreateModel** | **AlipayEbppInvoiceEnterpriseMerchantrelationCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel**

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

