# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcBalanceDownloadurlApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceEcBalanceDownloadurlApi.md#query) | **GET** /v3/alipay/commerce/ec/balance/downloadurl/query | 对账单文件下载接口


<a name="query"></a>
# **Query**
> AlipayCommerceEcBalanceDownloadurlQueryResponseModel Query (string enterpriseId = null, string accountId = null, string agreementNo = null, string billType = null, string billDate = null)

对账单文件下载接口

对账单文件下载接口

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
            var apiInstance = new AlipayCommerceEcBalanceDownloadurlApi(config);

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

            var enterpriseId = 100000000000001000921;  // string | 企业ID (optional) 
            var accountId = 2088000295356628;  // string | 共同账户ID，没有企业ID可以用此ID查询 (optional) 
            var agreementNo = 20205820659822371223;  // string | 授权签约协议号，以共同账户ID查询时必传 (optional) 
            var billType = enterprisetrade;  // string | 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型，支持： enterprisetrade：商户基于企业码交易收单的业务账单; (optional) 
            var billDate = 2022-06-22;  // string | 账单时间： 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。 (optional) 

            try
            {
                // 对账单文件下载接口
                AlipayCommerceEcBalanceDownloadurlQueryResponseModel result = apiInstance.Query(enterpriseId, accountId, agreementNo, billType, billDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcBalanceDownloadurlApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业ID | [optional] 
 **accountId** | **string**| 共同账户ID，没有企业ID可以用此ID查询 | [optional] 
 **agreementNo** | **string**| 授权签约协议号，以共同账户ID查询时必传 | [optional] 
 **billType** | **string**| 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型，支持： enterprisetrade：商户基于企业码交易收单的业务账单; | [optional] 
 **billDate** | **string**| 账单时间： 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。 | [optional] 

### Return type

**AlipayCommerceEcBalanceDownloadurlQueryResponseModel**

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

