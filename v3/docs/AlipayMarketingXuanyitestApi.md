# AlipaySDKNet.OpenAPI.Api.AlipayMarketingXuanyitestApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Transfer**](AlipayMarketingXuanyitestApi.md#transfer) | **POST** /v3/alipay/marketing/xuanyitest/transfer | 资源化测试4.0


<a name="transfer"></a>
# **Transfer**
> AlipayMarketingXuanyitestTransferResponseModel Transfer (AlipayMarketingXuanyitestTransferModel alipayMarketingXuanyitestTransferModel = null)

资源化测试4.0

功能测试，我有一个test，不会匹配上

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
    public class TransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingXuanyitestApi(config);

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

            var alipayMarketingXuanyitestTransferModel = new AlipayMarketingXuanyitestTransferModel(); // AlipayMarketingXuanyitestTransferModel |  (optional) 

            try
            {
                // 资源化测试4.0
                AlipayMarketingXuanyitestTransferResponseModel result = apiInstance.Transfer(alipayMarketingXuanyitestTransferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingXuanyitestApi.Transfer: " + e.Message );
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
 **alipayMarketingXuanyitestTransferModel** | **AlipayMarketingXuanyitestTransferModel**|  | [optional] 

### Return type

**AlipayMarketingXuanyitestTransferResponseModel**

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

