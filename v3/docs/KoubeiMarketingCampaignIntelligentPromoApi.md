# AlipaySDKNet.OpenAPI.Api.KoubeiMarketingCampaignIntelligentPromoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](KoubeiMarketingCampaignIntelligentPromoApi.md#batchquery) | **POST** /v3/koubei/marketing/campaign/intelligent/promo/batchquery | 智能营销活动批量查询


<a name="batchquery"></a>
# **Batchquery**
> KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel Batchquery (KoubeiMarketingCampaignIntelligentPromoBatchqueryModel koubeiMarketingCampaignIntelligentPromoBatchqueryModel = null)

智能营销活动批量查询

智能营销活动批量查询

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new KoubeiMarketingCampaignIntelligentPromoApi(config);

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

            var koubeiMarketingCampaignIntelligentPromoBatchqueryModel = new KoubeiMarketingCampaignIntelligentPromoBatchqueryModel(); // KoubeiMarketingCampaignIntelligentPromoBatchqueryModel |  (optional) 

            try
            {
                // 智能营销活动批量查询
                KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel result = apiInstance.Batchquery(koubeiMarketingCampaignIntelligentPromoBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignIntelligentPromoApi.Batchquery: " + e.Message );
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
 **koubeiMarketingCampaignIntelligentPromoBatchqueryModel** | **KoubeiMarketingCampaignIntelligentPromoBatchqueryModel**|  | [optional] 

### Return type

**KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel**

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

