# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceInstitutionScopepageinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceInstitutionScopepageinfoApi.md#query) | **GET** /v3/alipay/ebpp/invoice/institution/scopepageinfo/query | 分页查询制度下人员


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceInstitutionScopepageinfoQueryResponseModel Query (string accountId = null, string agreementNo = null, string enterpriseId = null, string institutionId = null, string ownerType = null, int? pageNum = null, int? pageSize = null)

分页查询制度下人员

分页查询制度下适用范围列表

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
            var apiInstance = new AlipayEbppInvoiceInstitutionScopepageinfoApi(config);

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
            var enterpriseId = 2088000194958956;  // string | 企业id (optional) 
            var institutionId = 2022071800152609780000004052;  // string | 制度id (optional) 
            var ownerType = PHONE;  // string | 适配id类型 (optional) 
            var pageNum = 10;  // int? | 页码 (optional) 
            var pageSize = 100;  // int? | 页大小 (optional) 

            try
            {
                // 分页查询制度下人员
                AlipayEbppInvoiceInstitutionScopepageinfoQueryResponseModel result = apiInstance.Query(accountId, agreementNo, enterpriseId, institutionId, ownerType, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceInstitutionScopepageinfoApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id | [optional] 
 **institutionId** | **string**| 制度id | [optional] 
 **ownerType** | **string**| 适配id类型 | [optional] 
 **pageNum** | **int?**| 页码 | [optional] 
 **pageSize** | **int?**| 页大小 | [optional] 

### Return type

**AlipayEbppInvoiceInstitutionScopepageinfoQueryResponseModel**

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

