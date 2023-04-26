# AlipaySDKNet.OpenAPI.Api.AlipayBossFncUserinvoiceinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayBossFncUserinvoiceinfoApi.md#create) | **POST** /v3/alipay/boss/fnc/userinvoiceinfo/create | 新增客户开票资料
[**Modify**](AlipayBossFncUserinvoiceinfoApi.md#modify) | **POST** /v3/alipay/boss/fnc/userinvoiceinfo/modify | 修改用户开票资料
[**Query**](AlipayBossFncUserinvoiceinfoApi.md#query) | **GET** /v3/alipay/boss/fnc/userinvoiceinfo/query | 根据PID获取相关的开票资料


<a name="create"></a>
# **Create**
> AlipayBossFncUserinvoiceinfoCreateResponseModel Create (AlipayBossFncUserinvoiceinfoCreateModel alipayBossFncUserinvoiceinfoCreateModel = null)

新增客户开票资料

申请开票alipay.boss.fnc.invoice.create之前需要维护的开票资料信息

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
            var apiInstance = new AlipayBossFncUserinvoiceinfoApi(config);

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

            var alipayBossFncUserinvoiceinfoCreateModel = new AlipayBossFncUserinvoiceinfoCreateModel(); // AlipayBossFncUserinvoiceinfoCreateModel |  (optional) 

            try
            {
                // 新增客户开票资料
                AlipayBossFncUserinvoiceinfoCreateResponseModel result = apiInstance.Create(alipayBossFncUserinvoiceinfoCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncUserinvoiceinfoApi.Create: " + e.Message );
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
 **alipayBossFncUserinvoiceinfoCreateModel** | **AlipayBossFncUserinvoiceinfoCreateModel**|  | [optional] 

### Return type

**AlipayBossFncUserinvoiceinfoCreateResponseModel**

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
> Object Modify (AlipayBossFncUserinvoiceinfoModifyModel alipayBossFncUserinvoiceinfoModifyModel = null)

修改用户开票资料

通过查询用户的开票资料（alipay.boss.fnc.userinvoiceinfo.query）后进行开票资料的修改

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
            var apiInstance = new AlipayBossFncUserinvoiceinfoApi(config);

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

            var alipayBossFncUserinvoiceinfoModifyModel = new AlipayBossFncUserinvoiceinfoModifyModel(); // AlipayBossFncUserinvoiceinfoModifyModel |  (optional) 

            try
            {
                // 修改用户开票资料
                Object result = apiInstance.Modify(alipayBossFncUserinvoiceinfoModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncUserinvoiceinfoApi.Modify: " + e.Message );
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
 **alipayBossFncUserinvoiceinfoModifyModel** | **AlipayBossFncUserinvoiceinfoModifyModel**|  | [optional] 

### Return type

**Object**

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
> AlipayBossFncUserinvoiceinfoQueryResponseModel Query (string pid = null)

根据PID获取相关的开票资料

根据PID获取相关的开票资料

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
            var apiInstance = new AlipayBossFncUserinvoiceinfoApi(config);

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

            var pid = 2088001007243670;  // string | 开票pid/mid/ou，唯一标识商户信息/集团用户信息的ID (optional) 

            try
            {
                // 根据PID获取相关的开票资料
                AlipayBossFncUserinvoiceinfoQueryResponseModel result = apiInstance.Query(pid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayBossFncUserinvoiceinfoApi.Query: " + e.Message );
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
 **pid** | **string**| 开票pid/mid/ou，唯一标识商户信息/集团用户信息的ID | [optional] 

### Return type

**AlipayBossFncUserinvoiceinfoQueryResponseModel**

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

