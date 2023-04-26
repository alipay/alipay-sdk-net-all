# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcEnterpriseApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayCommerceEcEnterpriseApi.md#create) | **POST** /v3/alipay/commerce/ec/enterprise/create | 企业入驻
[**Delete**](AlipayCommerceEcEnterpriseApi.md#delete) | **POST** /v3/alipay/commerce/ec/enterprise/delete | 企业注销
[**Unsign**](AlipayCommerceEcEnterpriseApi.md#unsign) | **GET** /v3/alipay/commerce/ec/enterprise/unsignurl | 企业解约


<a name="create"></a>
# **Create**
> AlipayCommerceEcEnterpriseCreateResponseModel Create (AlipayCommerceEcEnterpriseCreateModel alipayCommerceEcEnterpriseCreateModel = null)

企业入驻

企业入驻，并返回签约链接

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
            var apiInstance = new AlipayCommerceEcEnterpriseApi(config);

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

            var alipayCommerceEcEnterpriseCreateModel = new AlipayCommerceEcEnterpriseCreateModel(); // AlipayCommerceEcEnterpriseCreateModel |  (optional) 

            try
            {
                // 企业入驻
                AlipayCommerceEcEnterpriseCreateResponseModel result = apiInstance.Create(alipayCommerceEcEnterpriseCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseApi.Create: " + e.Message );
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
 **alipayCommerceEcEnterpriseCreateModel** | **AlipayCommerceEcEnterpriseCreateModel**|  | [optional] 

### Return type

**AlipayCommerceEcEnterpriseCreateResponseModel**

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
> AlipayCommerceEcEnterpriseDeleteResponseModel Delete (AlipayCommerceEcEnterpriseDeleteModel alipayCommerceEcEnterpriseDeleteModel = null)

企业注销

企业注销，清理企业数据

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
            var apiInstance = new AlipayCommerceEcEnterpriseApi(config);

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

            var alipayCommerceEcEnterpriseDeleteModel = new AlipayCommerceEcEnterpriseDeleteModel(); // AlipayCommerceEcEnterpriseDeleteModel |  (optional) 

            try
            {
                // 企业注销
                AlipayCommerceEcEnterpriseDeleteResponseModel result = apiInstance.Delete(alipayCommerceEcEnterpriseDeleteModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseApi.Delete: " + e.Message );
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
 **alipayCommerceEcEnterpriseDeleteModel** | **AlipayCommerceEcEnterpriseDeleteModel**|  | [optional] 

### Return type

**AlipayCommerceEcEnterpriseDeleteResponseModel**

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

<a name="unsign"></a>
# **Unsign**
> AlipayCommerceEcEnterpriseUnsignResponseModel Unsign (string enterpriseId = null, string accountId = null, string agreementNo = null)

企业解约

企业解约，获取解约链接，点击链接跳转到解约页面，进行解约协议

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
    public class UnsignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceEcEnterpriseApi(config);

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

            var enterpriseId = 208893900430;  // string | 企业id (optional) 
            var accountId = 208849300303;  // string | 共同账户id和企业id二选一必填 (optional) 
            var agreementNo = 29300309290200200;  // string | 签约协议号，account_id不为空则该字段必填 (optional) 

            try
            {
                // 企业解约
                AlipayCommerceEcEnterpriseUnsignResponseModel result = apiInstance.Unsign(enterpriseId, accountId, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseApi.Unsign: " + e.Message );
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
 **accountId** | **string**| 共同账户id和企业id二选一必填 | [optional] 
 **agreementNo** | **string**| 签约协议号，account_id不为空则该字段必填 | [optional] 

### Return type

**AlipayCommerceEcEnterpriseUnsignResponseModel**

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

