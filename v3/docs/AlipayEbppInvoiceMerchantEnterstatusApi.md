# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceMerchantEnterstatusApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceMerchantEnterstatusApi.md#query) | **GET** /v3/alipay/ebpp/invoice/merchant/enterstatus/query | 商户入驻流程状态查询


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceMerchantEnterstatusQueryResponseModel Query (string mShortName = null, string productCode = null, string processId = null)

商户入驻流程状态查询

提供给替商户批量入驻的服务商，主动查询入驻流程的状态。

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
            var apiInstance = new AlipayEbppInvoiceMerchantEnterstatusApi(config);

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

            var mShortName = MYJF;  // string | 商户品牌简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。 (optional) 
            var productCode = STANDARD_INVOICE;  // string | 商户门店入驻的产品码,STANDARD_INVOICE:扫码开票，INVOICE_RETURN:企业自建-发票回传，INVOICE_EXPENSE:发票报销，PAYMENT_OPEN:支付即开票，PAY_FEE_OPEN:缴费后开票。 (optional) 
            var processId = 1234567;  // string | 工单流水号（如果不填则默认查询最近一条工单） (optional) 

            try
            {
                // 商户入驻流程状态查询
                AlipayEbppInvoiceMerchantEnterstatusQueryResponseModel result = apiInstance.Query(mShortName, productCode, processId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceMerchantEnterstatusApi.Query: " + e.Message );
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
 **mShortName** | **string**| 商户品牌简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。 | [optional] 
 **productCode** | **string**| 商户门店入驻的产品码,STANDARD_INVOICE:扫码开票，INVOICE_RETURN:企业自建-发票回传，INVOICE_EXPENSE:发票报销，PAYMENT_OPEN:支付即开票，PAY_FEE_OPEN:缴费后开票。 | [optional] 
 **processId** | **string**| 工单流水号（如果不填则默认查询最近一条工单） | [optional] 

### Return type

**AlipayEbppInvoiceMerchantEnterstatusQueryResponseModel**

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

