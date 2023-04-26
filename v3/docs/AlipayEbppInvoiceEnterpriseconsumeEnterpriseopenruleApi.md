# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.md#create) | **POST** /v3/alipay/ebpp/invoice/enterpriseconsume/enterpriseopenrule/create | 新增开票规则
[**Modify**](AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.md#modify) | **POST** /v3/alipay/ebpp/invoice/enterpriseconsume/enterpriseopenrule/modify | 修改开票规则
[**Query**](AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.md#query) | **GET** /v3/alipay/ebpp/invoice/enterpriseconsume/enterpriseopenrule/query | 查询开票规则


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel Create (AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel = null)

新增开票规则

新增一条开票规则配置

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi(config);

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

            var alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel = new AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel(); // AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel |  (optional) 

            try
            {
                // 新增开票规则
                AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.Create: " + e.Message );
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
 **alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel** | **AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel**

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

<a name="modify"></a>
# **Modify**
> AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel Modify (AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel = null)

修改开票规则

修改开票规则

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
    public class ModifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi(config);

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

            var alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel = new AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel(); // AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel |  (optional) 

            try
            {
                // 修改开票规则
                AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel result = apiInstance.Modify(alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.Modify: " + e.Message );
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
 **alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel** | **AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel**

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

<a name="query"></a>
# **Query**
> AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel Query (string enterpriseId = null, string invoiceRuleId = null, string accountId = null, string agreementNo = null)

查询开票规则

根据开票规则ID查询开票规则详情

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi(config);

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

            var enterpriseId = 2088000000000;  // string | 企业id (optional) 
            var invoiceRuleId = 2021032900152710950000000001;  // string | 开票规则ID (optional) 
            var accountId = 2088000194958956;  // string | 共同账户id (optional) 
            var agreementNo = 20215425001112341234;  // string | 授权签约协议号（仅使用account_id时必传） (optional) 

            try
            {
                // 查询开票规则
                AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel result = apiInstance.Query(enterpriseId, invoiceRuleId, accountId, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id | [optional] 
 **invoiceRuleId** | **string**| 开票规则ID | [optional] 
 **accountId** | **string**| 共同账户id | [optional] 
 **agreementNo** | **string**| 授权签约协议号（仅使用account_id时必传） | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel**

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

