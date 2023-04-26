# AlipaySDKNet.OpenAPI.Api.AlipayOpenSearchSubservicekeywordApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayOpenSearchSubservicekeywordApi.md#apply) | **POST** /v3/alipay/open/search/subservicekeyword/apply | 提报服务关键词
[**Batchquery**](AlipayOpenSearchSubservicekeywordApi.md#batchquery) | **GET** /v3/alipay/open/search/subservicekeyword/batchquery | 服务关键词批量查询接口
[**Delete**](AlipayOpenSearchSubservicekeywordApi.md#delete) | **POST** /v3/alipay/open/search/subservicekeyword/delete | 删除服务关键词
[**Querystatus**](AlipayOpenSearchSubservicekeywordApi.md#querystatus) | **GET** /v3/alipay/open/search/subservicekeyword/querystatus | 查询小程序服务关键词的审核工单的状态


<a name="apply"></a>
# **Apply**
> AlipayOpenSearchSubservicekeywordApplyResponseModel Apply (AlipayOpenSearchSubservicekeywordApplyModel alipayOpenSearchSubservicekeywordApplyModel = null)

提报服务关键词

小程序-服务推广-提报服务关键词

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
            var apiInstance = new AlipayOpenSearchSubservicekeywordApi(config);

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

            var alipayOpenSearchSubservicekeywordApplyModel = new AlipayOpenSearchSubservicekeywordApplyModel(); // AlipayOpenSearchSubservicekeywordApplyModel |  (optional) 

            try
            {
                // 提报服务关键词
                AlipayOpenSearchSubservicekeywordApplyResponseModel result = apiInstance.Apply(alipayOpenSearchSubservicekeywordApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchSubservicekeywordApi.Apply: " + e.Message );
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
 **alipayOpenSearchSubservicekeywordApplyModel** | **AlipayOpenSearchSubservicekeywordApplyModel**|  | [optional] 

### Return type

**AlipayOpenSearchSubservicekeywordApplyResponseModel**

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
> AlipayOpenSearchSubservicekeywordBatchqueryResponseModel Batchquery (string targetAppid = null, string status = null, int? pageNumber = null, int? pageSize = null)

服务关键词批量查询接口

批量查询小程序的服务关键词

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
            var apiInstance = new AlipayOpenSearchSubservicekeywordApi(config);

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

            var targetAppid = 2021001112626071;  // string | 小程序id (optional) 
            var status = ONLINE;  // string | 审核状态，服务关键词的审核状态，枚举值，不传该字段表示查询所有状态 (optional) 
            var pageNumber = 1;  // int? | 分页参数，分页查询时使用 (optional) 
            var pageSize = 10;  // int? | 分页参数，分页查询时使用 (optional) 

            try
            {
                // 服务关键词批量查询接口
                AlipayOpenSearchSubservicekeywordBatchqueryResponseModel result = apiInstance.Batchquery(targetAppid, status, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchSubservicekeywordApi.Batchquery: " + e.Message );
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
 **status** | **string**| 审核状态，服务关键词的审核状态，枚举值，不传该字段表示查询所有状态 | [optional] 
 **pageNumber** | **int?**| 分页参数，分页查询时使用 | [optional] 
 **pageSize** | **int?**| 分页参数，分页查询时使用 | [optional] 

### Return type

**AlipayOpenSearchSubservicekeywordBatchqueryResponseModel**

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
> Object Delete (AlipayOpenSearchSubservicekeywordDeleteModel alipayOpenSearchSubservicekeywordDeleteModel = null)

删除服务关键词

删除服务关键词

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
            var apiInstance = new AlipayOpenSearchSubservicekeywordApi(config);

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

            var alipayOpenSearchSubservicekeywordDeleteModel = new AlipayOpenSearchSubservicekeywordDeleteModel(); // AlipayOpenSearchSubservicekeywordDeleteModel |  (optional) 

            try
            {
                // 删除服务关键词
                Object result = apiInstance.Delete(alipayOpenSearchSubservicekeywordDeleteModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchSubservicekeywordApi.Delete: " + e.Message );
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
 **alipayOpenSearchSubservicekeywordDeleteModel** | **AlipayOpenSearchSubservicekeywordDeleteModel**|  | [optional] 

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
> AlipayOpenSearchSubservicekeywordQuerystatusResponseModel Querystatus (string targetAppid = null, string applyNo = null)

查询小程序服务关键词的审核工单的状态

查询小程序服务关键词的审核工单的状态

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
            var apiInstance = new AlipayOpenSearchSubservicekeywordApi(config);

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

            var targetAppid = 2021001112626071;  // string | 小程序id (optional) 
            var applyNo = 20220519000000108026;  // string | 审核工单id，提报接口的返回值 (optional) 

            try
            {
                // 查询小程序服务关键词的审核工单的状态
                AlipayOpenSearchSubservicekeywordQuerystatusResponseModel result = apiInstance.Querystatus(targetAppid, applyNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchSubservicekeywordApi.Querystatus: " + e.Message );
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

**AlipayOpenSearchSubservicekeywordQuerystatusResponseModel**

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

