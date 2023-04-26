# AlipaySDKNet.OpenAPI.Api.AlipayOfflineMarketShopApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOfflineMarketShopApi.md#batchquery) | **POST** /v3/alipay/offline/market/shop/batchquery | 查询商户的门店编号列表
[**Create**](AlipayOfflineMarketShopApi.md#create) | **POST** /v3/alipay/offline/market/shop/create | 创建门店信息
[**Modify**](AlipayOfflineMarketShopApi.md#modify) | **POST** /v3/alipay/offline/market/shop/modify | 修改门店信息
[**Querydetail**](AlipayOfflineMarketShopApi.md#querydetail) | **GET** /v3/alipay/offline/market/shop/querydetail | 查询单个门店信息接口


<a name="batchquery"></a>
# **Batchquery**
> AlipayOfflineMarketShopBatchqueryResponseModel Batchquery (AlipayOfflineMarketShopBatchqueryModel alipayOfflineMarketShopBatchqueryModel = null)

查询商户的门店编号列表

系统商通过该接口可以查询对应APPID下所有的门店编号（支付宝口碑门店编号）

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
            var apiInstance = new AlipayOfflineMarketShopApi(config);

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

            var alipayOfflineMarketShopBatchqueryModel = new AlipayOfflineMarketShopBatchqueryModel(); // AlipayOfflineMarketShopBatchqueryModel |  (optional) 

            try
            {
                // 查询商户的门店编号列表
                AlipayOfflineMarketShopBatchqueryResponseModel result = apiInstance.Batchquery(alipayOfflineMarketShopBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOfflineMarketShopApi.Batchquery: " + e.Message );
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
 **alipayOfflineMarketShopBatchqueryModel** | **AlipayOfflineMarketShopBatchqueryModel**|  | [optional] 

### Return type

**AlipayOfflineMarketShopBatchqueryResponseModel**

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
> AlipayOfflineMarketShopCreateResponseModel Create (AlipayOfflineMarketShopCreateModel alipayOfflineMarketShopCreateModel = null)

创建门店信息

系统商需要通过该接口在口碑平台帮助商户创建门店信息。

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
            var apiInstance = new AlipayOfflineMarketShopApi(config);

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

            var alipayOfflineMarketShopCreateModel = new AlipayOfflineMarketShopCreateModel(); // AlipayOfflineMarketShopCreateModel |  (optional) 

            try
            {
                // 创建门店信息
                AlipayOfflineMarketShopCreateResponseModel result = apiInstance.Create(alipayOfflineMarketShopCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOfflineMarketShopApi.Create: " + e.Message );
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
 **alipayOfflineMarketShopCreateModel** | **AlipayOfflineMarketShopCreateModel**|  | [optional] 

### Return type

**AlipayOfflineMarketShopCreateResponseModel**

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
> AlipayOfflineMarketShopModifyResponseModel Modify (AlipayOfflineMarketShopModifyModel alipayOfflineMarketShopModifyModel = null)

修改门店信息

系统商需要通过该接口在口碑平台帮助商户修改门店信息，所有的选项都为非必填项，需要修改什么信息就传入什么参数，不传入的参数，则保持不变。修改门店名、品牌名、品牌logo、首图、门店图片、营业执照、营业执照编号、营业执照名称、经营许可证、经营许可证有效期、门店授权函、是否在其它平台开店、在其它平台开店照片，会重新触发风控审核，修改其他字段不会触发风控审核。

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
            var apiInstance = new AlipayOfflineMarketShopApi(config);

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

            var alipayOfflineMarketShopModifyModel = new AlipayOfflineMarketShopModifyModel(); // AlipayOfflineMarketShopModifyModel |  (optional) 

            try
            {
                // 修改门店信息
                AlipayOfflineMarketShopModifyResponseModel result = apiInstance.Modify(alipayOfflineMarketShopModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOfflineMarketShopApi.Modify: " + e.Message );
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
 **alipayOfflineMarketShopModifyModel** | **AlipayOfflineMarketShopModifyModel**|  | [optional] 

### Return type

**AlipayOfflineMarketShopModifyResponseModel**

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

<a name="querydetail"></a>
# **Querydetail**
> AlipayOfflineMarketShopQuerydetailResponseModel Querydetail (string shopId = null, string opRole = null)

查询单个门店信息接口

系统商通过该接口可以查询单个门店的详细信息，包括门店基础信息，门店状态等信息

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
    public class QuerydetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOfflineMarketShopApi(config);

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

            var shopId = 2015052100077000000000120773;  // string | 支付宝门店ID (optional) 
            var opRole = MERCHANT或PROVIDER;  // string | 服务商及商户调用情况下务必传递。操作人角色，默认商户操作:MERCHANT；服务商操作：PROVIDER；ISV: 不需要填写 (optional) 

            try
            {
                // 查询单个门店信息接口
                AlipayOfflineMarketShopQuerydetailResponseModel result = apiInstance.Querydetail(shopId, opRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOfflineMarketShopApi.Querydetail: " + e.Message );
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
 **shopId** | **string**| 支付宝门店ID | [optional] 
 **opRole** | **string**| 服务商及商户调用情况下务必传递。操作人角色，默认商户操作:MERCHANT；服务商操作：PROVIDER；ISV: 不需要填写 | [optional] 

### Return type

**AlipayOfflineMarketShopQuerydetailResponseModel**

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

