# AlipaySDKNet.OpenAPI.Api.AlipayIserviceCcmRolePageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayIserviceCcmRolePageApi.md#query) | **GET** /v3/alipay/iservice/ccm/role/page/query | 分页查询角色


<a name="query"></a>
# **Query**
> AlipayIserviceCcmRolePageQueryResponseModel Query (string name = null, int? pageNum = null, int? pageSize = null, string ccsInstanceId = null)

分页查询角色

分页查询角色

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
            var apiInstance = new AlipayIserviceCcmRolePageApi(config);

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

            var name = 普通客服;  // string | 角色名称 (optional) 
            var pageNum = 1;  // int? | 查询结果的页码，起始值为 1，默认值为 1 (optional) 
            var pageSize = 10;  // int? | 分页查询时设置的每页记录数，最大值 100 行，默认为 10 (optional) 
            var ccsInstanceId = kaj_9DA1;  // string | 部门id（即租户实例ID、数据权限ID） (optional) 

            try
            {
                // 分页查询角色
                AlipayIserviceCcmRolePageQueryResponseModel result = apiInstance.Query(name, pageNum, pageSize, ccsInstanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayIserviceCcmRolePageApi.Query: " + e.Message );
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
 **name** | **string**| 角色名称 | [optional] 
 **pageNum** | **int?**| 查询结果的页码，起始值为 1，默认值为 1 | [optional] 
 **pageSize** | **int?**| 分页查询时设置的每页记录数，最大值 100 行，默认为 10 | [optional] 
 **ccsInstanceId** | **string**| 部门id（即租户实例ID、数据权限ID） | [optional] 

### Return type

**AlipayIserviceCcmRolePageQueryResponseModel**

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

