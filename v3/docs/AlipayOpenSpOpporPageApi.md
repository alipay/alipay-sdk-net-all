# AlipaySDKNet.OpenAPI.Api.AlipayOpenSpOpporPageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenSpOpporPageApi.md#query) | **GET** /v3/alipay/open/sp/oppor/page/query | 商机作业列表查询


<a name="query"></a>
# **Query**
> AlipayOpenSpOpporPageQueryResponseModel Query (string isvPid = null, string statusList = null, string pageSize = null, string pageNum = null)

商机作业列表查询

商机作业列表查询

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
            var apiInstance = new AlipayOpenSpOpporPageApi(config);

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

            var isvPid = 2088302213873401;  // string | 服务商pid (optional) 
            var statusList = WAIT_MER_CONFIRM,MER_CONFIRMED,MER_REJECTED,EXPANDING,EXPANDED,EXPAND_FAILED;  // string | 作业记录状态列表,以,拼接传入 (optional) 
            var pageSize = 10;  // string | 页大小 (optional) 
            var pageNum = 1;  // string | 页数 (optional) 

            try
            {
                // 商机作业列表查询
                AlipayOpenSpOpporPageQueryResponseModel result = apiInstance.Query(isvPid, statusList, pageSize, pageNum);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSpOpporPageApi.Query: " + e.Message );
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
 **isvPid** | **string**| 服务商pid | [optional] 
 **statusList** | **string**| 作业记录状态列表,以,拼接传入 | [optional] 
 **pageSize** | **string**| 页大小 | [optional] 
 **pageNum** | **string**| 页数 | [optional] 

### Return type

**AlipayOpenSpOpporPageQueryResponseModel**

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

