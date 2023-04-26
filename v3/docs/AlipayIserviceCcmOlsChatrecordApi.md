# AlipaySDKNet.OpenAPI.Api.AlipayIserviceCcmOlsChatrecordApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayIserviceCcmOlsChatrecordApi.md#query) | **GET** /v3/alipay/iservice/ccm/ols/chatrecord/query | 查询某通在线服务的聊天记录


<a name="query"></a>
# **Query**
> AlipayIserviceCcmOlsChatrecordQueryResponseModel Query (string ccsInstanceId = null, string id = null)

查询某通在线服务的聊天记录

ISV或商户根据在线服务记录id查询该通对话的聊天记录及相关信息

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
            var apiInstance = new AlipayIserviceCcmOlsChatrecordApi(config);

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

            var ccsInstanceId = ZPSDWACN;  // string | 租户实例id（数据权限id），不填，则使用默认的租户实例id (optional) 
            var id = 201909021113010100000001922200;  // string | 在线服务记录id (optional) 

            try
            {
                // 查询某通在线服务的聊天记录
                AlipayIserviceCcmOlsChatrecordQueryResponseModel result = apiInstance.Query(ccsInstanceId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayIserviceCcmOlsChatrecordApi.Query: " + e.Message );
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
 **ccsInstanceId** | **string**| 租户实例id（数据权限id），不填，则使用默认的租户实例id | [optional] 
 **id** | **string**| 在线服务记录id | [optional] 

### Return type

**AlipayIserviceCcmOlsChatrecordQueryResponseModel**

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

