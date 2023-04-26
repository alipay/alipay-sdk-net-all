# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCampaignOrderVoucherApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Consult**](AlipayMarketingCampaignOrderVoucherApi.md#consult) | **POST** /v3/alipay/marketing/campaign/order/voucher/consult | 订单优惠前置咨询


<a name="consult"></a>
# **Consult**
> AlipayMarketingCampaignOrderVoucherConsultResponseModel Consult (string authToken = null, AlipayMarketingCampaignOrderVoucherConsultModel alipayMarketingCampaignOrderVoucherConsultModel = null)

订单优惠前置咨询

本接口用于前置优惠咨询，包括本订单可享的优惠券列表，注意该列表并不等价于最终核销时使用的券列表，而是包含了咨询的那一刻该订单能用的所有券，且券满足叠加使用下的互斥等规则

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
    public class ConsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingCampaignOrderVoucherApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var alipayMarketingCampaignOrderVoucherConsultModel = new AlipayMarketingCampaignOrderVoucherConsultModel(); // AlipayMarketingCampaignOrderVoucherConsultModel |  (optional) 

            try
            {
                // 订单优惠前置咨询
                AlipayMarketingCampaignOrderVoucherConsultResponseModel result = apiInstance.Consult(authToken, alipayMarketingCampaignOrderVoucherConsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCampaignOrderVoucherApi.Consult: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **alipayMarketingCampaignOrderVoucherConsultModel** | **AlipayMarketingCampaignOrderVoucherConsultModel**|  | [optional] 

### Return type

**AlipayMarketingCampaignOrderVoucherConsultResponseModel**

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

