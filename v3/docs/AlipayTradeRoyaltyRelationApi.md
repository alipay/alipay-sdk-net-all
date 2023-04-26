# AlipaySDKNet.OpenAPI.Api.AlipayTradeRoyaltyRelationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayTradeRoyaltyRelationApi.md#batchquery) | **POST** /v3/alipay/trade/royalty/relation/batchquery | 分账关系查询
[**Bind**](AlipayTradeRoyaltyRelationApi.md#bind) | **POST** /v3/alipay/trade/royalty/relation/bind | 分账关系绑定
[**Unbind**](AlipayTradeRoyaltyRelationApi.md#unbind) | **POST** /v3/alipay/trade/royalty/relation/unbind | 分账关系解绑


<a name="batchquery"></a>
# **Batchquery**
> AlipayTradeRoyaltyRelationBatchqueryResponseModel Batchquery (AlipayTradeRoyaltyRelationBatchqueryModel alipayTradeRoyaltyRelationBatchqueryModel = null)

分账关系查询

当商户签约分账产品后，授权ISV帮其进行分账关系的维护。本接口用于商户与分账方的关系查询。

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
            var apiInstance = new AlipayTradeRoyaltyRelationApi(config);

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

            var alipayTradeRoyaltyRelationBatchqueryModel = new AlipayTradeRoyaltyRelationBatchqueryModel(); // AlipayTradeRoyaltyRelationBatchqueryModel |  (optional) 

            try
            {
                // 分账关系查询
                AlipayTradeRoyaltyRelationBatchqueryResponseModel result = apiInstance.Batchquery(alipayTradeRoyaltyRelationBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeRoyaltyRelationApi.Batchquery: " + e.Message );
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
 **alipayTradeRoyaltyRelationBatchqueryModel** | **AlipayTradeRoyaltyRelationBatchqueryModel**|  | [optional] 

### Return type

**AlipayTradeRoyaltyRelationBatchqueryResponseModel**

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

<a name="bind"></a>
# **Bind**
> AlipayTradeRoyaltyRelationBindResponseModel Bind (AlipayTradeRoyaltyRelationBindModel alipayTradeRoyaltyRelationBindModel = null)

分账关系绑定

当商户签约分账产品后，授权ISV帮其进行分账关系的维护。本接口用于商户与分账方的关系绑定。

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
    public class BindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayTradeRoyaltyRelationApi(config);

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

            var alipayTradeRoyaltyRelationBindModel = new AlipayTradeRoyaltyRelationBindModel(); // AlipayTradeRoyaltyRelationBindModel |  (optional) 

            try
            {
                // 分账关系绑定
                AlipayTradeRoyaltyRelationBindResponseModel result = apiInstance.Bind(alipayTradeRoyaltyRelationBindModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeRoyaltyRelationApi.Bind: " + e.Message );
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
 **alipayTradeRoyaltyRelationBindModel** | **AlipayTradeRoyaltyRelationBindModel**|  | [optional] 

### Return type

**AlipayTradeRoyaltyRelationBindResponseModel**

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

<a name="unbind"></a>
# **Unbind**
> AlipayTradeRoyaltyRelationUnbindResponseModel Unbind (AlipayTradeRoyaltyRelationUnbindModel alipayTradeRoyaltyRelationUnbindModel = null)

分账关系解绑

当商户签约分账产品后，授权ISV帮其进行分账关系的维护。本接口用于商户与分账方的关系解绑。

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
    public class UnbindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayTradeRoyaltyRelationApi(config);

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

            var alipayTradeRoyaltyRelationUnbindModel = new AlipayTradeRoyaltyRelationUnbindModel(); // AlipayTradeRoyaltyRelationUnbindModel |  (optional) 

            try
            {
                // 分账关系解绑
                AlipayTradeRoyaltyRelationUnbindResponseModel result = apiInstance.Unbind(alipayTradeRoyaltyRelationUnbindModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeRoyaltyRelationApi.Unbind: " + e.Message );
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
 **alipayTradeRoyaltyRelationUnbindModel** | **AlipayTradeRoyaltyRelationUnbindModel**|  | [optional] 

### Return type

**AlipayTradeRoyaltyRelationUnbindResponseModel**

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

