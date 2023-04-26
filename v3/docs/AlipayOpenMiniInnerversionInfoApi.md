# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionInfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Delete**](AlipayOpenMiniInnerversionInfoApi.md#delete) | **DELETE** /v3/alipay/open/mini/innerversion/info/delete | 内部链路删除版本
[**Query**](AlipayOpenMiniInnerversionInfoApi.md#query) | **GET** /v3/alipay/open/mini/innerversion/info/query | 内部链路小程序版本信息查询


<a name="delete"></a>
# **Delete**
> Object Delete (string miniAppId = null, string appOrigin = null, string bundleId = null, string appVersion = null, string pid = null, string instCode = null)

内部链路删除版本

针对一二方场景的开发者，小程序提供一套统一的内部能力体系，定向输出赋能，本接口主要用于删除版本

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
            var apiInstance = new AlipayOpenMiniInnerversionInfoApi(config);

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

            var miniAppId = 2018********;  // string | 小程序ID (optional) 
            var appOrigin = ASTORE;  // string | 业务场景来源 (optional) 
            var bundleId = com.alipay.alipaywallet;  // string | 端信息 (optional) 
            var appVersion = 0.0.1;  // string | 小程序版本号 (optional) 
            var pid = 2088*******;  // string | 操作者ID，支付宝租户必填 (optional) 
            var instCode = alipay;  // string | 租户信息 (optional) 

            try
            {
                // 内部链路删除版本
                Object result = apiInstance.Delete(miniAppId, appOrigin, bundleId, appVersion, pid, instCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionInfoApi.Delete: " + e.Message );
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
 **miniAppId** | **string**| 小程序ID | [optional] 
 **appOrigin** | **string**| 业务场景来源 | [optional] 
 **bundleId** | **string**| 端信息 | [optional] 
 **appVersion** | **string**| 小程序版本号 | [optional] 
 **pid** | **string**| 操作者ID，支付宝租户必填 | [optional] 
 **instCode** | **string**| 租户信息 | [optional] 

### Return type

**Object**

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

<a name="query"></a>
# **Query**
> AlipayOpenMiniInnerversionInfoQueryResponseModel Query (string bundleId = null, string miniAppId = null, string appVersion = null, string appOrigin = null)

内部链路小程序版本信息查询

小程序提供一套针对一二方场景的开发者提供一套统一的内部能力开放体系，定向输出赋能

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
            var apiInstance = new AlipayOpenMiniInnerversionInfoApi(config);

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

            var bundleId = 支付宝：com.alipay.alipaywallet 高德：com.amap.app;  // string | 端信息 (optional) 
            var miniAppId = 2019****;  // string | 小程序ID (optional) 
            var appVersion = 0.0.1;  // string | 查询版本号 (optional) 
            var appOrigin = https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang;  // string | 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang (optional) 

            try
            {
                // 内部链路小程序版本信息查询
                AlipayOpenMiniInnerversionInfoQueryResponseModel result = apiInstance.Query(bundleId, miniAppId, appVersion, appOrigin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionInfoApi.Query: " + e.Message );
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
 **bundleId** | **string**| 端信息 | [optional] 
 **miniAppId** | **string**| 小程序ID | [optional] 
 **appVersion** | **string**| 查询版本号 | [optional] 
 **appOrigin** | **string**| 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang | [optional] 

### Return type

**AlipayOpenMiniInnerversionInfoQueryResponseModel**

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

