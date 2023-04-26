# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcEmployeeIdlistApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceEcEmployeeIdlistApi.md#query) | **GET** /v3/alipay/commerce/ec/employee/idlist/query | 查询部门下员工id列表


<a name="query"></a>
# **Query**
> AlipayCommerceEcEmployeeIdlistQueryResponseModel Query (string enterpriseId = null, string departmentId = null, int? pageNum = null, int? pageSize = null)

查询部门下员工id列表

查询某个部门下员工id列表

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
            var apiInstance = new AlipayCommerceEcEmployeeIdlistApi(config);

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

            var enterpriseId = 2088441363102941;  // string | 企业id (optional) 
            var departmentId = 1001094000039142;  // string | 部门id (optional) 
            var pageNum = 1;  // int? | 查询页数 (optional) 
            var pageSize = 1000;  // int? | 每页查询大小，限制最大为1000 (optional) 

            try
            {
                // 查询部门下员工id列表
                AlipayCommerceEcEmployeeIdlistQueryResponseModel result = apiInstance.Query(enterpriseId, departmentId, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEmployeeIdlistApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id | [optional] 
 **departmentId** | **string**| 部门id | [optional] 
 **pageNum** | **int?**| 查询页数 | [optional] 
 **pageSize** | **int?**| 每页查询大小，限制最大为1000 | [optional] 

### Return type

**AlipayCommerceEcEmployeeIdlistQueryResponseModel**

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

