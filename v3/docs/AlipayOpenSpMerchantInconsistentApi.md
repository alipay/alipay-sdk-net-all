# AlipaySDKNet.OpenAPI.Api.AlipayOpenSpMerchantInconsistentApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Approve**](AlipayOpenSpMerchantInconsistentApi.md#approve) | **POST** /v3/alipay/open/sp/merchant/inconsistent/approve | 非同人商家进件资料审批


<a name="approve"></a>
# **Approve**
> AlipayOpenSpMerchantInconsistentApproveResponseModel Approve (AlipayOpenSpMerchantInconsistentApproveModel alipayOpenSpMerchantInconsistentApproveModel = null)

非同人商家进件资料审批

针对服务优选扫码点餐小程序，用于收集并审核非同人商家的进件资料。

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
    public class ApproveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSpMerchantInconsistentApi(config);

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

            var alipayOpenSpMerchantInconsistentApproveModel = new AlipayOpenSpMerchantInconsistentApproveModel(); // AlipayOpenSpMerchantInconsistentApproveModel |  (optional) 

            try
            {
                // 非同人商家进件资料审批
                AlipayOpenSpMerchantInconsistentApproveResponseModel result = apiInstance.Approve(alipayOpenSpMerchantInconsistentApproveModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSpMerchantInconsistentApi.Approve: " + e.Message );
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
 **alipayOpenSpMerchantInconsistentApproveModel** | **AlipayOpenSpMerchantInconsistentApproveModel**|  | [optional] 

### Return type

**AlipayOpenSpMerchantInconsistentApproveResponseModel**

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

