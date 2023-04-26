# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcEnterpriseAgreementApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceEcEnterpriseAgreementApi.md#query) | **GET** /v3/alipay/commerce/ec/enterprise/agreement | 查询企业签约企业码信息


<a name="query"></a>
# **Query**
> AlipayCommerceEcEnterpriseAgreementQueryResponseModel Query (string enterpriseId = null, string accountId = null)

查询企业签约企业码信息

查询企业签约企业码信息

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
            var apiInstance = new AlipayCommerceEcEnterpriseAgreementApi(config);

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

            var enterpriseId = 2088441399627416;  // string | 企业id；enterprise_id与account_id至少传一个，如果都传了优先使用enterprise_id (optional) 
            var accountId = 2088610274867962;  // string | 资金共同账号id；enterprise_id与account_id至少传一个，如果都传了优先使用enterprise_id (optional) 

            try
            {
                // 查询企业签约企业码信息
                AlipayCommerceEcEnterpriseAgreementQueryResponseModel result = apiInstance.Query(enterpriseId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseAgreementApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id；enterprise_id与account_id至少传一个，如果都传了优先使用enterprise_id | [optional] 
 **accountId** | **string**| 资金共同账号id；enterprise_id与account_id至少传一个，如果都传了优先使用enterprise_id | [optional] 

### Return type

**AlipayCommerceEcEnterpriseAgreementQueryResponseModel**

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

