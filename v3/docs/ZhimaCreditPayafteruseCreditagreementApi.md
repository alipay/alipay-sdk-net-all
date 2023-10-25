# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPayafteruseCreditagreementApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](ZhimaCreditPayafteruseCreditagreementApi.md#query) | **GET** /v3/zhima/credit/payafteruse/creditagreement/query | 查询服务开通/授权信息
[**Transfer**](ZhimaCreditPayafteruseCreditagreementApi.md#transfer) | **POST** /v3/zhima/credit/payafteruse/creditagreement/transfer | 芝麻信用服务授权


<a name="query"></a>
# **Query**
> ZhimaCreditPayafteruseCreditagreementQueryResponseModel Query (string outAgreementNo = null, string creditAgreementId = null)

查询服务开通/授权信息

使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。

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
            var apiInstance = new ZhimaCreditPayafteruseCreditagreementApi(config);

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

            var outAgreementNo = 2014070700166653;  // string | 商户外部协议号 (optional) 
            var creditAgreementId = ZMOP2020050722001440;  // string | 芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional) 

            try
            {
                // 查询服务开通/授权信息
                ZhimaCreditPayafteruseCreditagreementQueryResponseModel result = apiInstance.Query(outAgreementNo, creditAgreementId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPayafteruseCreditagreementApi.Query: " + e.Message );
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
 **outAgreementNo** | **string**| 商户外部协议号 | [optional] 
 **creditAgreementId** | **string**| 芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 | [optional] 

### Return type

**ZhimaCreditPayafteruseCreditagreementQueryResponseModel**

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

<a name="transfer"></a>
# **Transfer**
> ZhimaCreditPayafteruseCreditagreementTransferResponseModel Transfer (ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = null)

芝麻信用服务授权

其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权

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
            var apiInstance = new ZhimaCreditPayafteruseCreditagreementApi(config);

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

            var zhimaCreditPayafteruseCreditagreementTransferModel = new ZhimaCreditPayafteruseCreditagreementTransferModel(); // ZhimaCreditPayafteruseCreditagreementTransferModel |  (optional) 

            try
            {
                // 芝麻信用服务授权
                ZhimaCreditPayafteruseCreditagreementTransferResponseModel result = apiInstance.Transfer(zhimaCreditPayafteruseCreditagreementTransferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPayafteruseCreditagreementApi.Transfer: " + e.Message );
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
 **zhimaCreditPayafteruseCreditagreementTransferModel** | **ZhimaCreditPayafteruseCreditagreementTransferModel**|  | [optional] 

### Return type

**ZhimaCreditPayafteruseCreditagreementTransferResponseModel**

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

