# AlipaySDKNet.OpenAPI.Api.AlipayDataBillAccountlogApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataBillAccountlogApi.md#query) | **GET** /v3/alipay/data/bill/accountlog/query | 支付宝商家账户账务明细查询


<a name="query"></a>
# **Query**
> AlipayDataBillAccountlogQueryResponseModel Query (string startTime = null, string endTime = null, string alipayOrderNo = null, string merchantOrderNo = null, string pageNo = null, string pageSize = null, string transCode = null, string agreementNo = null, string agreementProductCode = null, string billUserId = null)

支付宝商家账户账务明细查询

为支付宝商家提供支付宝账户的账务流水信息，供对账使用。

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
            var apiInstance = new AlipayDataBillAccountlogApi(config);

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

            var startTime = 2019-01-01 00:00:00;  // string | 账务流水创建时间的起始范围 (optional) 
            var endTime = 2019-01-02 00:00:00;  // string | 账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional) 
            var alipayOrderNo = 20190101***;  // string | 支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional) 
            var merchantOrderNo = TX***;  // string | 商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 (optional) 
            var pageNo = 1;  // string | 分页号，从1开始 (optional) 
            var pageSize = 2000;  // string | 分页大小1000-2000，默认2000 (optional) 
            var transCode = 101101,301101;  // string | 账务的类型代码，特殊场景下使用 (optional) 
            var agreementNo = 20215606000635888888;  // string | 协议授权码，特殊场景下使用 (optional) 
            var agreementProductCode = FUND_SIGN_WITHHOLDING;  // string | 协议产品码。特殊场景下使用 (optional) 
            var billUserId = 2088123456789012;  // string | 指定用户做账单查询 (optional) 

            try
            {
                // 支付宝商家账户账务明细查询
                AlipayDataBillAccountlogQueryResponseModel result = apiInstance.Query(startTime, endTime, alipayOrderNo, merchantOrderNo, pageNo, pageSize, transCode, agreementNo, agreementProductCode, billUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillAccountlogApi.Query: " + e.Message );
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
 **startTime** | **string**| 账务流水创建时间的起始范围 | [optional] 
 **endTime** | **string**| 账务流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 | [optional] 
 **alipayOrderNo** | **string**| 支付宝订单号，通过支付宝订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 | [optional] 
 **merchantOrderNo** | **string**| 商户订单号，通过商户订单号精确查询相关的流水明细，商户订单号与支付宝订单号互斥 | [optional] 
 **pageNo** | **string**| 分页号，从1开始 | [optional] 
 **pageSize** | **string**| 分页大小1000-2000，默认2000 | [optional] 
 **transCode** | **string**| 账务的类型代码，特殊场景下使用 | [optional] 
 **agreementNo** | **string**| 协议授权码，特殊场景下使用 | [optional] 
 **agreementProductCode** | **string**| 协议产品码。特殊场景下使用 | [optional] 
 **billUserId** | **string**| 指定用户做账单查询 | [optional] 

### Return type

**AlipayDataBillAccountlogQueryResponseModel**

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

