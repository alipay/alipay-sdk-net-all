# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicUserFollowApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenPublicUserFollowApi.md#query) | **GET** /v3/alipay/open/public/user/follow/query | 查询用户是否已经关注了生活号


<a name="query"></a>
# **Query**
> AlipayOpenPublicUserFollowQueryResponseModel Query (string userId = null, string openId = null)

查询用户是否已经关注了生活号

查询用户是否已经关注生活号，支持生活号、内容号、财富号

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
            var apiInstance = new AlipayOpenPublicUserFollowApi(config);

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

            var userId = 2088132324342243;  // string | 支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 支付宝用户唯一的标识 (optional) 

            try
            {
                // 查询用户是否已经关注了生活号
                AlipayOpenPublicUserFollowQueryResponseModel result = apiInstance.Query(userId, openId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicUserFollowApi.Query: " + e.Message );
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
 **userId** | **string**| 支付宝用户id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 | [optional] 
 **openId** | **string**| 支付宝用户唯一的标识 | [optional] 

### Return type

**AlipayOpenPublicUserFollowQueryResponseModel**

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

