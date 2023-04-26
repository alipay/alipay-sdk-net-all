# AlipaySDKNet.OpenAPI.Api.AlipayOpenSpIsvSignauthApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayOpenSpIsvSignauthApi.md#create) | **POST** /v3/alipay/open/sp/isv/signauth/create | 创建签约授权一体化订单
[**Query**](AlipayOpenSpIsvSignauthApi.md#query) | **GET** /v3/alipay/open/sp/isv/signauth/query | 查询签约授权一体化订单状态详情


<a name="create"></a>
# **Create**
> AlipayOpenSpIsvSignauthCreateResponseModel Create (AlipayOpenSpIsvSignauthCreateModel alipayOpenSpIsvSignauthCreateModel = null)

创建签约授权一体化订单

针对签约授权一体化场景，创建签约授权一体化订单绑定签约单（可选）、绑定代运营授权单、应用授权单，跟踪整个签约授权一体化订单的状态

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
            var apiInstance = new AlipayOpenSpIsvSignauthApi(config);

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

            var alipayOpenSpIsvSignauthCreateModel = new AlipayOpenSpIsvSignauthCreateModel(); // AlipayOpenSpIsvSignauthCreateModel |  (optional) 

            try
            {
                // 创建签约授权一体化订单
                AlipayOpenSpIsvSignauthCreateResponseModel result = apiInstance.Create(alipayOpenSpIsvSignauthCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSpIsvSignauthApi.Create: " + e.Message );
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
 **alipayOpenSpIsvSignauthCreateModel** | **AlipayOpenSpIsvSignauthCreateModel**|  | [optional] 

### Return type

**AlipayOpenSpIsvSignauthCreateResponseModel**

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
> AlipayOpenSpIsvSignauthQueryResponseModel Query (string orderId = null)

查询签约授权一体化订单状态详情

查询签约授权一体化订单状态详情（包含子任务信息）

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
            var apiInstance = new AlipayOpenSpIsvSignauthApi(config);

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

            var orderId = 20211102034000100000047728652040;  // string | 签约授权一体化订单ID 可通过alipay.open.sp.isv.signauth.create 接口获取 (optional) 

            try
            {
                // 查询签约授权一体化订单状态详情
                AlipayOpenSpIsvSignauthQueryResponseModel result = apiInstance.Query(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSpIsvSignauthApi.Query: " + e.Message );
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
 **orderId** | **string**| 签约授权一体化订单ID 可通过alipay.open.sp.isv.signauth.create 接口获取 | [optional] 

### Return type

**AlipayOpenSpIsvSignauthQueryResponseModel**

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

