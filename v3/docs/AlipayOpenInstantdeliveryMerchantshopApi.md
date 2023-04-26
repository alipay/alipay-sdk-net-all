# AlipaySDKNet.OpenAPI.Api.AlipayOpenInstantdeliveryMerchantshopApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenInstantdeliveryMerchantshopApi.md#batchquery) | **POST** /v3/alipay/open/instantdelivery/merchantshop/batchquery | 即时配送商家门店分页查询
[**Create**](AlipayOpenInstantdeliveryMerchantshopApi.md#create) | **POST** /v3/alipay/open/instantdelivery/merchantshop/create | 即时配送商家门店创建
[**Modify**](AlipayOpenInstantdeliveryMerchantshopApi.md#modify) | **POST** /v3/alipay/open/instantdelivery/merchantshop/modify | 即时配送商家门店更新
[**Query**](AlipayOpenInstantdeliveryMerchantshopApi.md#query) | **GET** /v3/alipay/open/instantdelivery/merchantshop/query | 即时配送商家门店详情查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenInstantdeliveryMerchantshopBatchqueryResponseModel Batchquery (AlipayOpenInstantdeliveryMerchantshopBatchqueryModel alipayOpenInstantdeliveryMerchantshopBatchqueryModel = null)

即时配送商家门店分页查询

即时配送场景，商家门店信息分页查询

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
            var apiInstance = new AlipayOpenInstantdeliveryMerchantshopApi(config);

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

            var alipayOpenInstantdeliveryMerchantshopBatchqueryModel = new AlipayOpenInstantdeliveryMerchantshopBatchqueryModel(); // AlipayOpenInstantdeliveryMerchantshopBatchqueryModel |  (optional) 

            try
            {
                // 即时配送商家门店分页查询
                AlipayOpenInstantdeliveryMerchantshopBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenInstantdeliveryMerchantshopBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenInstantdeliveryMerchantshopApi.Batchquery: " + e.Message );
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
 **alipayOpenInstantdeliveryMerchantshopBatchqueryModel** | **AlipayOpenInstantdeliveryMerchantshopBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenInstantdeliveryMerchantshopBatchqueryResponseModel**

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
> AlipayOpenInstantdeliveryMerchantshopCreateResponseModel Create (AlipayOpenInstantdeliveryMerchantshopCreateModel alipayOpenInstantdeliveryMerchantshopCreateModel = null)

即时配送商家门店创建

帮商家在即时配送公司创建门店。名称+地址必须全局唯一；pid下的shopNo必须唯一。

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
            var apiInstance = new AlipayOpenInstantdeliveryMerchantshopApi(config);

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

            var alipayOpenInstantdeliveryMerchantshopCreateModel = new AlipayOpenInstantdeliveryMerchantshopCreateModel(); // AlipayOpenInstantdeliveryMerchantshopCreateModel |  (optional) 

            try
            {
                // 即时配送商家门店创建
                AlipayOpenInstantdeliveryMerchantshopCreateResponseModel result = apiInstance.Create(alipayOpenInstantdeliveryMerchantshopCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenInstantdeliveryMerchantshopApi.Create: " + e.Message );
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
 **alipayOpenInstantdeliveryMerchantshopCreateModel** | **AlipayOpenInstantdeliveryMerchantshopCreateModel**|  | [optional] 

### Return type

**AlipayOpenInstantdeliveryMerchantshopCreateResponseModel**

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
> AlipayOpenInstantdeliveryMerchantshopModifyResponseModel Modify (AlipayOpenInstantdeliveryMerchantshopModifyModel alipayOpenInstantdeliveryMerchantshopModifyModel = null)

即时配送商家门店更新

帮商家更新在即时配送公司的门店

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
            var apiInstance = new AlipayOpenInstantdeliveryMerchantshopApi(config);

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

            var alipayOpenInstantdeliveryMerchantshopModifyModel = new AlipayOpenInstantdeliveryMerchantshopModifyModel(); // AlipayOpenInstantdeliveryMerchantshopModifyModel |  (optional) 

            try
            {
                // 即时配送商家门店更新
                AlipayOpenInstantdeliveryMerchantshopModifyResponseModel result = apiInstance.Modify(alipayOpenInstantdeliveryMerchantshopModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenInstantdeliveryMerchantshopApi.Modify: " + e.Message );
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
 **alipayOpenInstantdeliveryMerchantshopModifyModel** | **AlipayOpenInstantdeliveryMerchantshopModifyModel**|  | [optional] 

### Return type

**AlipayOpenInstantdeliveryMerchantshopModifyResponseModel**

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
> AlipayOpenInstantdeliveryMerchantshopQueryResponseModel Query (string shopNo = null)

即时配送商家门店详情查询

即时配送场景，查询商家门店详情信息。

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
            var apiInstance = new AlipayOpenInstantdeliveryMerchantshopApi(config);

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

            var shopNo = 1000;  // string | 商家门店编码。 (optional) 

            try
            {
                // 即时配送商家门店详情查询
                AlipayOpenInstantdeliveryMerchantshopQueryResponseModel result = apiInstance.Query(shopNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenInstantdeliveryMerchantshopApi.Query: " + e.Message );
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
 **shopNo** | **string**| 商家门店编码。 | [optional] 

### Return type

**AlipayOpenInstantdeliveryMerchantshopQueryResponseModel**

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

