# AlipaySDKNet.OpenAPI.Api.AlipayPcreditHuabeiAuthAccumulationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayPcreditHuabeiAuthAccumulationApi.md#query) | **GET** /v3/alipay/pcredit/huabei/auth/accumulation/query | 花芝轻会员周期累计数据查询


<a name="query"></a>
# **Query**
> AlipayPcreditHuabeiAuthAccumulationQueryResponseModel Query (string agreementNo = null, string period = null, string alipayUserId = null, string openId = null)

花芝轻会员周期累计数据查询

根据协议与对应的周期查询支付宝累计数据。

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
            var apiInstance = new AlipayPcreditHuabeiAuthAccumulationApi(config);

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

            var agreementNo = 20170502000610755993;  // string | 支付宝系统中用以唯一标识用户签约记录的编号。 (optional) 
            var period = 20181223235059-20181230235010;  // string | 协议结算周期，使用支付宝端回传的周期信息。 (optional) 
            var alipayUserId = 2088101117955611;  // string | 买家在支付宝的用户id (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 买家在支付宝的用户id (optional) 

            try
            {
                // 花芝轻会员周期累计数据查询
                AlipayPcreditHuabeiAuthAccumulationQueryResponseModel result = apiInstance.Query(agreementNo, period, alipayUserId, openId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthAccumulationApi.Query: " + e.Message );
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
 **agreementNo** | **string**| 支付宝系统中用以唯一标识用户签约记录的编号。 | [optional] 
 **period** | **string**| 协议结算周期，使用支付宝端回传的周期信息。 | [optional] 
 **alipayUserId** | **string**| 买家在支付宝的用户id | [optional] 
 **openId** | **string**| 买家在支付宝的用户id | [optional] 

### Return type

**AlipayPcreditHuabeiAuthAccumulationQueryResponseModel**

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

