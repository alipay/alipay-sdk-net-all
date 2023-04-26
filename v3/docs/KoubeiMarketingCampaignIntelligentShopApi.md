# AlipaySDKNet.OpenAPI.Api.KoubeiMarketingCampaignIntelligentShopApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Consult**](KoubeiMarketingCampaignIntelligentShopApi.md#consult) | **POST** /v3/koubei/marketing/campaign/intelligent/shop/consult | 智能营销门店咨询


<a name="consult"></a>
# **Consult**
> KoubeiMarketingCampaignIntelligentShopConsultResponseModel Consult (KoubeiMarketingCampaignIntelligentShopConsultModel koubeiMarketingCampaignIntelligentShopConsultModel = null)

智能营销门店咨询

咨询完智能营销活动模型后，可以查询商户的符合智能营销活动标准的门店

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
            var apiInstance = new KoubeiMarketingCampaignIntelligentShopApi(config);

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

            var koubeiMarketingCampaignIntelligentShopConsultModel = new KoubeiMarketingCampaignIntelligentShopConsultModel(); // KoubeiMarketingCampaignIntelligentShopConsultModel |  (optional) 

            try
            {
                // 智能营销门店咨询
                KoubeiMarketingCampaignIntelligentShopConsultResponseModel result = apiInstance.Consult(koubeiMarketingCampaignIntelligentShopConsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignIntelligentShopApi.Consult: " + e.Message );
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
 **koubeiMarketingCampaignIntelligentShopConsultModel** | **KoubeiMarketingCampaignIntelligentShopConsultModel**|  | [optional] 

### Return type

**KoubeiMarketingCampaignIntelligentShopConsultResponseModel**

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

