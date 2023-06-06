# AlipaySDKNet.OpenAPI.Api.AlipayCommerceLogisticsOrderInstantdeliveryApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Cancel**](AlipayCommerceLogisticsOrderInstantdeliveryApi.md#cancel) | **POST** /v3/alipay/commerce/logistics/order/instantdelivery/cancel | 取消即时配送订单
[**Create**](AlipayCommerceLogisticsOrderInstantdeliveryApi.md#create) | **POST** /v3/alipay/commerce/logistics/order/instantdelivery/create | 下即时配送订单
[**Precreate**](AlipayCommerceLogisticsOrderInstantdeliveryApi.md#precreate) | **POST** /v3/alipay/commerce/logistics/order/instantdelivery/precreate | 预下即时配送订单


<a name="cancel"></a>
# **Cancel**
> AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel Cancel (AlipayCommerceLogisticsOrderInstantdeliveryCancelModel alipayCommerceLogisticsOrderInstantdeliveryCancelModel = null)

取消即时配送订单

取消即时配送订单

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
    public class CancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceLogisticsOrderInstantdeliveryApi(config);

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

            var alipayCommerceLogisticsOrderInstantdeliveryCancelModel = new AlipayCommerceLogisticsOrderInstantdeliveryCancelModel(); // AlipayCommerceLogisticsOrderInstantdeliveryCancelModel |  (optional) 

            try
            {
                // 取消即时配送订单
                AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel result = apiInstance.Cancel(alipayCommerceLogisticsOrderInstantdeliveryCancelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsOrderInstantdeliveryApi.Cancel: " + e.Message );
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
 **alipayCommerceLogisticsOrderInstantdeliveryCancelModel** | **AlipayCommerceLogisticsOrderInstantdeliveryCancelModel**|  | [optional] 

### Return type

**AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel**

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
> AlipayCommerceLogisticsOrderInstantdeliveryCreateResponseModel Create (AlipayCommerceLogisticsOrderInstantdeliveryCreateModel alipayCommerceLogisticsOrderInstantdeliveryCreateModel = null)

下即时配送订单

下即时配送订单

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
            var apiInstance = new AlipayCommerceLogisticsOrderInstantdeliveryApi(config);

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

            var alipayCommerceLogisticsOrderInstantdeliveryCreateModel = new AlipayCommerceLogisticsOrderInstantdeliveryCreateModel(); // AlipayCommerceLogisticsOrderInstantdeliveryCreateModel |  (optional) 

            try
            {
                // 下即时配送订单
                AlipayCommerceLogisticsOrderInstantdeliveryCreateResponseModel result = apiInstance.Create(alipayCommerceLogisticsOrderInstantdeliveryCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsOrderInstantdeliveryApi.Create: " + e.Message );
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
 **alipayCommerceLogisticsOrderInstantdeliveryCreateModel** | **AlipayCommerceLogisticsOrderInstantdeliveryCreateModel**|  | [optional] 

### Return type

**AlipayCommerceLogisticsOrderInstantdeliveryCreateResponseModel**

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

<a name="precreate"></a>
# **Precreate**
> AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponseModel Precreate (AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel alipayCommerceLogisticsOrderInstantdeliveryPrecreateModel = null)

预下即时配送订单

预下即时配送订单

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
    public class PrecreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceLogisticsOrderInstantdeliveryApi(config);

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

            var alipayCommerceLogisticsOrderInstantdeliveryPrecreateModel = new AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel(); // AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel |  (optional) 

            try
            {
                // 预下即时配送订单
                AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponseModel result = apiInstance.Precreate(alipayCommerceLogisticsOrderInstantdeliveryPrecreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsOrderInstantdeliveryApi.Precreate: " + e.Message );
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
 **alipayCommerceLogisticsOrderInstantdeliveryPrecreateModel** | **AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel**|  | [optional] 

### Return type

**AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponseModel**

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

