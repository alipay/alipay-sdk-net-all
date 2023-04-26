# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniIsvApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayOpenMiniIsvApi.md#create) | **POST** /v3/alipay/open/mini/isv/create | isv服务商代商户创建小程序
[**Query**](AlipayOpenMiniIsvApi.md#query) | **GET** /v3/alipay/open/mini/isv/query | isv查询代商家创建小程序记录


<a name="create"></a>
# **Create**
> AlipayOpenMiniIsvCreateResponseModel Create (AlipayOpenMiniIsvCreateModel alipayOpenMiniIsvCreateModel = null)

isv服务商代商户创建小程序

服务商代商家创建小程序，待商家确认后服务商代创建的小程序才会生效，若商家超过确认时间则服务商创建的小程序会自动作废释放占用的小程序名称。 将 is_individual 设置为 true，并且同时传入 license_pic。将同时对具备个体工商户营业执照的商家个人账号认证成为个体工商户账号（创建小程序+升级个体工商户账号一体化）。

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
            var apiInstance = new AlipayOpenMiniIsvApi(config);

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

            var alipayOpenMiniIsvCreateModel = new AlipayOpenMiniIsvCreateModel(); // AlipayOpenMiniIsvCreateModel |  (optional) 

            try
            {
                // isv服务商代商户创建小程序
                AlipayOpenMiniIsvCreateResponseModel result = apiInstance.Create(alipayOpenMiniIsvCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniIsvApi.Create: " + e.Message );
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
 **alipayOpenMiniIsvCreateModel** | **AlipayOpenMiniIsvCreateModel**|  | [optional] 

### Return type

**AlipayOpenMiniIsvCreateResponseModel**

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
> AlipayOpenMiniIsvQueryResponseModel Query (string orderNo = null)

isv查询代商家创建小程序记录

isv查询代商家创建小程序记录

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
            var apiInstance = new AlipayOpenMiniIsvApi(config);

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

            var orderNo = 2394834823942343;  // string | 服务商代商家创建小程序，由支付宝开放平台返回的订单号用于后续查询处理进展。 (optional) 

            try
            {
                // isv查询代商家创建小程序记录
                AlipayOpenMiniIsvQueryResponseModel result = apiInstance.Query(orderNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniIsvApi.Query: " + e.Message );
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
 **orderNo** | **string**| 服务商代商家创建小程序，由支付宝开放平台返回的订单号用于后续查询处理进展。 | [optional] 

### Return type

**AlipayOpenMiniIsvQueryResponseModel**

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

