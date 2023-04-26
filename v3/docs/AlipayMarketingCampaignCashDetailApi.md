# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCampaignCashDetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayMarketingCampaignCashDetailApi.md#query) | **GET** /v3/alipay/marketing/campaign/cash/detail/query | 现金活动详情查询


<a name="query"></a>
# **Query**
> AlipayMarketingCampaignCashDetailQueryResponseModel Query (string crowdNo = null)

现金活动详情查询

商户通过开放平台查询自己创建的现金活动详情

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
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingCampaignCashDetailApi(config);

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

            var crowdNo = POYb84lfiKVdIfERAYsqPL_KQRIpfQbl47xfRmmPBlDMnSZ96O-zxUfKlHp5cxmx;  // string | 现金活动号，通过<a href=\"https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create\">alipay.marketing.campaign.cash.create</a>(创建现金活动)接口创建现金活动获取。 (optional) 

            try
            {
                // 现金活动详情查询
                AlipayMarketingCampaignCashDetailQueryResponseModel result = apiInstance.Query(crowdNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCampaignCashDetailApi.Query: " + e.Message );
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
 **crowdNo** | **string**| 现金活动号，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create\&quot;&gt;alipay.marketing.campaign.cash.create&lt;/a&gt;(创建现金活动)接口创建现金活动获取。 | [optional] 

### Return type

**AlipayMarketingCampaignCashDetailQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

