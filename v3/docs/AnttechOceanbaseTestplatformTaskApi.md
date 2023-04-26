# AlipaySDKNet.OpenAPI.Api.AnttechOceanbaseTestplatformTaskApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AnttechOceanbaseTestplatformTaskApi.md#query) | **POST** /v3/anttech/oceanbase/testplatform/task/query | 获取ob开源官网提测平台待执行任务接口


<a name="query"></a>
# **Query**
> AnttechOceanbaseTestplatformTaskQueryResponseModel Query (AnttechOceanbaseTestplatformTaskQueryModel anttechOceanbaseTestplatformTaskQueryModel = null)

获取ob开源官网提测平台待执行任务接口

获取ob开源官网提测平台待执行任务接口，用于测试任务

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
            var apiInstance = new AnttechOceanbaseTestplatformTaskApi(config);

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

            var anttechOceanbaseTestplatformTaskQueryModel = new AnttechOceanbaseTestplatformTaskQueryModel(); // AnttechOceanbaseTestplatformTaskQueryModel |  (optional) 

            try
            {
                // 获取ob开源官网提测平台待执行任务接口
                AnttechOceanbaseTestplatformTaskQueryResponseModel result = apiInstance.Query(anttechOceanbaseTestplatformTaskQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AnttechOceanbaseTestplatformTaskApi.Query: " + e.Message );
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
 **anttechOceanbaseTestplatformTaskQueryModel** | **AnttechOceanbaseTestplatformTaskQueryModel**|  | [optional] 

### Return type

**AnttechOceanbaseTestplatformTaskQueryResponseModel**

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

