# AlipaySDKNet.OpenAPI.Api.AlipayOpenAuthUserauthRelationshipApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenAuthUserauthRelationshipApi.md#query) | **GET** /v3/alipay/open/auth/userauth/relationship/query | 用户授权关系查询


<a name="query"></a>
# **Query**
> AlipayOpenAuthUserauthRelationshipQueryResponseModel Query (string userId = null, string openId = null, string scopes = null)

用户授权关系查询

校验本应用和用户的授权关系有效性

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
            var apiInstance = new AlipayOpenAuthUserauthRelationshipApi(config);

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

            var userId = 2088123443211234;  // string | 蚂蚁统一会员ID，如果未开启openid改造，则此值必传 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 蚂蚁统一会员ID，蚂蚁统一会员ID，如果已完成openid改造，则此值必传 (optional) 
            var scopes = auth_user,auth_zhima;  // string | 查询授权关系所关联的scope，半角逗号分隔的列表，且不允许有重复值 (optional) 

            try
            {
                // 用户授权关系查询
                AlipayOpenAuthUserauthRelationshipQueryResponseModel result = apiInstance.Query(userId, openId, scopes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAuthUserauthRelationshipApi.Query: " + e.Message );
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
 **userId** | **string**| 蚂蚁统一会员ID，如果未开启openid改造，则此值必传 | [optional] 
 **openId** | **string**| 蚂蚁统一会员ID，蚂蚁统一会员ID，如果已完成openid改造，则此值必传 | [optional] 
 **scopes** | **string**| 查询授权关系所关联的scope，半角逗号分隔的列表，且不允许有重复值 | [optional] 

### Return type

**AlipayOpenAuthUserauthRelationshipQueryResponseModel**

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

