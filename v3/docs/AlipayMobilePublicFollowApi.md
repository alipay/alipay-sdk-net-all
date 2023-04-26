# AlipaySDKNet.OpenAPI.Api.AlipayMobilePublicFollowApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**List**](AlipayMobilePublicFollowApi.md#list) | **GET** /v3/alipay/mobile/public/follow/list | 获取关注者列表


<a name="list"></a>
# **List**
> AlipayMobilePublicFollowListResponseModel List (string bizContent = null)

获取关注者列表

公众号可通过本接口来获取帐号的关注者列表，关注者列表由一串userId组成。一次拉取调用最多拉取10000个关注者的userId，可以通过多次拉取的方式来满足需求。  公众号可通过本接口来获取帐号的关注者列表，关注者列表由一串userId组成。一次拉取调用最多拉取10000个关注者的userId，可以通过多次拉取的方式来满足需求。

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
    public class ListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMobilePublicFollowApi(config);

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

            var bizContent = {"nextUserId":"2088102123322367"};  // string | 当nextUserId为空时,代表查询第一组,如果有值时以当前值为准查询下一组  <a href=\"https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7386797.0.0.eZqycg&treeId=53&articleId=103525&docType=1\">详情请见</a> (optional) 

            try
            {
                // 获取关注者列表
                AlipayMobilePublicFollowListResponseModel result = apiInstance.List(bizContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMobilePublicFollowApi.List: " + e.Message );
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
 **bizContent** | **string**| 当nextUserId为空时,代表查询第一组,如果有值时以当前值为准查询下一组  &lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7386797.0.0.eZqycg&amp;treeId&#x3D;53&amp;articleId&#x3D;103525&amp;docType&#x3D;1\&quot;&gt;详情请见&lt;/a&gt; | [optional] 

### Return type

**AlipayMobilePublicFollowListResponseModel**

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

