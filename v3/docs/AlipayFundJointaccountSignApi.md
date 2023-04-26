# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountSignApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundJointaccountSignApi.md#query) | **GET** /v3/alipay/fund/jointaccount/sign/query | 企业签约结果查询


<a name="query"></a>
# **Query**
> AlipayFundJointaccountSignQueryResponseModel Query (string productCode = null, string bizScene = null, string outBizNo = null, string accountId = null)

企业签约结果查询

通过外部订单号（out_biz_no）主动查询企业签约结果，可用于未收到签约结果通知的补偿操作

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
            var apiInstance = new AlipayFundJointaccountSignApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 产品码，默认值 ENTERPRISE_PAY (optional) 
            var bizScene = ISV_ALIYUN;  // string | 场景码，联系支付宝分配 (optional) 
            var outBizNo = 123123132;  // string | 外部业务号，查询对应账户状态，优先级高于account_id (optional) 
            var accountId = 208812312313213;  // string | 企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态 (optional) 

            try
            {
                // 企业签约结果查询
                AlipayFundJointaccountSignQueryResponseModel result = apiInstance.Query(productCode, bizScene, outBizNo, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountSignApi.Query: " + e.Message );
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
 **productCode** | **string**| 产品码，默认值 ENTERPRISE_PAY | [optional] 
 **bizScene** | **string**| 场景码，联系支付宝分配 | [optional] 
 **outBizNo** | **string**| 外部业务号，查询对应账户状态，优先级高于account_id | [optional] 
 **accountId** | **string**| 企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态 | [optional] 

### Return type

**AlipayFundJointaccountSignQueryResponseModel**

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

