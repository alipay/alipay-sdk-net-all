# AlipaySDKNet.OpenAPI.Api.ZhimaMerchantZmgoTemplateApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](ZhimaMerchantZmgoTemplateApi.md#create) | **POST** /v3/zhima/merchant/zmgo/template/create | 商户创建芝麻GO模板接口
[**Query**](ZhimaMerchantZmgoTemplateApi.md#query) | **GET** /v3/zhima/merchant/zmgo/template/query | 芝麻GO模板查询


<a name="create"></a>
# **Create**
> ZhimaMerchantZmgoTemplateCreateResponseModel Create (ZhimaMerchantZmgoTemplateCreateModel zhimaMerchantZmgoTemplateCreateModel = null)

商户创建芝麻GO模板接口

外部商家接入芝麻GO场景下，为商户提供自助创建芝麻GO模板的能力。 

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
            var apiInstance = new ZhimaMerchantZmgoTemplateApi(config);

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

            var zhimaMerchantZmgoTemplateCreateModel = new ZhimaMerchantZmgoTemplateCreateModel(); // ZhimaMerchantZmgoTemplateCreateModel |  (optional) 

            try
            {
                // 商户创建芝麻GO模板接口
                ZhimaMerchantZmgoTemplateCreateResponseModel result = apiInstance.Create(zhimaMerchantZmgoTemplateCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaMerchantZmgoTemplateApi.Create: " + e.Message );
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
 **zhimaMerchantZmgoTemplateCreateModel** | **ZhimaMerchantZmgoTemplateCreateModel**|  | [optional] 

### Return type

**ZhimaMerchantZmgoTemplateCreateResponseModel**

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
> ZhimaMerchantZmgoTemplateQueryResponseModel Query (string templateNo = null, string partnerId = null)

芝麻GO模板查询

芝麻GO模板查询

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
            var apiInstance = new ZhimaMerchantZmgoTemplateApi(config);

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

            var templateNo = ZMGO_TPL2021061601004538;  // string | 模板ID，由创建模板接口返回结果提供 (optional) 
            var partnerId = 208830****697946;  // string | 商户ID (optional) 

            try
            {
                // 芝麻GO模板查询
                ZhimaMerchantZmgoTemplateQueryResponseModel result = apiInstance.Query(templateNo, partnerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaMerchantZmgoTemplateApi.Query: " + e.Message );
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
 **templateNo** | **string**| 模板ID，由创建模板接口返回结果提供 | [optional] 
 **partnerId** | **string**| 商户ID | [optional] 

### Return type

**ZhimaMerchantZmgoTemplateQueryResponseModel**

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

