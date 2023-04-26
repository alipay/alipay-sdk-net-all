# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicMessageGroupApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Send**](AlipayOpenPublicMessageGroupApi.md#send) | **POST** /v3/alipay/open/public/message/group/send | 分组消息发送接口


<a name="send"></a>
# **Send**
> AlipayOpenPublicMessageGroupSendResponseModel Send (AlipayOpenPublicMessageGroupSendModel alipayOpenPublicMessageGroupSendModel = null)

分组消息发送接口

开发者可调用此接口向指定分组中的关注用户发送消息，该接口为异步接口，一般请求成功后一段时间用户才能收到消息。

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
            var apiInstance = new AlipayOpenPublicMessageGroupApi(config);

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

            var alipayOpenPublicMessageGroupSendModel = new AlipayOpenPublicMessageGroupSendModel(); // AlipayOpenPublicMessageGroupSendModel |  (optional) 

            try
            {
                // 分组消息发送接口
                AlipayOpenPublicMessageGroupSendResponseModel result = apiInstance.Send(alipayOpenPublicMessageGroupSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicMessageGroupApi.Send: " + e.Message );
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
 **alipayOpenPublicMessageGroupSendModel** | **AlipayOpenPublicMessageGroupSendModel**|  | [optional] 

### Return type

**AlipayOpenPublicMessageGroupSendResponseModel**

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

