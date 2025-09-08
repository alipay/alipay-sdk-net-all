# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.md#batchquery) | **POST** /v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle/batchquery | 企业抬头：分页查询企业抬头信息
[**Create**](AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.md#create) | **POST** /v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle/create | 企业抬头：新增企业抬头
[**Modify**](AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.md#modify) | **PUT** /v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle | 企业抬头：修改企业抬头
[**Query**](AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.md#query) | **GET** /v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle/query | 企业抬头：查询企业抬头


<a name="batchquery"></a>
# **Batchquery**
> AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel Batchquery (AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel = null)

企业抬头：分页查询企业抬头信息

分页查询企业抬头列表

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(config);

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

            var alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel(); // AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel |  (optional) 

            try
            {
                // 企业抬头：分页查询企业抬头信息
                AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel result = apiInstance.Batchquery(alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Batchquery: " + e.Message );
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
 **alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel** | **AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel**

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

<a name="create"></a>
# **Create**
> AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel Create (AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel = null)

企业抬头：新增企业抬头

新增一条企业开票抬头

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(config);

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

            var alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel(); // AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel |  (optional) 

            try
            {
                // 企业抬头：新增企业抬头
                AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Create: " + e.Message );
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
 **alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel** | **AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel**

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
> AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel Modify (AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel = null)

企业抬头：修改企业抬头

修改企业开票抬头

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(config);

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

            var alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel(); // AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel |  (optional) 

            try
            {
                // 企业抬头：修改企业抬头
                AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel result = apiInstance.Modify(alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Modify: " + e.Message );
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
 **alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel** | **AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel**

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
> AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel Query (string accountId = null, string enterpriseId = null, string agreementNo = null, string titleId = null, string taxRegisterNo = null)

企业抬头：查询企业抬头

根据抬头ID查询企业抬头详情

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
            var apiInstance = new AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(config);

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
            var enterpriseId = 2088123412341234;  // string | 企业id (optional) 
            var agreementNo = 20215425001181407500;  // string | 授权签约协议号 (optional) 
            var titleId = 2022110200152710030000000003;  // string | 抬头ID (optional) 
            var taxRegisterNo = 9133*********5852F;  // string | 税号 (optional) 

            try
            {
                // 企业抬头：查询企业抬头
                AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel result = apiInstance.Query(accountId, enterpriseId, agreementNo, titleId, taxRegisterNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id | [optional] 
 **agreementNo** | **string**| 授权签约协议号 | [optional] 
 **titleId** | **string**| 抬头ID | [optional] 
 **taxRegisterNo** | **string**| 税号 | [optional] 

### Return type

**AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel**

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

