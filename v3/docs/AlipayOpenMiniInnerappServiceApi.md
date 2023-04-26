# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerappServiceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Publish**](AlipayOpenMiniInnerappServiceApi.md#publish) | **POST** /v3/alipay/open/mini/innerapp/service/publish | 小程序模板发布服务市场
[**Query**](AlipayOpenMiniInnerappServiceApi.md#query) | **GET** /v3/alipay/open/mini/innerapp/service/query | 小程序服务市场搜索


<a name="publish"></a>
# **Publish**
> AlipayOpenMiniInnerappServicePublishResponseModel Publish (AlipayOpenMiniInnerappServicePublishModel alipayOpenMiniInnerappServicePublishModel = null)

小程序模板发布服务市场

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
    public class PublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniInnerappServiceApi(config);

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

            var alipayOpenMiniInnerappServicePublishModel = new AlipayOpenMiniInnerappServicePublishModel(); // AlipayOpenMiniInnerappServicePublishModel |  (optional) 

            try
            {
                // 小程序模板发布服务市场
                AlipayOpenMiniInnerappServicePublishResponseModel result = apiInstance.Publish(alipayOpenMiniInnerappServicePublishModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappServiceApi.Publish: " + e.Message );
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
 **alipayOpenMiniInnerappServicePublishModel** | **AlipayOpenMiniInnerappServicePublishModel**|  | [optional] 

### Return type

**AlipayOpenMiniInnerappServicePublishResponseModel**

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
> AlipayOpenMiniInnerappServiceQueryResponseModel Query (string miniAppId = null, string appSubType = null, string showType = null, string keyword = null, string pageNum = null, string pageSize = null, string appOrigin = null, bool? includeOffline = null)

小程序服务市场搜索

小程序服务市场搜索，包括搜索模板和插件

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
            var apiInstance = new AlipayOpenMiniInnerappServiceApi(config);

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

            var miniAppId = 2012211102012056;  // string | 插件id或模板id (optional) 
            var appSubType = TINYAPP_TEMPLATE、TINYAPP_PLUGIN;  // string | 小程序应用子类型 (optional) 
            var showType = SHOW;  // string | 是否在服务市场透出，SHOW展示、HIDE隐藏 (optional) 
            var keyword = xxxx插件;  // string | 关键词 (optional) 
            var pageNum = 1;  // string | 页码，默认第一页 (optional) 
            var pageSize = 10;  // string | 分页数，默认每页10个 (optional) 
            var appOrigin = https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang;  // string | 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang (optional) 
            var includeOffline = true;  // bool? | 是否需要展示offline状态插件，不传默认为false（不展示） (optional) 

            try
            {
                // 小程序服务市场搜索
                AlipayOpenMiniInnerappServiceQueryResponseModel result = apiInstance.Query(miniAppId, appSubType, showType, keyword, pageNum, pageSize, appOrigin, includeOffline);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappServiceApi.Query: " + e.Message );
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
 **miniAppId** | **string**| 插件id或模板id | [optional] 
 **appSubType** | **string**| 小程序应用子类型 | [optional] 
 **showType** | **string**| 是否在服务市场透出，SHOW展示、HIDE隐藏 | [optional] 
 **keyword** | **string**| 关键词 | [optional] 
 **pageNum** | **string**| 页码，默认第一页 | [optional] 
 **pageSize** | **string**| 分页数，默认每页10个 | [optional] 
 **appOrigin** | **string**| 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang | [optional] 
 **includeOffline** | **bool?**| 是否需要展示offline状态插件，不传默认为false（不展示） | [optional] 

### Return type

**AlipayOpenMiniInnerappServiceQueryResponseModel**

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

