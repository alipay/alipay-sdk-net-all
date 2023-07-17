# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityDeliveryApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayMarketingActivityDeliveryApi.md#create) | **POST** /v3/alipay/marketing/delivery | 创建推广计划
[**Query**](AlipayMarketingActivityDeliveryApi.md#query) | **POST** /v3/alipay/marketing/delivery/{delivery_id}/query | 查询推广计划
[**Stop**](AlipayMarketingActivityDeliveryApi.md#stop) | **PATCH** /v3/alipay/marketing/delivery/{delivery_id}/stop | 停止推广计划


<a name="create"></a>
# **Create**
> AlipayMarketingActivityDeliveryCreateResponseModel Create (AlipayMarketingActivityDeliveryCreateModel alipayMarketingActivityDeliveryCreateModel = null)

创建推广计划

为商家提供推广内容能力。创建推广成功后，请依据推广变更消息alipay.marketing.activity.delivery.message感知推广变更状态。

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
            var apiInstance = new AlipayMarketingActivityDeliveryApi(config);

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

            var alipayMarketingActivityDeliveryCreateModel = new AlipayMarketingActivityDeliveryCreateModel(); // AlipayMarketingActivityDeliveryCreateModel |  (optional) 

            try
            {
                // 创建推广计划
                AlipayMarketingActivityDeliveryCreateResponseModel result = apiInstance.Create(alipayMarketingActivityDeliveryCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityDeliveryApi.Create: " + e.Message );
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
 **alipayMarketingActivityDeliveryCreateModel** | **AlipayMarketingActivityDeliveryCreateModel**|  | [optional] 

### Return type

**AlipayMarketingActivityDeliveryCreateResponseModel**

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
> AlipayMarketingActivityDeliveryQueryResponseModel Query (string deliveryId, AlipayMarketingActivityDeliveryQueryModel alipayMarketingActivityDeliveryQueryModel = null)

查询推广计划

查询推广计划详情信息。

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
            var apiInstance = new AlipayMarketingActivityDeliveryApi(config);

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

            var deliveryId = 20121231231242353;  // string | 推广计划id
            var alipayMarketingActivityDeliveryQueryModel = new AlipayMarketingActivityDeliveryQueryModel(); // AlipayMarketingActivityDeliveryQueryModel |  (optional) 

            try
            {
                // 查询推广计划
                AlipayMarketingActivityDeliveryQueryResponseModel result = apiInstance.Query(deliveryId, alipayMarketingActivityDeliveryQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityDeliveryApi.Query: " + e.Message );
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
 **deliveryId** | **string**| 推广计划id | 
 **alipayMarketingActivityDeliveryQueryModel** | **AlipayMarketingActivityDeliveryQueryModel**|  | [optional] 

### Return type

**AlipayMarketingActivityDeliveryQueryResponseModel**

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

<a name="stop"></a>
# **Stop**
> AlipayMarketingActivityDeliveryStopResponseModel Stop (string deliveryId, AlipayMarketingActivityDeliveryStopModel alipayMarketingActivityDeliveryStopModel = null)

停止推广计划

停止推广计划。  注意：停止推广操作成功到推广内容停止生效，可能存在几分钟的延迟。

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
    public class StopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityDeliveryApi(config);

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

            var deliveryId = 20121231231242353;  // string | 推广计划id
            var alipayMarketingActivityDeliveryStopModel = new AlipayMarketingActivityDeliveryStopModel(); // AlipayMarketingActivityDeliveryStopModel |  (optional) 

            try
            {
                // 停止推广计划
                AlipayMarketingActivityDeliveryStopResponseModel result = apiInstance.Stop(deliveryId, alipayMarketingActivityDeliveryStopModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityDeliveryApi.Stop: " + e.Message );
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
 **deliveryId** | **string**| 推广计划id | 
 **alipayMarketingActivityDeliveryStopModel** | **AlipayMarketingActivityDeliveryStopModel**|  | [optional] 

### Return type

**AlipayMarketingActivityDeliveryStopResponseModel**

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

