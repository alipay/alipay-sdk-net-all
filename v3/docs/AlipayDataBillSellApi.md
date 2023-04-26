# AlipaySDKNet.OpenAPI.Api.AlipayDataBillSellApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataBillSellApi.md#query) | **GET** /v3/alipay/data/bill/sell/query | 支付宝商家账户卖出交易查询


<a name="query"></a>
# **Query**
> AlipayDataBillSellQueryResponseModel Query (string startTime = null, string endTime = null, string alipayOrderNo = null, string merchantOrderNo = null, string storeNo = null, string pageNo = null, string pageSize = null)

支付宝商家账户卖出交易查询

为支付宝商家提供支付宝账户卖出交易信息，供对账使用。

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
            var apiInstance = new AlipayDataBillSellApi(config);

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

            var startTime = 2019-01-01 00:00:00;  // string | 卖出交易流水创建时间的起始范围 (optional) 
            var endTime = 2019-01-02 00:00:00;  // string | 卖出交易流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional) 
            var alipayOrderNo = 20190101***;  // string | 支付宝交易流水号。如果查询参数中指定流水号，则只查询流水号相关的记录 (optional) 
            var merchantOrderNo = TX***;  // string | 商户交易号。如果查询参数中指定交易号，则只查询相关的记录 (optional) 
            var storeNo = 门店1;  // string | 门店编号，模糊搜索 (optional) 
            var pageNo = 1;  // string | 分页号，从1开始 (optional) 
            var pageSize = 2000;  // string | 分页大小1000-2000，默认2000 (optional) 

            try
            {
                // 支付宝商家账户卖出交易查询
                AlipayDataBillSellQueryResponseModel result = apiInstance.Query(startTime, endTime, alipayOrderNo, merchantOrderNo, storeNo, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillSellApi.Query: " + e.Message );
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
 **startTime** | **string**| 卖出交易流水创建时间的起始范围 | [optional] 
 **endTime** | **string**| 卖出交易流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 | [optional] 
 **alipayOrderNo** | **string**| 支付宝交易流水号。如果查询参数中指定流水号，则只查询流水号相关的记录 | [optional] 
 **merchantOrderNo** | **string**| 商户交易号。如果查询参数中指定交易号，则只查询相关的记录 | [optional] 
 **storeNo** | **string**| 门店编号，模糊搜索 | [optional] 
 **pageNo** | **string**| 分页号，从1开始 | [optional] 
 **pageSize** | **string**| 分页大小1000-2000，默认2000 | [optional] 

### Return type

**AlipayDataBillSellQueryResponseModel**

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

