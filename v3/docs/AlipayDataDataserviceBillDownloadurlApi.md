# AlipaySDKNet.OpenAPI.Api.AlipayDataDataserviceBillDownloadurlApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataDataserviceBillDownloadurlApi.md#query) | **GET** /v3/alipay/data/dataservice/bill/downloadurl/query | 查询对账单下载地址


<a name="query"></a>
# **Query**
> AlipayDataDataserviceBillDownloadurlQueryResponseModel Query (string billType = null, string billDate = null, string smid = null, string secure = null)

查询对账单下载地址

为方便商户快速查账，支持商户通过本接口获取商户离线账单下载地址

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
            var apiInstance = new AlipayDataDataserviceBillDownloadurlApi(config);

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

            var billType = trade;  // string | 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型。 (optional) 
            var billDate = 2025-05-01;  // string | 账单时间： <p> * 日账单格式为yyyy-MM-dd，最早可下载近6年的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。</p> <p> * 月账单格式为yyyy-MM，最早可下载近6年的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。</p> <p> * 当biz_type为settlementMerge时候，时间为汇总批次结算资金到账的日期，日期格式为yyyy-MM-dd，最早可下载<u>2023年4月17日</u>及以后的账单。</p> <p> * 接口调用仅支持下载近6年的账单，更多账单请前往 b.alipay.com 对账中心-账单下载页下载。</p> (optional) 
            var smid = 2088123412341234;  // string | 二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用 (optional) 
            var secure = true;  // string | true表示使用安全链接，即返回的下载链接为https。 非true值的情况下，统一为false，使用http链接。 (optional) 

            try
            {
                // 查询对账单下载地址
                AlipayDataDataserviceBillDownloadurlQueryResponseModel result = apiInstance.Query(billType, billDate, smid, secure);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataDataserviceBillDownloadurlApi.Query: " + e.Message );
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
 **billType** | **string**| 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型。 | [optional] 
 **billDate** | **string**| 账单时间： &lt;p&gt; * 日账单格式为yyyy-MM-dd，最早可下载近6年的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。&lt;/p&gt; &lt;p&gt; * 月账单格式为yyyy-MM，最早可下载近6年的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。&lt;/p&gt; &lt;p&gt; * 当biz_type为settlementMerge时候，时间为汇总批次结算资金到账的日期，日期格式为yyyy-MM-dd，最早可下载&lt;u&gt;2023年4月17日&lt;/u&gt;及以后的账单。&lt;/p&gt; &lt;p&gt; * 接口调用仅支持下载近6年的账单，更多账单请前往 b.alipay.com 对账中心-账单下载页下载。&lt;/p&gt; | [optional] 
 **smid** | **string**| 二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用 | [optional] 
 **secure** | **string**| true表示使用安全链接，即返回的下载链接为https。 非true值的情况下，统一为false，使用http链接。 | [optional] 

### Return type

**AlipayDataDataserviceBillDownloadurlQueryResponseModel**

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

