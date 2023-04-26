# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountBillApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundJointaccountBillApi.md#query) | **GET** /v3/alipay/fund/jointaccount/bill/query | 因公付账单查询


<a name="query"></a>
# **Query**
> AlipayFundJointaccountBillQueryResponseModel Query (string productCode = null, string bizScene = null, string accountId = null, string pageNum = null, string pageSize = null, string userId = null, string openId = null, string startDate = null, string endDate = null, string agreementNo = null)

因公付账单查询

因公付账单查询

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
            var apiInstance = new AlipayFundJointaccountBillApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 因公付产品码 (optional) 
            var bizScene = DEFAULT;  // string | 业务场景 (optional) 
            var accountId = 2088900976746215;  // string | 账户ID (optional) 
            var pageNum = 1;  // string | 采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据 (optional) 
            var pageSize = 1;  // string | 每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 (optional) 
            var userId = 2088900976746215;  // string | 员工ID (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 员工的openId (optional) 
            var startDate = yyyy-MM-dd;  // string | 起始日期 (optional) 
            var endDate = yyyy-MM-dd;  // string | 截止日期 (optional) 
            var agreementNo = 2088900976746215123123;  // string | 授权协议号 (optional) 

            try
            {
                // 因公付账单查询
                AlipayFundJointaccountBillQueryResponseModel result = apiInstance.Query(productCode, bizScene, accountId, pageNum, pageSize, userId, openId, startDate, endDate, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountBillApi.Query: " + e.Message );
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
 **productCode** | **string**| 因公付产品码 | [optional] 
 **bizScene** | **string**| 业务场景 | [optional] 
 **accountId** | **string**| 账户ID | [optional] 
 **pageNum** | **string**| 采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据 | [optional] 
 **pageSize** | **string**| 每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 | [optional] 
 **userId** | **string**| 员工ID | [optional] 
 **openId** | **string**| 员工的openId | [optional] 
 **startDate** | **string**| 起始日期 | [optional] 
 **endDate** | **string**| 截止日期 | [optional] 
 **agreementNo** | **string**| 授权协议号 | [optional] 

### Return type

**AlipayFundJointaccountBillQueryResponseModel**

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

