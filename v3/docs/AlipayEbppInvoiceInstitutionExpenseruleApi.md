# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceInstitutionExpenseruleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEbppInvoiceInstitutionExpenseruleApi.md#create) | **POST** /v3/alipay/ebpp/invoice/institution/expenserule/create | 创建费控使用规则
[**Delete**](AlipayEbppInvoiceInstitutionExpenseruleApi.md#delete) | **POST** /v3/alipay/ebpp/invoice/institution/expenserule/delete | 删除使用规则
[**Modify**](AlipayEbppInvoiceInstitutionExpenseruleApi.md#modify) | **POST** /v3/alipay/ebpp/invoice/institution/expenserule/modify | 编辑使用规则


<a name="create"></a>
# **Create**
> AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel Create (AlipayEbppInvoiceInstitutionExpenseruleCreateModel alipayEbppInvoiceInstitutionExpenseruleCreateModel = null)

创建费控使用规则

创建费控使用规则

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
            var apiInstance = new AlipayEbppInvoiceInstitutionExpenseruleApi(config);

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

            var alipayEbppInvoiceInstitutionExpenseruleCreateModel = new AlipayEbppInvoiceInstitutionExpenseruleCreateModel(); // AlipayEbppInvoiceInstitutionExpenseruleCreateModel |  (optional) 

            try
            {
                // 创建费控使用规则
                AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceInstitutionExpenseruleCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceInstitutionExpenseruleApi.Create: " + e.Message );
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
 **alipayEbppInvoiceInstitutionExpenseruleCreateModel** | **AlipayEbppInvoiceInstitutionExpenseruleCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceInstitutionExpenseruleCreateResponseModel**

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

<a name="delete"></a>
# **Delete**
> AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel Delete (AlipayEbppInvoiceInstitutionExpenseruleDeleteModel alipayEbppInvoiceInstitutionExpenseruleDeleteModel = null)

删除使用规则

删除制度下使用规则

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
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceInstitutionExpenseruleApi(config);

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

            var alipayEbppInvoiceInstitutionExpenseruleDeleteModel = new AlipayEbppInvoiceInstitutionExpenseruleDeleteModel(); // AlipayEbppInvoiceInstitutionExpenseruleDeleteModel |  (optional) 

            try
            {
                // 删除使用规则
                AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel result = apiInstance.Delete(alipayEbppInvoiceInstitutionExpenseruleDeleteModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceInstitutionExpenseruleApi.Delete: " + e.Message );
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
 **alipayEbppInvoiceInstitutionExpenseruleDeleteModel** | **AlipayEbppInvoiceInstitutionExpenseruleDeleteModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel**

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
> AlipayEbppInvoiceInstitutionExpenseruleModifyResponseModel Modify (AlipayEbppInvoiceInstitutionExpenseruleModifyModel alipayEbppInvoiceInstitutionExpenseruleModifyModel = null)

编辑使用规则

编辑制度下的使用规则

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
            var apiInstance = new AlipayEbppInvoiceInstitutionExpenseruleApi(config);

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

            var alipayEbppInvoiceInstitutionExpenseruleModifyModel = new AlipayEbppInvoiceInstitutionExpenseruleModifyModel(); // AlipayEbppInvoiceInstitutionExpenseruleModifyModel |  (optional) 

            try
            {
                // 编辑使用规则
                AlipayEbppInvoiceInstitutionExpenseruleModifyResponseModel result = apiInstance.Modify(alipayEbppInvoiceInstitutionExpenseruleModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceInstitutionExpenseruleApi.Modify: " + e.Message );
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
 **alipayEbppInvoiceInstitutionExpenseruleModifyModel** | **AlipayEbppInvoiceInstitutionExpenseruleModifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceInstitutionExpenseruleModifyResponseModel**

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

