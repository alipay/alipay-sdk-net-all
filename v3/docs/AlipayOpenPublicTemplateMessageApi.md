# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicTemplateMessageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](AlipayOpenPublicTemplateMessageApi.md#get) | **GET** /v3/alipay/open/public/template/message/get | 消息模板领取接口


<a name="get"></a>
# **Get**
> AlipayOpenPublicTemplateMessageGetResponseModel Get (string templateId = null)

消息模板领取接口

帮助服务窗开发者从服务窗平台（fuwu.alipay.com）公共模板库里领取一个行业的消息模板- -消息模板是一种消息的样式，如消费提醒、账单提醒等，主要用于isv帮助商户领取消息模板。

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
            var apiInstance = new AlipayOpenPublicTemplateMessageApi(config);

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

            var templateId = TM000000223;  // string | 消息母板id，登陆生活号后台(fuwu.alipay.com)，点击菜单“模板消息”，点击“模板库”，即可看到相应模板的消息母板id (optional) 

            try
            {
                // 消息模板领取接口
                AlipayOpenPublicTemplateMessageGetResponseModel result = apiInstance.Get(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicTemplateMessageApi.Get: " + e.Message );
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
 **templateId** | **string**| 消息母板id，登陆生活号后台(fuwu.alipay.com)，点击菜单“模板消息”，点击“模板库”，即可看到相应模板的消息母板id | [optional] 

### Return type

**AlipayOpenPublicTemplateMessageGetResponseModel**

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

