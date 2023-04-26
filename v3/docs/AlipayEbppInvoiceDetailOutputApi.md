# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceDetailOutputApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceDetailOutputApi.md#query) | **POST** /v3/alipay/ebpp/invoice/detail/output/query | 获取发票详细信息


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceDetailOutputQueryResponseModel Query (AlipayEbppInvoiceDetailOutputQueryModel alipayEbppInvoiceDetailOutputQueryModel = null)

获取发票详细信息

根据发票代码，发票号码获取发票详细信息  查询权限要求：  发票属于当前isv报销单据进行状态（支持的状态有  EXPENSE_APPLY－用户已提交申请  EXPENSE_APPROVAL_PASS －报销审核通过  EXPENSE_FINISHED－报销完结）

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
            var apiInstance = new AlipayEbppInvoiceDetailOutputApi(config);

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

            var alipayEbppInvoiceDetailOutputQueryModel = new AlipayEbppInvoiceDetailOutputQueryModel(); // AlipayEbppInvoiceDetailOutputQueryModel |  (optional) 

            try
            {
                // 获取发票详细信息
                AlipayEbppInvoiceDetailOutputQueryResponseModel result = apiInstance.Query(alipayEbppInvoiceDetailOutputQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceDetailOutputApi.Query: " + e.Message );
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
 **alipayEbppInvoiceDetailOutputQueryModel** | **AlipayEbppInvoiceDetailOutputQueryModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceDetailOutputQueryResponseModel**

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

