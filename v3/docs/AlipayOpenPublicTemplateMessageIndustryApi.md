# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicTemplateMessageIndustryApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayOpenPublicTemplateMessageIndustryApi.md#modify) | **POST** /v3/alipay/open/public/template/message/industry/modify | 模板消息行业设置修改接口


<a name="modify"></a>
# **Modify**
> Object Modify (AlipayOpenPublicTemplateMessageIndustryModifyModel alipayOpenPublicTemplateMessageIndustryModifyModel = null)

模板消息行业设置修改接口

用于修改服务窗消息模板设置的行业信息，如：IT科技/IT软件与服务。

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
            var apiInstance = new AlipayOpenPublicTemplateMessageIndustryApi(config);

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

            var alipayOpenPublicTemplateMessageIndustryModifyModel = new AlipayOpenPublicTemplateMessageIndustryModifyModel(); // AlipayOpenPublicTemplateMessageIndustryModifyModel |  (optional) 

            try
            {
                // 模板消息行业设置修改接口
                Object result = apiInstance.Modify(alipayOpenPublicTemplateMessageIndustryModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicTemplateMessageIndustryApi.Modify: " + e.Message );
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
 **alipayOpenPublicTemplateMessageIndustryModifyModel** | **AlipayOpenPublicTemplateMessageIndustryModifyModel**|  | [optional] 

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

