# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniTipsStatisticApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenMiniTipsStatisticApi.md#query) | **GET** /v3/alipay/open/mini/tips/statistic/query | 小程序收藏引导汇总数据查询


<a name="query"></a>
# **Query**
> AlipayOpenMiniTipsStatisticQueryResponseModel Query (string deliveryId = null, string queryType = null, string startDate = null, string endDate = null)

小程序收藏引导汇总数据查询

小程序收藏引导tips文案投放汇总数据查询接口。可查询小程序维度或活动维度的tips曝光uv，收藏uv，以及收藏转化率。请先配置投放活动，否则查询结果返回参数为空。

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
            var apiInstance = new AlipayOpenMiniTipsStatisticApi(config);

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

            var deliveryId = 20220308000000934758;  // string | 收藏引导投放活动ID，供查询收藏引导活动配置接口调用 ，当以小程序维度查询数据（query_type为app）时delivery_id为空 (optional) 
            var queryType = app;  // string | 查询类型，表示以当前维度进行数据聚合。 app：小程序维度；activity：活动维度； (optional) 
            var startDate = 20220322;  // string | 查询开始日期，精度为天 (optional) 
            var endDate = 20220328;  // string | 查询截止日期，精度为天 (optional) 

            try
            {
                // 小程序收藏引导汇总数据查询
                AlipayOpenMiniTipsStatisticQueryResponseModel result = apiInstance.Query(deliveryId, queryType, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniTipsStatisticApi.Query: " + e.Message );
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
 **deliveryId** | **string**| 收藏引导投放活动ID，供查询收藏引导活动配置接口调用 ，当以小程序维度查询数据（query_type为app）时delivery_id为空 | [optional] 
 **queryType** | **string**| 查询类型，表示以当前维度进行数据聚合。 app：小程序维度；activity：活动维度； | [optional] 
 **startDate** | **string**| 查询开始日期，精度为天 | [optional] 
 **endDate** | **string**| 查询截止日期，精度为天 | [optional] 

### Return type

**AlipayOpenMiniTipsStatisticQueryResponseModel**

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

