# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniWidgetGoodsApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayOpenMiniWidgetGoodsApi.md#modify) | **PATCH** /v3/alipay/open/mini/widget/goods/modify | 小部件商品修改
[**Query**](AlipayOpenMiniWidgetGoodsApi.md#query) | **GET** /v3/alipay/open/mini/widget/goods/query | 小部件商品查询
[**Upload**](AlipayOpenMiniWidgetGoodsApi.md#upload) | **POST** /v3/alipay/open/mini/widget/goods/upload | 小部件商品上传


<a name="modify"></a>
# **Modify**
> AlipayOpenMiniWidgetGoodsModifyResponseModel Modify (AlipayOpenMiniWidgetGoodsModifyModel alipayOpenMiniWidgetGoodsModifyModel = null)

小部件商品修改

面向商品售卖类的小部件，提供的商品信息修改能力，修改后会进行文本和图片信息审核，审核完成后通知结果通过openmq消息通知

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
            var apiInstance = new AlipayOpenMiniWidgetGoodsApi(config);

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

            var alipayOpenMiniWidgetGoodsModifyModel = new AlipayOpenMiniWidgetGoodsModifyModel(); // AlipayOpenMiniWidgetGoodsModifyModel |  (optional) 

            try
            {
                // 小部件商品修改
                AlipayOpenMiniWidgetGoodsModifyResponseModel result = apiInstance.Modify(alipayOpenMiniWidgetGoodsModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniWidgetGoodsApi.Modify: " + e.Message );
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
 **alipayOpenMiniWidgetGoodsModifyModel** | **AlipayOpenMiniWidgetGoodsModifyModel**|  | [optional] 

### Return type

**AlipayOpenMiniWidgetGoodsModifyResponseModel**

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
> AlipayOpenMiniWidgetGoodsQueryResponseModel Query (string miniAppId = null, string pid = null, string goodsId = null, int? pageNum = null, int? pageSize = null)

小部件商品查询

面向商品售卖类的小部件，提供商品信息查询能力，返回审核通过的商品信息

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
            var apiInstance = new AlipayOpenMiniWidgetGoodsApi(config);

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

            var miniAppId = 2017072607907880;  // string | 根据承接品的商家小程序ID查询 (optional) 
            var pid = 2088xxxxxxxxx;  // string | 根据承接该品的小程序背后的商家查询 (optional) 
            var goodsId = 8948968498;  // string | 根据商品的唯一标识查询 (optional) 
            var pageNum = 1;  // int? | 查询第几页，最小值为1 (optional) 
            var pageSize = 10;  // int? | 查询页面数量，最大值为50 (optional) 

            try
            {
                // 小部件商品查询
                AlipayOpenMiniWidgetGoodsQueryResponseModel result = apiInstance.Query(miniAppId, pid, goodsId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniWidgetGoodsApi.Query: " + e.Message );
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
 **miniAppId** | **string**| 根据承接品的商家小程序ID查询 | [optional] 
 **pid** | **string**| 根据承接该品的小程序背后的商家查询 | [optional] 
 **goodsId** | **string**| 根据商品的唯一标识查询 | [optional] 
 **pageNum** | **int?**| 查询第几页，最小值为1 | [optional] 
 **pageSize** | **int?**| 查询页面数量，最大值为50 | [optional] 

### Return type

**AlipayOpenMiniWidgetGoodsQueryResponseModel**

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

<a name="upload"></a>
# **Upload**
> AlipayOpenMiniWidgetGoodsUploadResponseModel Upload (AlipayOpenMiniWidgetGoodsUploadModel alipayOpenMiniWidgetGoodsUploadModel = null)

小部件商品上传

面向商品售卖类的小部件，提供的商品信息上传能力，上传后会进行文本和图片信息审核，审核完成后通知结果通过openmq消息通知

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
    public class UploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniWidgetGoodsApi(config);

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

            var alipayOpenMiniWidgetGoodsUploadModel = new AlipayOpenMiniWidgetGoodsUploadModel(); // AlipayOpenMiniWidgetGoodsUploadModel |  (optional) 

            try
            {
                // 小部件商品上传
                AlipayOpenMiniWidgetGoodsUploadResponseModel result = apiInstance.Upload(alipayOpenMiniWidgetGoodsUploadModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniWidgetGoodsApi.Upload: " + e.Message );
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
 **alipayOpenMiniWidgetGoodsUploadModel** | **AlipayOpenMiniWidgetGoodsUploadModel**|  | [optional] 

### Return type

**AlipayOpenMiniWidgetGoodsUploadResponseModel**

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

