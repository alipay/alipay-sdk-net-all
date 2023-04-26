# AlipaySDKNet.OpenAPI.Api.AlipayOpenSearchAppkeywordApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayOpenSearchAppkeywordApi.md#apply) | **POST** /v3/alipay/open/search/appkeyword/apply | 提报搜索关键词
[**Batchquery**](AlipayOpenSearchAppkeywordApi.md#batchquery) | **GET** /v3/alipay/open/search/appkeyword/batchquery | 查询小程序已配置关键词
[**Delete**](AlipayOpenSearchAppkeywordApi.md#delete) | **POST** /v3/alipay/open/search/appkeyword/delete | 删除搜索关键词
[**Querystatus**](AlipayOpenSearchAppkeywordApi.md#querystatus) | **GET** /v3/alipay/open/search/appkeyword/querystatus | 查询小程序搜索关键词的审核工单的状态


<a name="apply"></a>
# **Apply**
> AlipayOpenSearchAppkeywordApplyResponseModel Apply (AlipayOpenSearchAppkeywordApplyModel alipayOpenSearchAppkeywordApplyModel = null)

提报搜索关键词

提报搜索关键词

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
    public class ApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSearchAppkeywordApi(config);

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

            var alipayOpenSearchAppkeywordApplyModel = new AlipayOpenSearchAppkeywordApplyModel(); // AlipayOpenSearchAppkeywordApplyModel |  (optional) 

            try
            {
                // 提报搜索关键词
                AlipayOpenSearchAppkeywordApplyResponseModel result = apiInstance.Apply(alipayOpenSearchAppkeywordApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchAppkeywordApi.Apply: " + e.Message );
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
 **alipayOpenSearchAppkeywordApplyModel** | **AlipayOpenSearchAppkeywordApplyModel**|  | [optional] 

### Return type

**AlipayOpenSearchAppkeywordApplyResponseModel**

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

<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenSearchAppkeywordBatchqueryResponseModel Batchquery (string targetAppid = null, string status = null, int? pageNumber = null, int? pageSize = null)

查询小程序已配置关键词

查询小程序已配置关键词

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
            var apiInstance = new AlipayOpenSearchAppkeywordApi(config);

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

            var targetAppid = 2021001120654127;  // string | 小程序id (optional) 
            var status = ONLINE;  // string | 关键词的状态，枚举值，不传该字段表示查询所有状态 (optional) 
            var pageNumber = 1;  // int? | 当前页 (optional) 
            var pageSize = 10;  // int? | 每页显示条数 (optional) 

            try
            {
                // 查询小程序已配置关键词
                AlipayOpenSearchAppkeywordBatchqueryResponseModel result = apiInstance.Batchquery(targetAppid, status, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchAppkeywordApi.Batchquery: " + e.Message );
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
 **targetAppid** | **string**| 小程序id | [optional] 
 **status** | **string**| 关键词的状态，枚举值，不传该字段表示查询所有状态 | [optional] 
 **pageNumber** | **int?**| 当前页 | [optional] 
 **pageSize** | **int?**| 每页显示条数 | [optional] 

### Return type

**AlipayOpenSearchAppkeywordBatchqueryResponseModel**

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

<a name="delete"></a>
# **Delete**
> Object Delete (AlipayOpenSearchAppkeywordDeleteModel alipayOpenSearchAppkeywordDeleteModel = null)

删除搜索关键词

删除搜索关键词

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
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSearchAppkeywordApi(config);

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

            var alipayOpenSearchAppkeywordDeleteModel = new AlipayOpenSearchAppkeywordDeleteModel(); // AlipayOpenSearchAppkeywordDeleteModel |  (optional) 

            try
            {
                // 删除搜索关键词
                Object result = apiInstance.Delete(alipayOpenSearchAppkeywordDeleteModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchAppkeywordApi.Delete: " + e.Message );
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
 **alipayOpenSearchAppkeywordDeleteModel** | **AlipayOpenSearchAppkeywordDeleteModel**|  | [optional] 

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

<a name="querystatus"></a>
# **Querystatus**
> AlipayOpenSearchAppkeywordQuerystatusResponseModel Querystatus (string targetAppid = null, string applyNo = null)

查询小程序搜索关键词的审核工单的状态

查询小程序搜索关键词的审核工单的状态

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
    public class QuerystatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSearchAppkeywordApi(config);

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

            var targetAppid = 2021001120654127;  // string | 小程序id (optional) 
            var applyNo = 20220519000000108026;  // string | 审核工单id，提报接口的返回值 (optional) 

            try
            {
                // 查询小程序搜索关键词的审核工单的状态
                AlipayOpenSearchAppkeywordQuerystatusResponseModel result = apiInstance.Querystatus(targetAppid, applyNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchAppkeywordApi.Querystatus: " + e.Message );
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
 **targetAppid** | **string**| 小程序id | [optional] 
 **applyNo** | **string**| 审核工单id，提报接口的返回值 | [optional] 

### Return type

**AlipayOpenSearchAppkeywordQuerystatusResponseModel**

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

