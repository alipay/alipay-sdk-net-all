# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPeZmgoPreorderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](ZhimaCreditPeZmgoPreorderApi.md#create) | **PUT** /v3/zhima/credit/pe/zmgo/preorder/create | 芝麻GO签约预创单


<a name="create"></a>
# **Create**
> ZhimaCreditPeZmgoPreorderCreateResponseModel Create (ZhimaCreditPeZmgoPreorderCreateModel zhimaCreditPeZmgoPreorderCreateModel = null)

芝麻GO签约预创单

芝麻GO签约三件套前预创建单据，预传入签约基本参数和自定义配置，并支持动态模板配置能力。

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
            var apiInstance = new ZhimaCreditPeZmgoPreorderApi(config);

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

            var zhimaCreditPeZmgoPreorderCreateModel = new ZhimaCreditPeZmgoPreorderCreateModel(); // ZhimaCreditPeZmgoPreorderCreateModel |  (optional) 

            try
            {
                // 芝麻GO签约预创单
                ZhimaCreditPeZmgoPreorderCreateResponseModel result = apiInstance.Create(zhimaCreditPeZmgoPreorderCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoPreorderApi.Create: " + e.Message );
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
 **zhimaCreditPeZmgoPreorderCreateModel** | **ZhimaCreditPeZmgoPreorderCreateModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoPreorderCreateResponseModel**

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

