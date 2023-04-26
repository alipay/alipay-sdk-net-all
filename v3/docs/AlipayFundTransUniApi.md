# AlipaySDKNet.OpenAPI.Api.AlipayFundTransUniApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Transfer**](AlipayFundTransUniApi.md#transfer) | **POST** /v3/alipay/fund/trans/uni/transfer | 单笔转账接口


<a name="transfer"></a>
# **Transfer**
> AlipayFundTransUniTransferResponseModel Transfer (AlipayFundTransUniTransferModel alipayFundTransUniTransferModel = null)

单笔转账接口

单笔转账接口是基于支付宝的资金处理能力，为了满足支付宝商家的转账需求，针对有部分开发能力的商家，提供通过API接口完成企业自身支付宝账户到支付宝账户的转账功能。 适用于：C2C现金红包的红包领取、B2C现金红包的红包发放、B2C单笔转账到支付宝账户等。<br /> <b>说明：本接口为公用接口，参数说明不针对特定产品。</b>不同产品入参请参考对应产品文档。

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
            var apiInstance = new AlipayFundTransUniApi(config);

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

            var alipayFundTransUniTransferModel = new AlipayFundTransUniTransferModel(); // AlipayFundTransUniTransferModel |  (optional) 

            try
            {
                // 单笔转账接口
                AlipayFundTransUniTransferResponseModel result = apiInstance.Transfer(alipayFundTransUniTransferModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundTransUniApi.Transfer: " + e.Message );
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
 **alipayFundTransUniTransferModel** | **AlipayFundTransUniTransferModel**|  | [optional] 

### Return type

**AlipayFundTransUniTransferResponseModel**

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

