# AlipaySDKNet.OpenAPI.Api.AlipayDataBillBailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataBillBailApi.md#query) | **GET** /v3/alipay/data/bill/bail/query | 支付宝商家账户保证金查询


<a name="query"></a>
# **Query**
> AlipayDataBillBailQueryResponseModel Query (string startTime = null, string endTime = null, string bailType = null, string transLogId = null, string bizOrigNo = null)

支付宝商家账户保证金查询

为支付宝商家提供支付宝账户保证金信息，供对账使用。

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
            var apiInstance = new AlipayDataBillBailApi(config);

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

            var startTime = 2019-01-01 00:00:00;  // string | 保证金流水创建时间的起始范围 (optional) 
            var endTime = 2019-01-02 00:00:00;  // string | 保证金流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional) 
            var bailType = TMALL_S_BAIL;  // string | 保证金类型，目前支持TMALL_S_BAIL-天猫保证金，TAOBAO_BAIL-淘宝保证金 (optional) 
            var transLogId = 20190101***;  // string | 保证金流水号。如果查询参数中指定流水号，则只查询流水号相关的记录 (optional) 
            var bizOrigNo = 1***;  // string | 业务基础订单号。如果查询参数中指定订单号，则只查询相关的记录 (optional) 

            try
            {
                // 支付宝商家账户保证金查询
                AlipayDataBillBailQueryResponseModel result = apiInstance.Query(startTime, endTime, bailType, transLogId, bizOrigNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillBailApi.Query: " + e.Message );
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
 **startTime** | **string**| 保证金流水创建时间的起始范围 | [optional] 
 **endTime** | **string**| 保证金流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 | [optional] 
 **bailType** | **string**| 保证金类型，目前支持TMALL_S_BAIL-天猫保证金，TAOBAO_BAIL-淘宝保证金 | [optional] 
 **transLogId** | **string**| 保证金流水号。如果查询参数中指定流水号，则只查询流水号相关的记录 | [optional] 
 **bizOrigNo** | **string**| 业务基础订单号。如果查询参数中指定订单号，则只查询相关的记录 | [optional] 

### Return type

**AlipayDataBillBailQueryResponseModel**

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

