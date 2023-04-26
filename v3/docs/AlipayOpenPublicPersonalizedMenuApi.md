# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicPersonalizedMenuApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayOpenPublicPersonalizedMenuApi.md#create) | **POST** /v3/alipay/open/public/personalized/menu/create | 个性化菜单创建
[**Delete**](AlipayOpenPublicPersonalizedMenuApi.md#delete) | **DELETE** /v3/alipay/open/public/personalized/menu/delete | 个性化菜单删除


<a name="create"></a>
# **Create**
> AlipayOpenPublicPersonalizedMenuCreateResponseModel Create (AlipayOpenPublicPersonalizedMenuCreateModel alipayOpenPublicPersonalizedMenuCreateModel = null)

个性化菜单创建

开发者可使用该接口创建个性化菜单，当生活号用户标签信息命中该菜单的标签规则时，用户将会看到该套菜单。个性化菜单创建完成后立即生效，用户支付宝客户端版本低于10.0.12时，若创建的是icon菜单，也会以文本菜单的形式展示。

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
            var apiInstance = new AlipayOpenPublicPersonalizedMenuApi(config);

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

            var alipayOpenPublicPersonalizedMenuCreateModel = new AlipayOpenPublicPersonalizedMenuCreateModel(); // AlipayOpenPublicPersonalizedMenuCreateModel |  (optional) 

            try
            {
                // 个性化菜单创建
                AlipayOpenPublicPersonalizedMenuCreateResponseModel result = apiInstance.Create(alipayOpenPublicPersonalizedMenuCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicPersonalizedMenuApi.Create: " + e.Message );
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
 **alipayOpenPublicPersonalizedMenuCreateModel** | **AlipayOpenPublicPersonalizedMenuCreateModel**|  | [optional] 

### Return type

**AlipayOpenPublicPersonalizedMenuCreateResponseModel**

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
> Object Delete (string menuKey = null)

个性化菜单删除

开发者可使用该接口删除个性化菜单

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
            var apiInstance = new AlipayOpenPublicPersonalizedMenuApi(config);

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

            var menuKey = 100000;  // string | 要删除的个性化菜单key。通过 <a href=\"https://opendocs.alipay.com/apis/api_6/alipay.open.public.personalized.menu.create\">alipay.open.public.personalized.menu.create</a>(个性化菜单创建)接口创建个性化菜单后获取。 (optional) 

            try
            {
                // 个性化菜单删除
                Object result = apiInstance.Delete(menuKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicPersonalizedMenuApi.Delete: " + e.Message );
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
 **menuKey** | **string**| 要删除的个性化菜单key。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.personalized.menu.create\&quot;&gt;alipay.open.public.personalized.menu.create&lt;/a&gt;(个性化菜单创建)接口创建个性化菜单后获取。 | [optional] 

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

