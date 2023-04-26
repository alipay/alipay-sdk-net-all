# AlipaySDKNet.OpenAPI.Api.AlipayMarketingRecruitPlanApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayMarketingRecruitPlanApi.md#query) | **POST** /v3/alipay/marketing/recruit/plan/query | 招商方案详情查询


<a name="query"></a>
# **Query**
> AlipayMarketingRecruitPlanQueryResponseModel Query (AlipayMarketingRecruitPlanQueryModel alipayMarketingRecruitPlanQueryModel = null)

招商方案详情查询

招商方案详情查询

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
            var apiInstance = new AlipayMarketingRecruitPlanApi(config);

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

            var alipayMarketingRecruitPlanQueryModel = new AlipayMarketingRecruitPlanQueryModel(); // AlipayMarketingRecruitPlanQueryModel |  (optional) 

            try
            {
                // 招商方案详情查询
                AlipayMarketingRecruitPlanQueryResponseModel result = apiInstance.Query(alipayMarketingRecruitPlanQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingRecruitPlanApi.Query: " + e.Message );
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
 **alipayMarketingRecruitPlanQueryModel** | **AlipayMarketingRecruitPlanQueryModel**|  | [optional] 

### Return type

**AlipayMarketingRecruitPlanQueryResponseModel**

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

