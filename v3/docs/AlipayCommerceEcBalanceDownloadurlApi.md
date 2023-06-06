# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcBalanceDownloadurlApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceEcBalanceDownloadurlApi.md#query) | **GET** /v3/alipay/commerce/ec/balance/downloadurl/query | 对账单文件下载接口


<a name="query"></a>
# **Query**
> AlipayCommerceEcBalanceDownloadurlQueryResponseModel Query (string enterpriseId = null, string accountId = null, string agreementNo = null, string billType = null, string billDate = null)

对账单文件下载接口

对账单文件下载接口

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
            var apiInstance = new AlipayCommerceEcBalanceDownloadurlApi(config);

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

            var enterpriseId = 2088123456789000;  // string | 企业ID (optional) 
            var accountId = 2088000295356628;  // string | 共同账户ID (optional) 
            var agreementNo = 20205820659822371223;  // string | 授权签约协议号 (optional) 
            var billType = enterprisetrade;  // string | 账单类型 (optional) 
            var billDate = yyyy-MM-dd;  // string | 账单时间 (optional) 

            try
            {
                // 对账单文件下载接口
                AlipayCommerceEcBalanceDownloadurlQueryResponseModel result = apiInstance.Query(enterpriseId, accountId, agreementNo, billType, billDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcBalanceDownloadurlApi.Query: " + e.Message );
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
 **accountId** | **string**| 共同账户ID | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **billType** | **string**| 账单类型 | [optional] 
 **billDate** | **string**| 账单时间 | [optional] 

### Return type

**AlipayCommerceEcBalanceDownloadurlQueryResponseModel**

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

