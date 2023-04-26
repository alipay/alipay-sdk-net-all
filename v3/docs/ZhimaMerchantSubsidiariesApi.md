# AlipaySDKNet.OpenAPI.Api.ZhimaMerchantSubsidiariesApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](ZhimaMerchantSubsidiariesApi.md#apply) | **POST** /v3/zhima/merchant/subsidiaries/apply | 子商户信息添加
[**Close**](ZhimaMerchantSubsidiariesApi.md#close) | **POST** /v3/zhima/merchant/subsidiaries/close | 关闭子商户信息工单


<a name="apply"></a>
# **Apply**
> ZhimaMerchantSubsidiariesApplyResponseModel Apply (ZhimaMerchantSubsidiariesApplyModel zhimaMerchantSubsidiariesApplyModel = null)

子商户信息添加

子商户信息添加

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
            var apiInstance = new ZhimaMerchantSubsidiariesApi(config);

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

            var zhimaMerchantSubsidiariesApplyModel = new ZhimaMerchantSubsidiariesApplyModel(); // ZhimaMerchantSubsidiariesApplyModel |  (optional) 

            try
            {
                // 子商户信息添加
                ZhimaMerchantSubsidiariesApplyResponseModel result = apiInstance.Apply(zhimaMerchantSubsidiariesApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaMerchantSubsidiariesApi.Apply: " + e.Message );
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
 **zhimaMerchantSubsidiariesApplyModel** | **ZhimaMerchantSubsidiariesApplyModel**|  | [optional] 

### Return type

**ZhimaMerchantSubsidiariesApplyResponseModel**

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

<a name="close"></a>
# **Close**
> ZhimaMerchantSubsidiariesCloseResponseModel Close (ZhimaMerchantSubsidiariesCloseModel zhimaMerchantSubsidiariesCloseModel = null)

关闭子商户信息工单

关闭子商户信息工单

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
    public class CloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaMerchantSubsidiariesApi(config);

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

            var zhimaMerchantSubsidiariesCloseModel = new ZhimaMerchantSubsidiariesCloseModel(); // ZhimaMerchantSubsidiariesCloseModel |  (optional) 

            try
            {
                // 关闭子商户信息工单
                ZhimaMerchantSubsidiariesCloseResponseModel result = apiInstance.Close(zhimaMerchantSubsidiariesCloseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaMerchantSubsidiariesApi.Close: " + e.Message );
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
 **zhimaMerchantSubsidiariesCloseModel** | **ZhimaMerchantSubsidiariesCloseModel**|  | [optional] 

### Return type

**ZhimaMerchantSubsidiariesCloseResponseModel**

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

