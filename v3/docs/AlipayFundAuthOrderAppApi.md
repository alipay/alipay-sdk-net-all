# AlipaySDKNet.OpenAPI.Api.AlipayFundAuthOrderAppApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Freeze**](AlipayFundAuthOrderAppApi.md#freeze) | **POST** /v3/alipay/fund/auth/order/app/freeze | 线上资金授权冻结接口


<a name="freeze"></a>
# **Freeze**
> AlipayFundAuthOrderAppFreezeResponseModel Freeze (AlipayFundAuthOrderAppFreezeModel alipayFundAuthOrderAppFreezeModel = null)

线上资金授权冻结接口

创建支付宝授权订单并完成资金冻结。适用于线上场景完成资金授权, 例如从商户APP端拉起支付宝收银台完成冻结。

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
    public class FreezeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundAuthOrderAppApi(config);

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

            var alipayFundAuthOrderAppFreezeModel = new AlipayFundAuthOrderAppFreezeModel(); // AlipayFundAuthOrderAppFreezeModel |  (optional) 

            try
            {
                // 线上资金授权冻结接口
                AlipayFundAuthOrderAppFreezeResponseModel result = apiInstance.Freeze(alipayFundAuthOrderAppFreezeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAuthOrderAppApi.Freeze: " + e.Message );
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
 **alipayFundAuthOrderAppFreezeModel** | **AlipayFundAuthOrderAppFreezeModel**|  | [optional] 

### Return type

**AlipayFundAuthOrderAppFreezeResponseModel**

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

