# AlipaySDKNet.OpenAPI.Api.AlipayCommerceLogisticsOrderIstdcancelApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Preconsult**](AlipayCommerceLogisticsOrderIstdcancelApi.md#preconsult) | **POST** /v3/alipay/commerce/logistics/order/istdcancel/preconsult | 预取消即时配送订单


<a name="preconsult"></a>
# **Preconsult**
> AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel Preconsult (AlipayCommerceLogisticsOrderIstdcancelPreconsultModel alipayCommerceLogisticsOrderIstdcancelPreconsultModel = null)

预取消即时配送订单

预取消即时配送订单

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
    public class PreconsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceLogisticsOrderIstdcancelApi(config);

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

            var alipayCommerceLogisticsOrderIstdcancelPreconsultModel = new AlipayCommerceLogisticsOrderIstdcancelPreconsultModel(); // AlipayCommerceLogisticsOrderIstdcancelPreconsultModel |  (optional) 

            try
            {
                // 预取消即时配送订单
                AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel result = apiInstance.Preconsult(alipayCommerceLogisticsOrderIstdcancelPreconsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsOrderIstdcancelApi.Preconsult: " + e.Message );
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
 **alipayCommerceLogisticsOrderIstdcancelPreconsultModel** | **AlipayCommerceLogisticsOrderIstdcancelPreconsultModel**|  | [optional] 

### Return type

**AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel**

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

