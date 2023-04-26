# AlipaySDKNet.OpenAPI.Api.AlipayOpenAgentSignstatusApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenAgentSignstatusApi.md#query) | **POST** /v3/alipay/open/agent/signstatus/query | 查询商户某个产品的签约状态


<a name="query"></a>
# **Query**
> AlipayOpenAgentSignstatusQueryResponseModel Query (AlipayOpenAgentSignstatusQueryModel alipayOpenAgentSignstatusQueryModel = null)

查询商户某个产品的签约状态

主要用在isv代理商户签约场景，用来查询商户签约某个产品的签约状态，可以配合\"第三方接入核心API\"功能包里的接口使用

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
            var apiInstance = new AlipayOpenAgentSignstatusApi(config);

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

            var alipayOpenAgentSignstatusQueryModel = new AlipayOpenAgentSignstatusQueryModel(); // AlipayOpenAgentSignstatusQueryModel |  (optional) 

            try
            {
                // 查询商户某个产品的签约状态
                AlipayOpenAgentSignstatusQueryResponseModel result = apiInstance.Query(alipayOpenAgentSignstatusQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAgentSignstatusApi.Query: " + e.Message );
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
 **alipayOpenAgentSignstatusQueryModel** | **AlipayOpenAgentSignstatusQueryModel**|  | [optional] 

### Return type

**AlipayOpenAgentSignstatusQueryResponseModel**

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

