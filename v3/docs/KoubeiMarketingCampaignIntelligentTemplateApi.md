# AlipaySDKNet.OpenAPI.Api.KoubeiMarketingCampaignIntelligentTemplateApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Consult**](KoubeiMarketingCampaignIntelligentTemplateApi.md#consult) | **POST** /v3/koubei/marketing/campaign/intelligent/template/consult | 智能营销模板咨询


<a name="consult"></a>
# **Consult**
> KoubeiMarketingCampaignIntelligentTemplateConsultResponseModel Consult (KoubeiMarketingCampaignIntelligentTemplateConsultModel koubeiMarketingCampaignIntelligentTemplateConsultModel = null)

智能营销模板咨询

咨询可使用的智能营销模板

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
            var apiInstance = new KoubeiMarketingCampaignIntelligentTemplateApi(config);

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

            var koubeiMarketingCampaignIntelligentTemplateConsultModel = new KoubeiMarketingCampaignIntelligentTemplateConsultModel(); // KoubeiMarketingCampaignIntelligentTemplateConsultModel |  (optional) 

            try
            {
                // 智能营销模板咨询
                KoubeiMarketingCampaignIntelligentTemplateConsultResponseModel result = apiInstance.Consult(koubeiMarketingCampaignIntelligentTemplateConsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignIntelligentTemplateApi.Consult: " + e.Message );
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
 **koubeiMarketingCampaignIntelligentTemplateConsultModel** | **KoubeiMarketingCampaignIntelligentTemplateConsultModel**|  | [optional] 

### Return type

**KoubeiMarketingCampaignIntelligentTemplateConsultResponseModel**

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

