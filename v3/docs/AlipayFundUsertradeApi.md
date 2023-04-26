# AlipaySDKNet.OpenAPI.Api.AlipayFundUsertradeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayFundUsertradeApi.md#batchquery) | **POST** /v3/alipay/fund/usertrade/batchquery | 用户交易数据查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayFundUsertradeBatchqueryResponseModel Batchquery (string authToken = null, AlipayFundUsertradeBatchqueryModel alipayFundUsertradeBatchqueryModel = null)

用户交易数据查询

资金团队会监听指定门店相关的用户交易数据，并且，在用户授权后，开放该接口给到外部调用，查询用户近期内的交易数据。

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundUsertradeApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var alipayFundUsertradeBatchqueryModel = new AlipayFundUsertradeBatchqueryModel(); // AlipayFundUsertradeBatchqueryModel |  (optional) 

            try
            {
                // 用户交易数据查询
                AlipayFundUsertradeBatchqueryResponseModel result = apiInstance.Batchquery(authToken, alipayFundUsertradeBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundUsertradeApi.Batchquery: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **alipayFundUsertradeBatchqueryModel** | **AlipayFundUsertradeBatchqueryModel**|  | [optional] 

### Return type

**AlipayFundUsertradeBatchqueryResponseModel**

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

