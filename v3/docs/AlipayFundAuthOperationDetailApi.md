# AlipaySDKNet.OpenAPI.Api.AlipayFundAuthOperationDetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundAuthOperationDetailApi.md#query) | **POST** /v3/alipay/fund/auth/operation/detail/query | 资金授权操作查询接口


<a name="query"></a>
# **Query**
> AlipayFundAuthOperationDetailQueryResponseModel Query (AlipayFundAuthOperationDetailQueryModel alipayFundAuthOperationDetailQueryModel = null)

资金授权操作查询接口

通过该接口可以查询单笔明细的详细信息

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
            var apiInstance = new AlipayFundAuthOperationDetailApi(config);

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

            var alipayFundAuthOperationDetailQueryModel = new AlipayFundAuthOperationDetailQueryModel(); // AlipayFundAuthOperationDetailQueryModel |  (optional) 

            try
            {
                // 资金授权操作查询接口
                AlipayFundAuthOperationDetailQueryResponseModel result = apiInstance.Query(alipayFundAuthOperationDetailQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAuthOperationDetailApi.Query: " + e.Message );
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
 **alipayFundAuthOperationDetailQueryModel** | **AlipayFundAuthOperationDetailQueryModel**|  | [optional] 

### Return type

**AlipayFundAuthOperationDetailQueryResponseModel**

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

