# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpensesceneMerchantApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceExpensesceneMerchantApi.md#query) | **GET** /v3/alipay/ebpp/invoice/expensescene/merchant/query | 查询企业可用商户信息


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceExpensesceneMerchantQueryResponseModel Query (string accountId = null, string agreementNo = null, string enterpriseId = null, string roleId = null, string pid = null, string shopId = null, string expenseType = null, int? pageNum = null, int? pageSize = null)

查询企业可用商户信息

查询企业可用商户信息

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
            var apiInstance = new AlipayEbppInvoiceExpensesceneMerchantApi(config);

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

            var accountId = 2088xxx;  // string | 共同账户ID (optional) 
            var agreementNo = 20215713002876184996;  // string | 授权签约协议号 (optional) 
            var enterpriseId = 2088xxx;  // string | 企业ID (optional) 
            var roleId = 2088xxx;  // string | 商户ID (optional) 
            var pid = 2088xxx;  // string | 商户ID (optional) 
            var shopId = 2088xxx;  // string | 门店ID (optional) 
            var expenseType = MEAL;  // string | 费用类型 MEAL - 工作餐 (optional) 
            var pageNum = 1;  // int? | 页码 (optional) 
            var pageSize = 20;  // int? | 每页行数（最大100） (optional) 

            try
            {
                // 查询企业可用商户信息
                AlipayEbppInvoiceExpensesceneMerchantQueryResponseModel result = apiInstance.Query(accountId, agreementNo, enterpriseId, roleId, pid, shopId, expenseType, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensesceneMerchantApi.Query: " + e.Message );
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
 **accountId** | **string**| 共同账户ID | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **enterpriseId** | **string**| 企业ID | [optional] 
 **roleId** | **string**| 商户ID | [optional] 
 **pid** | **string**| 商户ID | [optional] 
 **shopId** | **string**| 门店ID | [optional] 
 **expenseType** | **string**| 费用类型 MEAL - 工作餐 | [optional] 
 **pageNum** | **int?**| 页码 | [optional] 
 **pageSize** | **int?**| 每页行数（最大100） | [optional] 

### Return type

**AlipayEbppInvoiceExpensesceneMerchantQueryResponseModel**

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

