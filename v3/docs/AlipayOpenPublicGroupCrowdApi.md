# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicGroupCrowdApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenPublicGroupCrowdApi.md#query) | **POST** /v3/alipay/open/public/group/crowd/query | 人群数量查询


<a name="query"></a>
# **Query**
> AlipayOpenPublicGroupCrowdQueryResponseModel Query (AlipayOpenPublicGroupCrowdQueryModel alipayOpenPublicGroupCrowdQueryModel = null)

人群数量查询

用户可以指定自己创建的分组，调用接口查询对应的人群数量，人群必须大于50人才能正常返回，否则报错。

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
            var apiInstance = new AlipayOpenPublicGroupCrowdApi(config);

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

            var alipayOpenPublicGroupCrowdQueryModel = new AlipayOpenPublicGroupCrowdQueryModel(); // AlipayOpenPublicGroupCrowdQueryModel |  (optional) 

            try
            {
                // 人群数量查询
                AlipayOpenPublicGroupCrowdQueryResponseModel result = apiInstance.Query(alipayOpenPublicGroupCrowdQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicGroupCrowdApi.Query: " + e.Message );
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
 **alipayOpenPublicGroupCrowdQueryModel** | **AlipayOpenPublicGroupCrowdQueryModel**|  | [optional] 

### Return type

**AlipayOpenPublicGroupCrowdQueryResponseModel**

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

