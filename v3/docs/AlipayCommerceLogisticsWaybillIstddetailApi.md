# AlipaySDKNet.OpenAPI.Api.AlipayCommerceLogisticsWaybillIstddetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceLogisticsWaybillIstddetailApi.md#query) | **GET** /v3/alipay/commerce/logistics/waybill/istddetail/query | 查询即时配送运单详情


<a name="query"></a>
# **Query**
> AlipayCommerceLogisticsWaybillIstddetailQueryResponseModel Query (string shopNo = null, string outOrderNo = null, string orderNo = null, string logisticsCode = null, string waybillNo = null)

查询即时配送运单详情

查询即时配送运单详情

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
            var apiInstance = new AlipayCommerceLogisticsWaybillIstddetailApi(config);

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

            var shopNo = shopno001;  // string | 商家门店编号 (optional) 
            var outOrderNo = 2020090411140000000000777000216122;  // string | 商家订单号 (optional) 
            var orderNo = 2020090411130000000000772400280352;  // string | 支付宝订单流水号 (optional) 
            var logisticsCode = FENGNIAO;  // string | 即时配送公司编码 (optional) 
            var waybillNo = waybillno001;  // string | 即时配送运单编号 (optional) 

            try
            {
                // 查询即时配送运单详情
                AlipayCommerceLogisticsWaybillIstddetailQueryResponseModel result = apiInstance.Query(shopNo, outOrderNo, orderNo, logisticsCode, waybillNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsWaybillIstddetailApi.Query: " + e.Message );
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
 **shopNo** | **string**| 商家门店编号 | [optional] 
 **outOrderNo** | **string**| 商家订单号 | [optional] 
 **orderNo** | **string**| 支付宝订单流水号 | [optional] 
 **logisticsCode** | **string**| 即时配送公司编码 | [optional] 
 **waybillNo** | **string**| 即时配送运单编号 | [optional] 

### Return type

**AlipayCommerceLogisticsWaybillIstddetailQueryResponseModel**

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

