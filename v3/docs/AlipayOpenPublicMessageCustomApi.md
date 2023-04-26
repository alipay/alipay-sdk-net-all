# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicMessageCustomApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Send**](AlipayOpenPublicMessageCustomApi.md#send) | **POST** /v3/alipay/open/public/message/custom/send | 异步单发消息


<a name="send"></a>
# **Send**
> Object Send (AlipayOpenPublicMessageCustomSendModel alipayOpenPublicMessageCustomSendModel = null)

异步单发消息

开发者可使用该接口向指定关注用户推送客服消息，一般用于开发者使用接口与用户进行实时信息交互，例如自动回答用户包含某些指定关键字的咨询等。注意：用户必须在48小时之内与该生活号有交互行为才能收到消息（交互行为包括进入生活号、点击菜单、向生活号发送消息等），每个生活号每天只能向1个用户推送100条消息，超过这个数目会报错频率超限

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
            var apiInstance = new AlipayOpenPublicMessageCustomApi(config);

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

            var alipayOpenPublicMessageCustomSendModel = new AlipayOpenPublicMessageCustomSendModel(); // AlipayOpenPublicMessageCustomSendModel |  (optional) 

            try
            {
                // 异步单发消息
                Object result = apiInstance.Send(alipayOpenPublicMessageCustomSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicMessageCustomApi.Send: " + e.Message );
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
 **alipayOpenPublicMessageCustomSendModel** | **AlipayOpenPublicMessageCustomSendModel**|  | [optional] 

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

