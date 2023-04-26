# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicMatchuserLabelApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayOpenPublicMatchuserLabelApi.md#create) | **POST** /v3/alipay/open/public/matchuser/label/create | 用户打标接口
[**Delete**](AlipayOpenPublicMatchuserLabelApi.md#delete) | **POST** /v3/alipay/open/public/matchuser/label/delete | 用户取消标签接口


<a name="create"></a>
# **Create**
> AlipayOpenPublicMatchuserLabelCreateResponseModel Create (AlipayOpenPublicMatchuserLabelCreateModel alipayOpenPublicMatchuserLabelCreateModel = null)

用户打标接口

开发者可以使用此接口向匹配到的用户添加指定标签值，每个用户每个标签只能有一个标签值，当向同一个用户添加多个标签值时，最新的标签值会覆盖之前的标签值

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
            var apiInstance = new AlipayOpenPublicMatchuserLabelApi(config);

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

            var alipayOpenPublicMatchuserLabelCreateModel = new AlipayOpenPublicMatchuserLabelCreateModel(); // AlipayOpenPublicMatchuserLabelCreateModel |  (optional) 

            try
            {
                // 用户打标接口
                AlipayOpenPublicMatchuserLabelCreateResponseModel result = apiInstance.Create(alipayOpenPublicMatchuserLabelCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicMatchuserLabelApi.Create: " + e.Message );
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
 **alipayOpenPublicMatchuserLabelCreateModel** | **AlipayOpenPublicMatchuserLabelCreateModel**|  | [optional] 

### Return type

**AlipayOpenPublicMatchuserLabelCreateResponseModel**

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

<a name="delete"></a>
# **Delete**
> AlipayOpenPublicMatchuserLabelDeleteResponseModel Delete (AlipayOpenPublicMatchuserLabelDeleteModel alipayOpenPublicMatchuserLabelDeleteModel = null)

用户取消标签接口

开发者可以使用此接口删除匹配到的支付宝用户的指定标签值

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
            var apiInstance = new AlipayOpenPublicMatchuserLabelApi(config);

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

            var alipayOpenPublicMatchuserLabelDeleteModel = new AlipayOpenPublicMatchuserLabelDeleteModel(); // AlipayOpenPublicMatchuserLabelDeleteModel |  (optional) 

            try
            {
                // 用户取消标签接口
                AlipayOpenPublicMatchuserLabelDeleteResponseModel result = apiInstance.Delete(alipayOpenPublicMatchuserLabelDeleteModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicMatchuserLabelApi.Delete: " + e.Message );
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
 **alipayOpenPublicMatchuserLabelDeleteModel** | **AlipayOpenPublicMatchuserLabelDeleteModel**|  | [optional] 

### Return type

**AlipayOpenPublicMatchuserLabelDeleteResponseModel**

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

