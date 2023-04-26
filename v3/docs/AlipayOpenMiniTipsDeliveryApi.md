# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniTipsDeliveryApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenMiniTipsDeliveryApi.md#batchquery) | **POST** /v3/alipay/open/mini/tips/delivery/batchquery | 小程序收藏引导投放活动配置批量查询
[**Create**](AlipayOpenMiniTipsDeliveryApi.md#create) | **POST** /v3/alipay/open/mini/tips/delivery/create | 小程序收藏引导投放活动配置创建
[**Modify**](AlipayOpenMiniTipsDeliveryApi.md#modify) | **POST** /v3/alipay/open/mini/tips/delivery/modify | 小程序收藏引导投放活动修改
[**Query**](AlipayOpenMiniTipsDeliveryApi.md#query) | **GET** /v3/alipay/open/mini/tips/delivery/query | 小程序收藏引导投放活动详情查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenMiniTipsDeliveryBatchqueryResponseModel Batchquery (AlipayOpenMiniTipsDeliveryBatchqueryModel alipayOpenMiniTipsDeliveryBatchqueryModel = null)

小程序收藏引导投放活动配置批量查询

小程序收藏引导投放活动配置批量查询接口，获取该小程序下所有活动配置及状态信息。

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
            var apiInstance = new AlipayOpenMiniTipsDeliveryApi(config);

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

            var alipayOpenMiniTipsDeliveryBatchqueryModel = new AlipayOpenMiniTipsDeliveryBatchqueryModel(); // AlipayOpenMiniTipsDeliveryBatchqueryModel |  (optional) 

            try
            {
                // 小程序收藏引导投放活动配置批量查询
                AlipayOpenMiniTipsDeliveryBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenMiniTipsDeliveryBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniTipsDeliveryApi.Batchquery: " + e.Message );
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
 **alipayOpenMiniTipsDeliveryBatchqueryModel** | **AlipayOpenMiniTipsDeliveryBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenMiniTipsDeliveryBatchqueryResponseModel**

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
> AlipayOpenMiniTipsDeliveryCreateResponseModel Create (AlipayOpenMiniTipsDeliveryCreateModel alipayOpenMiniTipsDeliveryCreateModel = null)

小程序收藏引导投放活动配置创建

小程序收藏引导投放活动配置创建。通过配置有效的小程序收藏引导（tips）文案，创建小程序收藏引导活动。用户在活动有效期内等于相应页面，将展示配置的个性化文案，帮助用户收藏小程序。请结合您的小程序及页面，配置个性化文案。 

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
            var apiInstance = new AlipayOpenMiniTipsDeliveryApi(config);

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

            var alipayOpenMiniTipsDeliveryCreateModel = new AlipayOpenMiniTipsDeliveryCreateModel(); // AlipayOpenMiniTipsDeliveryCreateModel |  (optional) 

            try
            {
                // 小程序收藏引导投放活动配置创建
                AlipayOpenMiniTipsDeliveryCreateResponseModel result = apiInstance.Create(alipayOpenMiniTipsDeliveryCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniTipsDeliveryApi.Create: " + e.Message );
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
 **alipayOpenMiniTipsDeliveryCreateModel** | **AlipayOpenMiniTipsDeliveryCreateModel**|  | [optional] 

### Return type

**AlipayOpenMiniTipsDeliveryCreateResponseModel**

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
> Object Modify (AlipayOpenMiniTipsDeliveryModifyModel alipayOpenMiniTipsDeliveryModifyModel = null)

小程序收藏引导投放活动修改

小程序收藏引导投放活动修改接口，目前支持活动状态的修改，包括暂停、恢复、终止单个收藏引导活动。

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
            var apiInstance = new AlipayOpenMiniTipsDeliveryApi(config);

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

            var alipayOpenMiniTipsDeliveryModifyModel = new AlipayOpenMiniTipsDeliveryModifyModel(); // AlipayOpenMiniTipsDeliveryModifyModel |  (optional) 

            try
            {
                // 小程序收藏引导投放活动修改
                Object result = apiInstance.Modify(alipayOpenMiniTipsDeliveryModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniTipsDeliveryApi.Modify: " + e.Message );
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
 **alipayOpenMiniTipsDeliveryModifyModel** | **AlipayOpenMiniTipsDeliveryModifyModel**|  | [optional] 

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
> AlipayOpenMiniTipsDeliveryQueryResponseModel Query (string deliveryId = null)

小程序收藏引导投放活动详情查询

小程序收藏引导投放活动配置详情查询接口，获取当前活动ID对应活动的配置及状态信息。

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
            var apiInstance = new AlipayOpenMiniTipsDeliveryApi(config);

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

            var deliveryId = 20211114000003057595;  // string | 收藏引导投放活动ID，查询收藏引导活动必填参数 (optional) 

            try
            {
                // 小程序收藏引导投放活动详情查询
                AlipayOpenMiniTipsDeliveryQueryResponseModel result = apiInstance.Query(deliveryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniTipsDeliveryApi.Query: " + e.Message );
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
 **deliveryId** | **string**| 收藏引导投放活动ID，查询收藏引导活动必填参数 | [optional] 

### Return type

**AlipayOpenMiniTipsDeliveryQueryResponseModel**

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

