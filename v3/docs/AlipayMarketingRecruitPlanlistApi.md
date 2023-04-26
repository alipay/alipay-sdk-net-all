# AlipaySDKNet.OpenAPI.Api.AlipayMarketingRecruitPlanlistApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayMarketingRecruitPlanlistApi.md#query) | **POST** /v3/alipay/marketing/recruit/planlist/query | 查询可报名的方案列表


<a name="query"></a>
# **Query**
> AlipayMarketingRecruitPlanlistQueryResponseModel Query (AlipayMarketingRecruitPlanlistQueryModel alipayMarketingRecruitPlanlistQueryModel = null)

查询可报名的方案列表

查询可报名的方案列表

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
            var apiInstance = new AlipayMarketingRecruitPlanlistApi(config);

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

            var alipayMarketingRecruitPlanlistQueryModel = new AlipayMarketingRecruitPlanlistQueryModel(); // AlipayMarketingRecruitPlanlistQueryModel |  (optional) 

            try
            {
                // 查询可报名的方案列表
                AlipayMarketingRecruitPlanlistQueryResponseModel result = apiInstance.Query(alipayMarketingRecruitPlanlistQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingRecruitPlanlistApi.Query: " + e.Message );
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
 **alipayMarketingRecruitPlanlistQueryModel** | **AlipayMarketingRecruitPlanlistQueryModel**|  | [optional] 

### Return type

**AlipayMarketingRecruitPlanlistQueryResponseModel**

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

