# AlipaySDKNet.OpenAPI.Api.AlipayOpenAppMiniTemplatemessageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Send**](AlipayOpenAppMiniTemplatemessageApi.md#send) | **POST** /v3/alipay/open/app/mini/templatemessage/send | 小程序发送模板消息


<a name="send"></a>
# **Send**
> Object Send (AlipayOpenAppMiniTemplatemessageSendModel alipayOpenAppMiniTemplatemessageSendModel = null)

小程序发送模板消息

小程序通过openapi给用户触达消息，主要为支付后的触达（通过消费id）、用户提交表单后的触达（通过formId）、刷脸后的触达（通过ftoken）以及用户订阅消息模板后的触达。

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
    public class SendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAppMiniTemplatemessageApi(config);

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

            var alipayOpenAppMiniTemplatemessageSendModel = new AlipayOpenAppMiniTemplatemessageSendModel(); // AlipayOpenAppMiniTemplatemessageSendModel |  (optional) 

            try
            {
                // 小程序发送模板消息
                Object result = apiInstance.Send(alipayOpenAppMiniTemplatemessageSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAppMiniTemplatemessageApi.Send: " + e.Message );
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
 **alipayOpenAppMiniTemplatemessageSendModel** | **AlipayOpenAppMiniTemplatemessageSendModel**|  | [optional] 

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

