# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicMessageSingleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Send**](AlipayOpenPublicMessageSingleApi.md#send) | **POST** /v3/alipay/open/public/message/single/send | 单发模板消息


<a name="send"></a>
# **Send**
> Object Send (AlipayOpenPublicMessageSingleSendModel alipayOpenPublicMessageSingleSendModel = null)

单发模板消息

商户可使用该接口向用户推送制定模板的消息，如动账提醒、停车通知等消息，消息模板可在生活号后台(fuwu.alipay.com)领取，点击“模板消息”菜单，即可在模板库中领取行业对应的模板

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
            var apiInstance = new AlipayOpenPublicMessageSingleApi(config);

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

            var alipayOpenPublicMessageSingleSendModel = new AlipayOpenPublicMessageSingleSendModel(); // AlipayOpenPublicMessageSingleSendModel |  (optional) 

            try
            {
                // 单发模板消息
                Object result = apiInstance.Send(alipayOpenPublicMessageSingleSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicMessageSingleApi.Send: " + e.Message );
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
 **alipayOpenPublicMessageSingleSendModel** | **AlipayOpenPublicMessageSingleSendModel**|  | [optional] 

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

