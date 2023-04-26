# AlipaySDKNet.OpenAPI.Api.AlipayDataBillBizfundagentApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataBillBizfundagentApi.md#query) | **GET** /v3/alipay/data/bill/bizfundagent/query | ISV代理商户资金业务账单查询


<a name="query"></a>
# **Query**
> AlipayDataBillBizfundagentQueryResponseModel Query (string startTime = null, string endTime = null, string pageNo = null, string pageSize = null, string agreementNo = null)

ISV代理商户资金业务账单查询

用于ISV代理商户查询商户的资金业务账单

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
            var apiInstance = new AlipayDataBillBizfundagentApi(config);

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

            var startTime = 2021-01-01 00:00:00;  // string | 账单查询时间范围 - - 起始时间 (optional) 
            var endTime = 2021-02-01 00:00:00;  // string | 账单查询时间范围 - - 结束范围。时间范围最大不超过31天。 (optional) 
            var pageNo = 1;  // string | 页码，从1开始 (optional) 
            var pageSize = 2000;  // string | 分页大小1000-2000，默认2000 (optional) 
            var agreementNo = 20205215001418078112;  // string | ISV与商户授权协议号 (optional) 

            try
            {
                // ISV代理商户资金业务账单查询
                AlipayDataBillBizfundagentQueryResponseModel result = apiInstance.Query(startTime, endTime, pageNo, pageSize, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillBizfundagentApi.Query: " + e.Message );
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
 **startTime** | **string**| 账单查询时间范围 - - 起始时间 | [optional] 
 **endTime** | **string**| 账单查询时间范围 - - 结束范围。时间范围最大不超过31天。 | [optional] 
 **pageNo** | **string**| 页码，从1开始 | [optional] 
 **pageSize** | **string**| 分页大小1000-2000，默认2000 | [optional] 
 **agreementNo** | **string**| ISV与商户授权协议号 | [optional] 

### Return type

**AlipayDataBillBizfundagentQueryResponseModel**

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

