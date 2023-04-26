# AlipaySDKNet.OpenAPI.Api.AlipayFundTransToaccountApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Transfer**](AlipayFundTransToaccountApi.md#transfer) | **POST** /v3/alipay/fund/trans/toaccount/transfer | 单笔转账到支付宝账户接口


<a name="transfer"></a>
# **Transfer**
> AlipayFundTransToaccountTransferResponseModel Transfer (AlipayFundTransToaccountTransferModel alipayFundTransToaccountTransferModel = null)

单笔转账到支付宝账户接口

单笔转账到支付宝账户接口是基于支付宝的资金处理能力，为了满足支付宝商家向其他支付宝账户转账的需求，针对有部分开发能力的商家，提供通过API接口完成支付宝账户间的转账的功能。 该接口适用行业较广，比如商家间的货款结算，商家给个人用户发放佣金等。（目前已对该接口能力做了升级，后续建议调用新接口alipay.fund.trans.uni.transfer）

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
    public class TransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundTransToaccountApi(config);

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

            var alipayFundTransToaccountTransferModel = new AlipayFundTransToaccountTransferModel(); // AlipayFundTransToaccountTransferModel |  (optional) 

            try
            {
                // 单笔转账到支付宝账户接口
                AlipayFundTransToaccountTransferResponseModel result = apiInstance.Transfer(alipayFundTransToaccountTransferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundTransToaccountApi.Transfer: " + e.Message );
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
 **alipayFundTransToaccountTransferModel** | **AlipayFundTransToaccountTransferModel**|  | [optional] 

### Return type

**AlipayFundTransToaccountTransferResponseModel**

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

