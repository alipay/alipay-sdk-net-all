# AlipaySDKNet.OpenAPI.Api.AlipayFundTransPayeeBindApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundTransPayeeBindApi.md#query) | **GET** /v3/alipay/fund/trans/payee/bind/query | 资金收款账号绑定关系查询


<a name="query"></a>
# **Query**
> AlipayFundTransPayeeBindQueryResponseModel Query (string identity = null, string identityType = null)

资金收款账号绑定关系查询

资金收款账号绑定关系查询

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
            var apiInstance = new AlipayFundTransPayeeBindApi(config);

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

            var identity = 230100199901010001;  // string | 证件号 (optional) 
            var identityType = IDENTITY_CARD;  // string | 证件类型,暂仅支持 IDENTITY_CARD （身份证） (optional) 

            try
            {
                // 资金收款账号绑定关系查询
                AlipayFundTransPayeeBindQueryResponseModel result = apiInstance.Query(identity, identityType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundTransPayeeBindApi.Query: " + e.Message );
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
 **identity** | **string**| 证件号 | [optional] 
 **identityType** | **string**| 证件类型,暂仅支持 IDENTITY_CARD （身份证） | [optional] 

### Return type

**AlipayFundTransPayeeBindQueryResponseModel**

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

