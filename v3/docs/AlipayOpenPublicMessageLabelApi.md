# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicMessageLabelApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Send**](AlipayOpenPublicMessageLabelApi.md#send) | **POST** /v3/alipay/open/public/message/label/send | 根据标签组发消息接口


<a name="send"></a>
# **Send**
> Object Send (AlipayOpenPublicMessageLabelSendModel alipayOpenPublicMessageLabelSendModel = null)

根据标签组发消息接口

开发者可以通过标签运算圈定一批用户，并且向这批用户推送消息。关于标签组发有以下注意点：  除了商户自定义标签，还支持支付宝用户标签，我们将陆续开放用户画像标签，目前支持的支付宝标签及说明请查看支付宝开放标签；  用户及标签数据有1天的缓存时间，即昨天开发者给M用户打了a标签，今天给有a标签的用户组发消息，M能够收到消息；但是如果开发者今天给M用户打了a标签，然后向有a标签的用户组发消息，M不能收到消息；  与群发消息接口类似，该接口调用之后，消息发送系统会处理一段时间，调用接口到发送成功存在一定的时延，几分钟到半个小时不等；  对于同一个用户而言，一周只能收到一条群发或者标签组发的消息；  消息组发接口一周最多调用5次。

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
            var apiInstance = new AlipayOpenPublicMessageLabelApi(config);

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

            var alipayOpenPublicMessageLabelSendModel = new AlipayOpenPublicMessageLabelSendModel(); // AlipayOpenPublicMessageLabelSendModel |  (optional) 

            try
            {
                // 根据标签组发消息接口
                Object result = apiInstance.Send(alipayOpenPublicMessageLabelSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicMessageLabelApi.Send: " + e.Message );
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
 **alipayOpenPublicMessageLabelSendModel** | **AlipayOpenPublicMessageLabelSendModel**|  | [optional] 

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

