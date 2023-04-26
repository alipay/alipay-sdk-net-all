# AlipaySDKNet.OpenAPI.Api.AlipayEcoDocTemplateApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEcoDocTemplateApi.md#create) | **POST** /v3/alipay/eco/doc/template/create | 创建合同模板（E签宝）


<a name="create"></a>
# **Create**
> AlipayEcoDocTemplateCreateResponseModel Create (string targetAppId = null, AlipayEcoDocTemplateCreateModel alipayEcoDocTemplateCreateModel = null)

创建合同模板（E签宝）

通过此接口创建合同模板后，通过返回的文件直传地址上传模板文件（WORD/PDF）。同时记录接口返回的模板ID（templateId），后续发起合同签署需要使用到。

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
            var apiInstance = new AlipayEcoDocTemplateApi(config);

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

            var targetAppId = "targetAppId_example";  // string | 目标isv应用ID (optional) 
            var alipayEcoDocTemplateCreateModel = new AlipayEcoDocTemplateCreateModel(); // AlipayEcoDocTemplateCreateModel |  (optional) 

            try
            {
                // 创建合同模板（E签宝）
                AlipayEcoDocTemplateCreateResponseModel result = apiInstance.Create(targetAppId, alipayEcoDocTemplateCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoDocTemplateApi.Create: " + e.Message );
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
 **targetAppId** | **string**| 目标isv应用ID | [optional] 
 **alipayEcoDocTemplateCreateModel** | **AlipayEcoDocTemplateCreateModel**|  | [optional] 

### Return type

**AlipayEcoDocTemplateCreateResponseModel**

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

