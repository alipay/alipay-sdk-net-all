# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceInstitutionPageinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceInstitutionPageinfoApi.md#query) | **GET** /v3/alipay/ebpp/invoice/institution/pageinfo/query | 费控制度分页查询


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceInstitutionPageinfoQueryResponseModel Query (string accountId = null, string agreementNo = null, string enterpriseId = null, int? pageNum = null, int? pageSize = null)

费控制度分页查询

制度分页查询，返回制度基本信息

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
            var apiInstance = new AlipayEbppInvoiceInstitutionPageinfoApi(config);

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

            var accountId = 2088000194958956;  // string | 企业共同账户id (optional) 
            var agreementNo = 20215425001112341234;  // string | 授权签约协议号 (optional) 
            var enterpriseId = 2088000194958956;  // string | 企业ID (optional) 
            var pageNum = 10;  // int? | 页码 (optional) 
            var pageSize = 100;  // int? | 页大小 (optional) 

            try
            {
                // 费控制度分页查询
                AlipayEbppInvoiceInstitutionPageinfoQueryResponseModel result = apiInstance.Query(accountId, agreementNo, enterpriseId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceInstitutionPageinfoApi.Query: " + e.Message );
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
 **accountId** | **string**| 企业共同账户id | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **enterpriseId** | **string**| 企业ID | [optional] 
 **pageNum** | **int?**| 页码 | [optional] 
 **pageSize** | **int?**| 页大小 | [optional] 

### Return type

**AlipayEbppInvoiceInstitutionPageinfoQueryResponseModel**

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

