# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicUserDataApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenPublicUserDataApi.md#batchquery) | **POST** /v3/alipay/open/public/user/data/batchquery | 用户分析数据查询接口


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenPublicUserDataBatchqueryResponseModel Batchquery (AlipayOpenPublicUserDataBatchqueryModel alipayOpenPublicUserDataBatchqueryModel = null)

用户分析数据查询接口

通过此接口，开发者可以根据时间查询30天内的关注用户人数、取消关注用户人数、净增关注人数、累计关注人数信息

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenPublicUserDataApi(config);

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

            var alipayOpenPublicUserDataBatchqueryModel = new AlipayOpenPublicUserDataBatchqueryModel(); // AlipayOpenPublicUserDataBatchqueryModel |  (optional) 

            try
            {
                // 用户分析数据查询接口
                AlipayOpenPublicUserDataBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenPublicUserDataBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicUserDataApi.Batchquery: " + e.Message );
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
 **alipayOpenPublicUserDataBatchqueryModel** | **AlipayOpenPublicUserDataBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenPublicUserDataBatchqueryResponseModel**

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

