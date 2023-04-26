# AlipaySDKNet.OpenAPI.Api.AlipayTradeBatchTransferApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayTradeBatchTransferApi.md#query) | **GET** /v3/alipay/trade/batch/transfer/query | 请款分账查询接口


<a name="query"></a>
# **Query**
> AlipayTradeBatchTransferQueryResponseModel Query (string outRequestNo = null, string settleNo = null, string extendParams = null)

请款分账查询接口

针对请款分账接口的查询功能

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
            var apiInstance = new AlipayTradeBatchTransferApi(config);

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

            var outRequestNo = 20180101;  // string | 批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no (optional) 
            var settleNo = 2019050510032002040000053220;  // string | 结算单据号，与out_request_no二者必填其一 (optional) 
            var extendParams = {"key":"value"};  // string | 扩展字段 (optional) 

            try
            {
                // 请款分账查询接口
                AlipayTradeBatchTransferQueryResponseModel result = apiInstance.Query(outRequestNo, settleNo, extendParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeBatchTransferApi.Query: " + e.Message );
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
 **outRequestNo** | **string**| 批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no | [optional] 
 **settleNo** | **string**| 结算单据号，与out_request_no二者必填其一 | [optional] 
 **extendParams** | **string**| 扩展字段 | [optional] 

### Return type

**AlipayTradeBatchTransferQueryResponseModel**

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

