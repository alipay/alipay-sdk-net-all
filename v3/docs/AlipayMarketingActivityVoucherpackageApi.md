# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityVoucherpackageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayMarketingActivityVoucherpackageApi.md#batchquery) | **POST** /v3/alipay/marketing/activity/voucherpackage/batchquery | 券包批量查询
[**Consult**](AlipayMarketingActivityVoucherpackageApi.md#consult) | **POST** /v3/alipay/marketing/activity/voucherpackage/consult | 券包购买咨询
[**Query**](AlipayMarketingActivityVoucherpackageApi.md#query) | **GET** /v3/alipay/marketing/activity/voucherpackage/query | 券包详情查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayMarketingActivityVoucherpackageBatchqueryResponseModel Batchquery (AlipayMarketingActivityVoucherpackageBatchqueryModel alipayMarketingActivityVoucherpackageBatchqueryModel = null)

券包批量查询

券包批量查询

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
            var apiInstance = new AlipayMarketingActivityVoucherpackageApi(config);

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

            var alipayMarketingActivityVoucherpackageBatchqueryModel = new AlipayMarketingActivityVoucherpackageBatchqueryModel(); // AlipayMarketingActivityVoucherpackageBatchqueryModel |  (optional) 

            try
            {
                // 券包批量查询
                AlipayMarketingActivityVoucherpackageBatchqueryResponseModel result = apiInstance.Batchquery(alipayMarketingActivityVoucherpackageBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherpackageApi.Batchquery: " + e.Message );
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
 **alipayMarketingActivityVoucherpackageBatchqueryModel** | **AlipayMarketingActivityVoucherpackageBatchqueryModel**|  | [optional] 

### Return type

**AlipayMarketingActivityVoucherpackageBatchqueryResponseModel**

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

<a name="consult"></a>
# **Consult**
> AlipayMarketingActivityVoucherpackageConsultResponseModel Consult (string authToken = null, AlipayMarketingActivityVoucherpackageConsultModel alipayMarketingActivityVoucherpackageConsultModel = null)

券包购买咨询

券包购买咨询，咨询当前用户是否可以购买指定的券包

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
    public class ConsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityVoucherpackageApi(config);

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
            var alipayMarketingActivityVoucherpackageConsultModel = new AlipayMarketingActivityVoucherpackageConsultModel(); // AlipayMarketingActivityVoucherpackageConsultModel |  (optional) 

            try
            {
                // 券包购买咨询
                AlipayMarketingActivityVoucherpackageConsultResponseModel result = apiInstance.Consult(authToken, alipayMarketingActivityVoucherpackageConsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherpackageApi.Consult: " + e.Message );
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
 **alipayMarketingActivityVoucherpackageConsultModel** | **AlipayMarketingActivityVoucherpackageConsultModel**|  | [optional] 

### Return type

**AlipayMarketingActivityVoucherpackageConsultResponseModel**

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
> AlipayMarketingActivityVoucherpackageQueryResponseModel Query (string voucherPackageId = null)

券包详情查询

查询券包详情，包括券包信息和券包下面券信息

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
            var apiInstance = new AlipayMarketingActivityVoucherpackageApi(config);

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

            var voucherPackageId = IP20220628016671405804297103167741;  // string | 券包id (optional) 

            try
            {
                // 券包详情查询
                AlipayMarketingActivityVoucherpackageQueryResponseModel result = apiInstance.Query(voucherPackageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherpackageApi.Query: " + e.Message );
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
 **voucherPackageId** | **string**| 券包id | [optional] 

### Return type

**AlipayMarketingActivityVoucherpackageQueryResponseModel**

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

