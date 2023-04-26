# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityDeliverychannelApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayMarketingActivityDeliverychannelApi.md#query) | **POST** /v3/alipay/marketing/activity/deliverychannel/query | 查询可推广渠道


<a name="query"></a>
# **Query**
> AlipayMarketingActivityDeliverychannelQueryResponseModel Query (AlipayMarketingActivityDeliverychannelQueryModel alipayMarketingActivityDeliverychannelQueryModel = null)

查询可推广渠道

查询可推广渠道。该接口会返回可以投放的所有渠道的详细信息。 其中每个渠道的boothCode含义：boothCode表达的是某个渠道可以投放的展位码。例如：支付结果页PAY_RESULT 其中每个渠道的channel含义：表达的是某个固定的渠道。例如：在boothCode = PAY_RESULT 的情况下， channel = 商户的pid。 该channel就是一个可以投放的渠道，投放后可以在对应的商户的支付结果页看到优惠券。后续创建投放时根据返回的 channel 选择投放渠道

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
            var apiInstance = new AlipayMarketingActivityDeliverychannelApi(config);

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

            var alipayMarketingActivityDeliverychannelQueryModel = new AlipayMarketingActivityDeliverychannelQueryModel(); // AlipayMarketingActivityDeliverychannelQueryModel |  (optional) 

            try
            {
                // 查询可推广渠道
                AlipayMarketingActivityDeliverychannelQueryResponseModel result = apiInstance.Query(alipayMarketingActivityDeliverychannelQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityDeliverychannelApi.Query: " + e.Message );
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
 **alipayMarketingActivityDeliverychannelQueryModel** | **AlipayMarketingActivityDeliverychannelQueryModel**|  | [optional] 

### Return type

**AlipayMarketingActivityDeliverychannelQueryResponseModel**

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

