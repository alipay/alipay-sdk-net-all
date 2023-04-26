# AlipaySDKNet.OpenAPI.Api.AlipayDataBillTransferApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataBillTransferApi.md#query) | **GET** /v3/alipay/data/bill/transfer/query | 支付宝商家账户充值，转账，提现查询


<a name="query"></a>
# **Query**
> AlipayDataBillTransferQueryResponseModel Query (string startTime = null, string endTime = null, string type = null, string pageNo = null, string pageSize = null)

支付宝商家账户充值，转账，提现查询

为支付宝商家提供支付宝账户充值，转账，提现信息，供对账使用。

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
            var apiInstance = new AlipayDataBillTransferApi(config);

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

            var startTime = 2019-01-01 00:00:00;  // string | 充值、转账、提现流水业务时间的起始范围 (optional) 
            var endTime = 2019-01-02 00:00:00;  // string | 充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional) 
            var type = DEPOSIT;  // string | 转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。 (optional) 
            var pageNo = 1;  // string | 分页号，从1开始 (optional) 
            var pageSize = 2000;  // string | 分页大小1000-2000，默认2000 (optional) 

            try
            {
                // 支付宝商家账户充值，转账，提现查询
                AlipayDataBillTransferQueryResponseModel result = apiInstance.Query(startTime, endTime, type, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillTransferApi.Query: " + e.Message );
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
 **startTime** | **string**| 充值、转账、提现流水业务时间的起始范围 | [optional] 
 **endTime** | **string**| 充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 | [optional] 
 **type** | **string**| 转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。 | [optional] 
 **pageNo** | **string**| 分页号，从1开始 | [optional] 
 **pageSize** | **string**| 分页大小1000-2000，默认2000 | [optional] 

### Return type

**AlipayDataBillTransferQueryResponseModel**

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

