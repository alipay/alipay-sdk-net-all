# AlipaySDKNet.OpenAPI.Api.AlipayDataBillBalancehisApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayDataBillBalancehisApi.md#query) | **GET** /v3/alipay/data/bill/balancehis/query | 支付宝商家账户历史余额查询


<a name="query"></a>
# **Query**
> AlipayDataBillBalancehisQueryResponseModel Query (string bizDate = null, string bizMonth = null)

支付宝商家账户历史余额查询

为支付宝商家提供支付宝账户历史余额信息，供对账使用。

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
            var apiInstance = new AlipayDataBillBalancehisApi(config);

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

            var bizDate = 2019-08-01;  // string | 查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional) 
            var bizMonth = 2019-08;  // string | 查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional) 

            try
            {
                // 支付宝商家账户历史余额查询
                AlipayDataBillBalancehisQueryResponseModel result = apiInstance.Query(bizDate, bizMonth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillBalancehisApi.Query: " + e.Message );
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
 **bizDate** | **string**| 查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 | [optional] 
 **bizMonth** | **string**| 查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 | [optional] 

### Return type

**AlipayDataBillBalancehisQueryResponseModel**

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

