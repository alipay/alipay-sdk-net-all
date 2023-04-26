# AlipaySDKNet.OpenAPI.Api.AlipayOpenAuthAppAesApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](AlipayOpenAuthAppAesApi.md#get) | **GET** /v3/alipay/open/auth/app/aes/get | 授权应用aes密钥查询
[**Set**](AlipayOpenAuthAppAesApi.md#set) | **POST** /v3/alipay/open/auth/app/aes/set | 授权应用aes密钥设置


<a name="get"></a>
# **Get**
> AlipayOpenAuthAppAesGetResponseModel Get (string merchantAppId = null)

授权应用aes密钥查询

商家应用授权给ISV服务商代管理应用场景下，ISV开发者使用三方应用appId发起调用，通过该接口获取商户应用的AES密钥。接口返回的商户应用aes密钥内容为加密内容，需要ISV使用三方应用的AES密钥对接口返回进行解密。java sdk内部会自动完成解密返回明文内容。<a href=\"https://docs.open.alipay.com/common/104567\" target=\"_blank\">SDK AES加解密支持</a>

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
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAuthAppAesApi(config);

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

            var merchantAppId = 20191223601234564;  // string | 商家应用appId (optional) 

            try
            {
                // 授权应用aes密钥查询
                AlipayOpenAuthAppAesGetResponseModel result = apiInstance.Get(merchantAppId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAuthAppAesApi.Get: " + e.Message );
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
 **merchantAppId** | **string**| 商家应用appId | [optional] 

### Return type

**AlipayOpenAuthAppAesGetResponseModel**

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

<a name="set"></a>
# **Set**
> AlipayOpenAuthAppAesSetResponseModel Set (AlipayOpenAuthAppAesSetModel alipayOpenAuthAppAesSetModel = null)

授权应用aes密钥设置

商家应用授权给ISV服务商代管理应用场景下，ISV开发者使用三方应用appId发起调用，通过该接口设置商户应用的AES密钥。接口返回的商户应用aes密钥内容为加密内容，需要ISV使用三方应用的AES密钥对接口返回进行解密。java sdk内部会自动完成解密返回明文内容。<a href=\"https://docs.open.alipay.com/common/104567\" target=\"_blank\">SDK AES加解密支持。</a>

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
    public class SetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAuthAppAesApi(config);

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

            var alipayOpenAuthAppAesSetModel = new AlipayOpenAuthAppAesSetModel(); // AlipayOpenAuthAppAesSetModel |  (optional) 

            try
            {
                // 授权应用aes密钥设置
                AlipayOpenAuthAppAesSetResponseModel result = apiInstance.Set(alipayOpenAuthAppAesSetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAuthAppAesApi.Set: " + e.Message );
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
 **alipayOpenAuthAppAesSetModel** | **AlipayOpenAuthAppAesSetModel**|  | [optional] 

### Return type

**AlipayOpenAuthAppAesSetResponseModel**

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

