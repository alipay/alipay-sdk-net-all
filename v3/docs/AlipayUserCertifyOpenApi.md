# AlipaySDKNet.OpenAPI.Api.AlipayUserCertifyOpenApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Initialize**](AlipayUserCertifyOpenApi.md#initialize) | **POST** /v3/alipay/user/certify/open/initialize | 身份认证初始化服务
[**Query**](AlipayUserCertifyOpenApi.md#query) | **GET** /v3/alipay/user/certify/open/query | 身份认证记录查询


<a name="initialize"></a>
# **Initialize**
> AlipayUserCertifyOpenInitializeResponseModel Initialize (AlipayUserCertifyOpenInitializeModel alipayUserCertifyOpenInitializeModel = null)

身份认证初始化服务

支付宝开放认证初始化服务，用于创建开放认证流程。注意：港澳台同胞身份验证服务仅支持在支付宝客户端内使用，外部 APP 使用该项服务需唤起支付宝客户端。

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
    public class InitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayUserCertifyOpenApi(config);

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

            var alipayUserCertifyOpenInitializeModel = new AlipayUserCertifyOpenInitializeModel(); // AlipayUserCertifyOpenInitializeModel |  (optional) 

            try
            {
                // 身份认证初始化服务
                AlipayUserCertifyOpenInitializeResponseModel result = apiInstance.Initialize(alipayUserCertifyOpenInitializeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserCertifyOpenApi.Initialize: " + e.Message );
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
 **alipayUserCertifyOpenInitializeModel** | **AlipayUserCertifyOpenInitializeModel**|  | [optional] 

### Return type

**AlipayUserCertifyOpenInitializeResponseModel**

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
> AlipayUserCertifyOpenQueryResponseModel Query (string certifyId = null)

身份认证记录查询

商户在开放认证完成后，调用本接口查询认证状态和相关数据

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
            var apiInstance = new AlipayUserCertifyOpenApi(config);

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

            var certifyId = OC201809253000000393900404029253;  // string | 本次申请操作的唯一标识，通过alipay.user.certify.open.initialize(身份认证初始化服务)接口同步响应获取。 (optional) 

            try
            {
                // 身份认证记录查询
                AlipayUserCertifyOpenQueryResponseModel result = apiInstance.Query(certifyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserCertifyOpenApi.Query: " + e.Message );
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
 **certifyId** | **string**| 本次申请操作的唯一标识，通过alipay.user.certify.open.initialize(身份认证初始化服务)接口同步响应获取。 | [optional] 

### Return type

**AlipayUserCertifyOpenQueryResponseModel**

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

