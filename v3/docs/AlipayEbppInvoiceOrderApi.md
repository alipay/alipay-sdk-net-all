# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceOrderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceOrderApi.md#query) | **GET** /v3/alipay/ebpp/invoice/order/query | 根据外部订单号查询发票信息


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceOrderQueryResponseModel Query (string orderNo = null, string mShortName = null, string subMShortName = null)

根据外部订单号查询发票信息

根据外部订单号查询发票详情信息，适用于外部商户无开票申请ID场景

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
            var apiInstance = new AlipayEbppInvoiceOrderApi(config);

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

            var orderNo = 20200520110046966071;  // string | 开票申请时所传入订单号，不限于支付宝体内交易订单号。如：20200520110046966071 (optional) 
            var mShortName = KFC;  // string | 定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\"商户品牌简称\"。 如：肯德基：KFC (optional) 
            var subMShortName = KFC-HZ-19003;  // string | 定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\"商户门店简称\"。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\"商户品牌简称+商户门店简称\"作为确定商户及其下属机构的唯一标识，不可重复。 (optional) 

            try
            {
                // 根据外部订单号查询发票信息
                AlipayEbppInvoiceOrderQueryResponseModel result = apiInstance.Query(orderNo, mShortName, subMShortName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceOrderApi.Query: " + e.Message );
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
 **orderNo** | **string**| 开票申请时所传入订单号，不限于支付宝体内交易订单号。如：20200520110046966071 | [optional] 
 **mShortName** | **string**| 定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC | [optional] 
 **subMShortName** | **string**| 定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。 | [optional] 

### Return type

**AlipayEbppInvoiceOrderQueryResponseModel**

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

