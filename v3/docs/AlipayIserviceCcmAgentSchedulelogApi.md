# AlipaySDKNet.OpenAPI.Api.AlipayIserviceCcmAgentSchedulelogApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayIserviceCcmAgentSchedulelogApi.md#query) | **POST** /v3/alipay/iservice/ccm/agent/schedulelog/query | 查询客服状态变更流水日志


<a name="query"></a>
# **Query**
> AlipayIserviceCcmAgentSchedulelogQueryResponseModel Query (AlipayIserviceCcmAgentSchedulelogQueryModel alipayIserviceCcmAgentSchedulelogQueryModel = null)

查询客服状态变更流水日志

ISV或商户批量查询获取客服状态变更流水日志详细信息

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
            var apiInstance = new AlipayIserviceCcmAgentSchedulelogApi(config);

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

            var alipayIserviceCcmAgentSchedulelogQueryModel = new AlipayIserviceCcmAgentSchedulelogQueryModel(); // AlipayIserviceCcmAgentSchedulelogQueryModel |  (optional) 

            try
            {
                // 查询客服状态变更流水日志
                AlipayIserviceCcmAgentSchedulelogQueryResponseModel result = apiInstance.Query(alipayIserviceCcmAgentSchedulelogQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayIserviceCcmAgentSchedulelogApi.Query: " + e.Message );
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
 **alipayIserviceCcmAgentSchedulelogQueryModel** | **AlipayIserviceCcmAgentSchedulelogQueryModel**|  | [optional] 

### Return type

**AlipayIserviceCcmAgentSchedulelogQueryResponseModel**

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

