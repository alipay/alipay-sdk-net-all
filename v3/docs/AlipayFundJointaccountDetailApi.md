# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountDetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundJointaccountDetailApi.md#query) | **GET** /v3/alipay/fund/jointaccount/detail/query | 共享资金-查询账户详情


<a name="query"></a>
# **Query**
> AlipayFundJointaccountDetailQueryResponseModel Query (string productCode = null, string bizScene = null, string accountId = null, string agreementNo = null, string outBizNo = null, string channel = null)

共享资金-查询账户详情

发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。

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
            var apiInstance = new AlipayFundJointaccountDetailApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 销售产品码 (optional) 
            var bizScene = DEFAULT;  // string | 业务场景码 (optional) 
            var accountId = 2088xxx;  // string | 合花群ID（查询方式二：通过传入account_id+agreement_no查询）<br> 补充说明：<br> -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。<br> -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional) 
            var agreementNo = 2088xxx;  // string | 授权协议号（查询方式二：通过传入account_id+agreement_no查询）<br> 补充说明：<br> -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。<br> -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional) 
            var outBizNo = 无;  // string | 商户侧单号（查询方式一：通过传入 out_biz_no查询）<br> 补充说明：<br> -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional) 
            var channel = MMJZ;  // string | 业务渠道</br> 补充说明：</br> 需要商户侧必传，支付宝侧不做强校验 (optional) 

            try
            {
                // 共享资金-查询账户详情
                AlipayFundJointaccountDetailQueryResponseModel result = apiInstance.Query(productCode, bizScene, accountId, agreementNo, outBizNo, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountDetailApi.Query: " + e.Message );
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
 **productCode** | **string**| 销售产品码 | [optional] 
 **bizScene** | **string**| 业务场景码 | [optional] 
 **accountId** | **string**| 合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 | [optional] 
 **agreementNo** | **string**| 授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 | [optional] 
 **outBizNo** | **string**| 商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 | [optional] 
 **channel** | **string**| 业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 | [optional] 

### Return type

**AlipayFundJointaccountDetailQueryResponseModel**

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

