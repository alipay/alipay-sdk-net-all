# AlipaySDKNet.OpenAPI.Api.AlipayDataDataserviceAdPromotepageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayDataDataserviceAdPromotepageApi.md#batchquery) | **GET** /v3/alipay/data/dataservice/ad/promotepage/batchquery | 自建推广页列表批量查询
[**Download**](AlipayDataDataserviceAdPromotepageApi.md#download) | **GET** /v3/alipay/data/dataservice/ad/promotepage/download | 自建推广页留资数据查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayDataDataserviceAdPromotepageBatchqueryResponseModel Batchquery (string bizToken = null, string principalTag = null, string type = null, int? pageNo = null, int? pageSize = null)

自建推广页列表批量查询

用于获取指定商家的自建推广页列表

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
            var apiInstance = new AlipayDataDataserviceAdPromotepageApi(config);

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

            var bizToken = HYjofejnnlp89730202bcklHH;  // string | 代理商访问灯火平台的token (optional) 
            var principalTag = yfvbv133498;  // string | 商家标志 (optional) 
            var type = COLLECT_INFO;  // string | 推广页类型：COLLECT_INFO -  免费留资；TRADE - 付费留资； OPERATION_PAID - 运营商付费留资；待扩展 (optional) 
            var pageNo = 1;  // int? | 分页参数之页数，从1开始 (optional) 
            var pageSize = 100;  // int? | 分页参数之每页大小，最大1000 (optional) 

            try
            {
                // 自建推广页列表批量查询
                AlipayDataDataserviceAdPromotepageBatchqueryResponseModel result = apiInstance.Batchquery(bizToken, principalTag, type, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataDataserviceAdPromotepageApi.Batchquery: " + e.Message );
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
 **bizToken** | **string**| 代理商访问灯火平台的token | [optional] 
 **principalTag** | **string**| 商家标志 | [optional] 
 **type** | **string**| 推广页类型：COLLECT_INFO -  免费留资；TRADE - 付费留资； OPERATION_PAID - 运营商付费留资；待扩展 | [optional] 
 **pageNo** | **int?**| 分页参数之页数，从1开始 | [optional] 
 **pageSize** | **int?**| 分页参数之每页大小，最大1000 | [optional] 

### Return type

**AlipayDataDataserviceAdPromotepageBatchqueryResponseModel**

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

<a name="download"></a>
# **Download**
> AlipayDataDataserviceAdPromotepageDownloadResponseModel Download (string startDate = null, string endDate = null, int? pageNo = null, int? pageSize = null, string bizToken = null, string principalTag = null, int? promotePageId = null)

自建推广页留资数据查询

用于获取指定商家指定推广页的留资数据，注意调用频次小于20qps

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
    public class DownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayDataDataserviceAdPromotepageApi(config);

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

            var startDate = 2020-12-12;  // string | 留资开始日期，格式：yyyy-mm-dd，不能早于30天前 (optional) 
            var endDate = 2020-12-13;  // string | 留资结束日期，格式：yyyy-mm-dd；不能晚于当天 (optional) 
            var pageNo = 1;  // int? | 分页参数之页数，从1开始 (optional) 
            var pageSize = 100;  // int? | 分页参数之每页大小，最大1000 (optional) 
            var bizToken = HYjofejnnlp89730202bcklHH;  // string | 代理商访问灯火平台的token (optional) 
            var principalTag = yfvbv133498;  // string | 商家标志 (optional) 
            var promotePageId = 79900056;  // int? | 推广页id (optional) 

            try
            {
                // 自建推广页留资数据查询
                AlipayDataDataserviceAdPromotepageDownloadResponseModel result = apiInstance.Download(startDate, endDate, pageNo, pageSize, bizToken, principalTag, promotePageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataDataserviceAdPromotepageApi.Download: " + e.Message );
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
 **startDate** | **string**| 留资开始日期，格式：yyyy-mm-dd，不能早于30天前 | [optional] 
 **endDate** | **string**| 留资结束日期，格式：yyyy-mm-dd；不能晚于当天 | [optional] 
 **pageNo** | **int?**| 分页参数之页数，从1开始 | [optional] 
 **pageSize** | **int?**| 分页参数之每页大小，最大1000 | [optional] 
 **bizToken** | **string**| 代理商访问灯火平台的token | [optional] 
 **principalTag** | **string**| 商家标志 | [optional] 
 **promotePageId** | **int?**| 推广页id | [optional] 

### Return type

**AlipayDataDataserviceAdPromotepageDownloadResponseModel**

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

