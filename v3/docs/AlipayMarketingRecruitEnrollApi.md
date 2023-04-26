# AlipaySDKNet.OpenAPI.Api.AlipayMarketingRecruitEnrollApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Close**](AlipayMarketingRecruitEnrollApi.md#close) | **POST** /v3/alipay/marketing/recruit/enroll/close | 下线报名
[**Create**](AlipayMarketingRecruitEnrollApi.md#create) | **POST** /v3/alipay/marketing/recruit/enroll/create | 招商报名提交
[**Query**](AlipayMarketingRecruitEnrollApi.md#query) | **GET** /v3/alipay/marketing/recruit/enroll/query | 报名详情查询


<a name="close"></a>
# **Close**
> Object Close (AlipayMarketingRecruitEnrollCloseModel alipayMarketingRecruitEnrollCloseModel = null)

下线报名

下线报名

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
            var apiInstance = new AlipayMarketingRecruitEnrollApi(config);

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

            var alipayMarketingRecruitEnrollCloseModel = new AlipayMarketingRecruitEnrollCloseModel(); // AlipayMarketingRecruitEnrollCloseModel |  (optional) 

            try
            {
                // 下线报名
                Object result = apiInstance.Close(alipayMarketingRecruitEnrollCloseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingRecruitEnrollApi.Close: " + e.Message );
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
 **alipayMarketingRecruitEnrollCloseModel** | **AlipayMarketingRecruitEnrollCloseModel**|  | [optional] 

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
> AlipayMarketingRecruitEnrollCreateResponseModel Create (AlipayMarketingRecruitEnrollCreateModel alipayMarketingRecruitEnrollCreateModel = null)

招商报名提交

创建报名后立即提交，审核通过后会以消息的形式通知调用方（需要接入消息接口alipay.marketing.enroll.status.changed）。在消息通知前可以尝试调用“报名详情查询接口（alipay.marketing.enroll.detail.query）”了解报名状态。

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
            var apiInstance = new AlipayMarketingRecruitEnrollApi(config);

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

            var alipayMarketingRecruitEnrollCreateModel = new AlipayMarketingRecruitEnrollCreateModel(); // AlipayMarketingRecruitEnrollCreateModel |  (optional) 

            try
            {
                // 招商报名提交
                AlipayMarketingRecruitEnrollCreateResponseModel result = apiInstance.Create(alipayMarketingRecruitEnrollCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingRecruitEnrollApi.Create: " + e.Message );
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
 **alipayMarketingRecruitEnrollCreateModel** | **AlipayMarketingRecruitEnrollCreateModel**|  | [optional] 

### Return type

**AlipayMarketingRecruitEnrollCreateResponseModel**

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
> AlipayMarketingRecruitEnrollQueryResponseModel Query (string outBizNo = null, string enrollId = null)

报名详情查询

报名详情查询

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
            var apiInstance = new AlipayMarketingRecruitEnrollApi(config);

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

            var outBizNo = 21ba1e1c16456985463242192e4d;  // string | 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。 (optional) 
            var enrollId = 2021041301000200000000000000;  // string | 报名ID，此参数和out_biz_no至少传一个，优先取enroll_id (optional) 

            try
            {
                // 报名详情查询
                AlipayMarketingRecruitEnrollQueryResponseModel result = apiInstance.Query(outBizNo, enrollId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingRecruitEnrollApi.Query: " + e.Message );
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
 **outBizNo** | **string**| 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。 | [optional] 
 **enrollId** | **string**| 报名ID，此参数和out_biz_no至少传一个，优先取enroll_id | [optional] 

### Return type

**AlipayMarketingRecruitEnrollQueryResponseModel**

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

