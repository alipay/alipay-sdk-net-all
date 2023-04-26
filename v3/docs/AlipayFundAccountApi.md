# AlipaySDKNet.OpenAPI.Api.AlipayFundAccountApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundAccountApi.md#query) | **GET** /v3/alipay/fund/account/query | 支付宝资金账户资产查询接口


<a name="query"></a>
# **Query**
> AlipayFundAccountQueryResponseModel Query (string merchantUserId = null, string alipayUserId = null, string alipayOpenId = null, string accountProductCode = null, string accountType = null, string accountSceneCode = null, string extInfo = null)

支付宝资金账户资产查询接口

可查询请求方的支付宝账户余额信息。

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
            var apiInstance = new AlipayFundAccountApi(config);

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

            var merchantUserId = 243893499;  // string | 商户会员的唯一标识。如果传入的user_id为虚拟账户userId，此字段必传并比对一致性。 (optional) 
            var alipayUserId = 2088301409188095;  // string | 支付宝会员 id。 (optional) 
            var alipayOpenId = 061P6NAblcWDWJoDRxSVvOYz-ufp-3wQaA4E_szQyMFTXse;  // string | 支付宝openId (optional) 
            var accountProductCode = DING_ACCOUNT;  // string | 开户产品码。如果查询托管子户余额，必传且必须传入与开户时传入的值一致。 (optional) 
            var accountType = ACCTRANS_ACCOUNT;  // string | 查询的账号类型，查询余额账户值为ACCTRANS_ACCOUNT。必填。 (optional) 
            var accountSceneCode = SCENE_000_000_000;  // string | 开户场景码，与开户产品码不可同时传递。 (optional) 
            var extInfo = {"agreement_no":"2019000000000"};  // string | JSON格式，传递业务扩展参数。 (optional) 

            try
            {
                // 支付宝资金账户资产查询接口
                AlipayFundAccountQueryResponseModel result = apiInstance.Query(merchantUserId, alipayUserId, alipayOpenId, accountProductCode, accountType, accountSceneCode, extInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAccountApi.Query: " + e.Message );
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
 **merchantUserId** | **string**| 商户会员的唯一标识。如果传入的user_id为虚拟账户userId，此字段必传并比对一致性。 | [optional] 
 **alipayUserId** | **string**| 支付宝会员 id。 | [optional] 
 **alipayOpenId** | **string**| 支付宝openId | [optional] 
 **accountProductCode** | **string**| 开户产品码。如果查询托管子户余额，必传且必须传入与开户时传入的值一致。 | [optional] 
 **accountType** | **string**| 查询的账号类型，查询余额账户值为ACCTRANS_ACCOUNT。必填。 | [optional] 
 **accountSceneCode** | **string**| 开户场景码，与开户产品码不可同时传递。 | [optional] 
 **extInfo** | **string**| JSON格式，传递业务扩展参数。 | [optional] 

### Return type

**AlipayFundAccountQueryResponseModel**

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

