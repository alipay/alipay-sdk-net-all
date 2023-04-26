# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCampaignCashListApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayMarketingCampaignCashListApi.md#query) | **GET** /v3/alipay/marketing/campaign/cash/list/query | 现金活动列表查询


<a name="query"></a>
# **Query**
> AlipayMarketingCampaignCashListQueryResponseModel Query (string campStatus = null, string pageSize = null, string pageIndex = null)

现金活动列表查询

商户通过开放平台查询自己创建的现金活动列表

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
            var apiInstance = new AlipayMarketingCampaignCashListApi(config);

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

            var campStatus = PAID;  // string | 要查询的活动状态,不填默认为 ALL 返回所有类型。枚举支持: *ALL：所有类型的活动。 *CREATED：已创建未打款。 *PAID：已打款。 *READY：活动已开始。 *PAUSE：活动已暂停。 *CLOSED：活动已结束。 *SETTLE：活动已清算。 (optional) 
            var pageSize = 10;  // string | 分页查询时每页返回的列表大小，每页数据最大为 50。 (optional) 
            var pageIndex = 1;  // string | 分页查询时的页码，从1开始 (optional) 

            try
            {
                // 现金活动列表查询
                AlipayMarketingCampaignCashListQueryResponseModel result = apiInstance.Query(campStatus, pageSize, pageIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCampaignCashListApi.Query: " + e.Message );
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
 **campStatus** | **string**| 要查询的活动状态,不填默认为 ALL 返回所有类型。枚举支持: *ALL：所有类型的活动。 *CREATED：已创建未打款。 *PAID：已打款。 *READY：活动已开始。 *PAUSE：活动已暂停。 *CLOSED：活动已结束。 *SETTLE：活动已清算。 | [optional] 
 **pageSize** | **string**| 分页查询时每页返回的列表大小，每页数据最大为 50。 | [optional] 
 **pageIndex** | **string**| 分页查询时的页码，从1开始 | [optional] 

### Return type

**AlipayMarketingCampaignCashListQueryResponseModel**

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

