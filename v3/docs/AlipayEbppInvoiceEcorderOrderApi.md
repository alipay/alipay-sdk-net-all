# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEcorderOrderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceEcorderOrderApi.md#query) | **GET** /v3/alipay/ebpp/invoice/ecorder/order/query | 企业码订单查询


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceEcorderOrderQueryResponseModel Query (string enterpriseId = null, string accountId = null, string agreementNo = null, string orderId = null, string orderType = null)

企业码订单查询

企业码订单查询

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
            var apiInstance = new AlipayEbppInvoiceEcorderOrderApi(config);

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

            var enterpriseId = 2088501296144291;  // string | 企业ID (optional) 
            var accountId = 2088000000000000;  // string | 共同账户ID，有企业ID可不传 (optional) 
            var agreementNo = 20200000000000000000;  // string | 授权签约协议号，有企业ID可不传 (optional) 
            var orderId = 2020103022000000000000000000;  // string | 订单ID (optional) 
            var orderType = METRO;  // string | 订单类型 (optional) 

            try
            {
                // 企业码订单查询
                AlipayEbppInvoiceEcorderOrderQueryResponseModel result = apiInstance.Query(enterpriseId, accountId, agreementNo, orderId, orderType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEcorderOrderApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业ID | [optional] 
 **accountId** | **string**| 共同账户ID，有企业ID可不传 | [optional] 
 **agreementNo** | **string**| 授权签约协议号，有企业ID可不传 | [optional] 
 **orderId** | **string**| 订单ID | [optional] 
 **orderType** | **string**| 订单类型 | [optional] 

### Return type

**AlipayEbppInvoiceEcorderOrderQueryResponseModel**

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

