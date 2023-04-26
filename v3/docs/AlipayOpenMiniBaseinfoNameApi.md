# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniBaseinfoNameApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Check**](AlipayOpenMiniBaseinfoNameApi.md#check) | **GET** /v3/alipay/open/mini/baseinfo/name/check | 小程序名称检测


<a name="check"></a>
# **Check**
> AlipayOpenMiniBaseinfoNameCheckResponseModel Check (string appName = null)

小程序名称检测

小程序名称检测。包含小程序名称基础校验、名称重复、存在敏感信息、存在品牌词、名称宽泛等检测能力。若返回“check_code”：“NONE”，说明小程序名称未检测出异常。

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
    public class CheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniBaseinfoNameApi(config);

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

            var appName = 吱声小铺;  // string | 小程序名字，长度限制 3~30 个字符，仅支持包含简体中文、数字、英文、下划线、+、-。 (optional) 

            try
            {
                // 小程序名称检测
                AlipayOpenMiniBaseinfoNameCheckResponseModel result = apiInstance.Check(appName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniBaseinfoNameApi.Check: " + e.Message );
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
 **appName** | **string**| 小程序名字，长度限制 3~30 个字符，仅支持包含简体中文、数字、英文、下划线、+、-。 | [optional] 

### Return type

**AlipayOpenMiniBaseinfoNameCheckResponseModel**

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

