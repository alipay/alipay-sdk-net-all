# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCardActivateformApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayMarketingCardActivateformApi.md#query) | **GET** /v3/alipay/marketing/card/activateform/query | 查询用户提交的会员卡表单信息


<a name="query"></a>
# **Query**
> AlipayMarketingCardActivateformQueryResponseModel Query (string authToken = null, string bizType = null, string templateId = null, string requestId = null)

查询用户提交的会员卡表单信息

会员卡开卡场景下，用户确认领卡后，跳转到商户开卡处理页面，商户通过该接口查询用户表单信息。

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
            var apiInstance = new AlipayMarketingCardActivateformApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var bizType = MEMBER_CARD;  // string | 开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 (optional) 
            var templateId = 2071828288283883;  // string | 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 (optional) 
            var requestId = 2017021929993993992839493394;  // string | 查询用户表单提交信息的请求id。  网页移动应用&小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 (optional) 

            try
            {
                // 查询用户提交的会员卡表单信息
                AlipayMarketingCardActivateformQueryResponseModel result = apiInstance.Query(authToken, bizType, templateId, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardActivateformApi.Query: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **bizType** | **string**| 开放表单信息查询业务类型，可选类型如下： MEMBER_CARD ：商家会员卡开卡 | [optional] 
 **templateId** | **string**| 会员卡模板id。使用会员卡模板创建接口(alipay.marketing.card.template.create)返回的结果 | [optional] 
 **requestId** | **string**| 查询用户表单提交信息的请求id。  网页移动应用&amp;小程序应用：与auth_code 一起通过alipay.marketing.card.activateurl.apply(获取会员卡领卡投放链接)接口callback地址回传。  注意：auth_code（用户授权码）用于换取用户授权令牌 accessToken，后续调用接口需传入accessToken。 | [optional] 

### Return type

**AlipayMarketingCardActivateformQueryResponseModel**

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

