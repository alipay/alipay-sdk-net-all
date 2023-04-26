# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountQuotaApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundJointaccountQuotaApi.md#query) | **GET** /v3/alipay/fund/jointaccount/quota/query | 查询账户额度详情


<a name="query"></a>
# **Query**
> AlipayFundJointaccountQuotaQueryResponseModel Query (string productCode = null, string bizScene = null, string accountId = null, string memberId = null, string memberOpenId = null, string operateRole = null, string agreementNo = null)

查询账户额度详情

查询账户额度详情

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
            var apiInstance = new AlipayFundJointaccountQuotaApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 产品码 (optional) 
            var bizScene = DEFAULT;  // string | 业务场景 (optional) 
            var accountId = 2088900976746215;  // string | 账户ID (optional) 
            var memberId = 2088900976746215;  // string | 员工ID (optional) 
            var memberOpenId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 员工的openid (optional) 
            var operateRole = CREATOR;  // string | 角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional) 
            var agreementNo = 208890097674621512312;  // string | 授权协议号 (optional) 

            try
            {
                // 查询账户额度详情
                AlipayFundJointaccountQuotaQueryResponseModel result = apiInstance.Query(productCode, bizScene, accountId, memberId, memberOpenId, operateRole, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountQuotaApi.Query: " + e.Message );
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
 **productCode** | **string**| 产品码 | [optional] 
 **bizScene** | **string**| 业务场景 | [optional] 
 **accountId** | **string**| 账户ID | [optional] 
 **memberId** | **string**| 员工ID | [optional] 
 **memberOpenId** | **string**| 员工的openid | [optional] 
 **operateRole** | **string**| 角色：创建方(CREATOR)、参与方(PARTICIPANT) | [optional] 
 **agreementNo** | **string**| 授权协议号 | [optional] 

### Return type

**AlipayFundJointaccountQuotaQueryResponseModel**

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

