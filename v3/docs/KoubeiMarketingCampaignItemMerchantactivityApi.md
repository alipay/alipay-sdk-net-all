# AlipaySDKNet.OpenAPI.Api.KoubeiMarketingCampaignItemMerchantactivityApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](KoubeiMarketingCampaignItemMerchantactivityApi.md#batchquery) | **POST** /v3/koubei/marketing/campaign/item/merchantactivity/batchquery | 商户查询商品代金券列表
[**Close**](KoubeiMarketingCampaignItemMerchantactivityApi.md#close) | **POST** /v3/koubei/marketing/campaign/item/merchantactivity/close | 商户下架代金券
[**Create**](KoubeiMarketingCampaignItemMerchantactivityApi.md#create) | **POST** /v3/koubei/marketing/campaign/item/merchantactivity/create | 商户创建商品代金券
[**Modify**](KoubeiMarketingCampaignItemMerchantactivityApi.md#modify) | **POST** /v3/koubei/marketing/campaign/item/merchantactivity/modify | 商户修改商品代金券
[**Query**](KoubeiMarketingCampaignItemMerchantactivityApi.md#query) | **GET** /v3/koubei/marketing/campaign/item/merchantactivity/query | 商户查询商品代金券详情


<a name="batchquery"></a>
# **Batchquery**
> KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponseModel Batchquery (KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel koubeiMarketingCampaignItemMerchantactivityBatchqueryModel = null)

商户查询商品代金券列表

商户查询商品代金券列表

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
            var apiInstance = new KoubeiMarketingCampaignItemMerchantactivityApi(config);

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

            var koubeiMarketingCampaignItemMerchantactivityBatchqueryModel = new KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel(); // KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel |  (optional) 

            try
            {
                // 商户查询商品代金券列表
                KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponseModel result = apiInstance.Batchquery(koubeiMarketingCampaignItemMerchantactivityBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignItemMerchantactivityApi.Batchquery: " + e.Message );
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
 **koubeiMarketingCampaignItemMerchantactivityBatchqueryModel** | **KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel**|  | [optional] 

### Return type

**KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponseModel**

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

<a name="close"></a>
# **Close**
> Object Close (KoubeiMarketingCampaignItemMerchantactivityCloseModel koubeiMarketingCampaignItemMerchantactivityCloseModel = null)

商户下架代金券

商户下架代金券

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
    public class CloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new KoubeiMarketingCampaignItemMerchantactivityApi(config);

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

            var koubeiMarketingCampaignItemMerchantactivityCloseModel = new KoubeiMarketingCampaignItemMerchantactivityCloseModel(); // KoubeiMarketingCampaignItemMerchantactivityCloseModel |  (optional) 

            try
            {
                // 商户下架代金券
                Object result = apiInstance.Close(koubeiMarketingCampaignItemMerchantactivityCloseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignItemMerchantactivityApi.Close: " + e.Message );
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
 **koubeiMarketingCampaignItemMerchantactivityCloseModel** | **KoubeiMarketingCampaignItemMerchantactivityCloseModel**|  | [optional] 

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

<a name="create"></a>
# **Create**
> KoubeiMarketingCampaignItemMerchantactivityCreateResponseModel Create (KoubeiMarketingCampaignItemMerchantactivityCreateModel koubeiMarketingCampaignItemMerchantactivityCreateModel = null)

商户创建商品代金券

商户创建商品代金券

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
            var apiInstance = new KoubeiMarketingCampaignItemMerchantactivityApi(config);

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

            var koubeiMarketingCampaignItemMerchantactivityCreateModel = new KoubeiMarketingCampaignItemMerchantactivityCreateModel(); // KoubeiMarketingCampaignItemMerchantactivityCreateModel |  (optional) 

            try
            {
                // 商户创建商品代金券
                KoubeiMarketingCampaignItemMerchantactivityCreateResponseModel result = apiInstance.Create(koubeiMarketingCampaignItemMerchantactivityCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignItemMerchantactivityApi.Create: " + e.Message );
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
 **koubeiMarketingCampaignItemMerchantactivityCreateModel** | **KoubeiMarketingCampaignItemMerchantactivityCreateModel**|  | [optional] 

### Return type

**KoubeiMarketingCampaignItemMerchantactivityCreateResponseModel**

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
> Object Modify (KoubeiMarketingCampaignItemMerchantactivityModifyModel koubeiMarketingCampaignItemMerchantactivityModifyModel = null)

商户修改商品代金券

商户修改商品代金券

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
            var apiInstance = new KoubeiMarketingCampaignItemMerchantactivityApi(config);

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

            var koubeiMarketingCampaignItemMerchantactivityModifyModel = new KoubeiMarketingCampaignItemMerchantactivityModifyModel(); // KoubeiMarketingCampaignItemMerchantactivityModifyModel |  (optional) 

            try
            {
                // 商户修改商品代金券
                Object result = apiInstance.Modify(koubeiMarketingCampaignItemMerchantactivityModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignItemMerchantactivityApi.Modify: " + e.Message );
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
 **koubeiMarketingCampaignItemMerchantactivityModifyModel** | **KoubeiMarketingCampaignItemMerchantactivityModifyModel**|  | [optional] 

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
> KoubeiMarketingCampaignItemMerchantactivityQueryResponseModel Query (string activityId = null, string externalUniqueId = null)

商户查询商品代金券详情

商户查询商品代金券详情

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
            var apiInstance = new KoubeiMarketingCampaignItemMerchantactivityApi(config);

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

            var activityId = 2018xxxx;  // string | 运营活动id (optional) 
            var externalUniqueId = 2018xxxx;  // string | 外部id (optional) 

            try
            {
                // 商户查询商品代金券详情
                KoubeiMarketingCampaignItemMerchantactivityQueryResponseModel result = apiInstance.Query(activityId, externalUniqueId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KoubeiMarketingCampaignItemMerchantactivityApi.Query: " + e.Message );
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
 **activityId** | **string**| 运营活动id | [optional] 
 **externalUniqueId** | **string**| 外部id | [optional] 

### Return type

**KoubeiMarketingCampaignItemMerchantactivityQueryResponseModel**

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

