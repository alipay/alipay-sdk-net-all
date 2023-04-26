# AlipaySDKNet.OpenAPI.Api.AlipayDataBillAccountbookereceiptApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayDataBillAccountbookereceiptApi.md#apply) | **POST** /v3/alipay/data/bill/accountbookereceipt/apply | 申请子账本电子回单(incubating)
[**Query**](AlipayDataBillAccountbookereceiptApi.md#query) | **GET** /v3/alipay/data/bill/accountbookereceipt/query | 查询子账本电子回单状态(incubating)


<a name="apply"></a>
# **Apply**
> AlipayDataBillAccountbookereceiptApplyResponseModel Apply (AlipayDataBillAccountbookereceiptApplyModel alipayDataBillAccountbookereceiptApplyModel = null)

申请子账本电子回单(incubating)

申请子账本电子回单（子账本业务定制接口）

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
    public class ApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayDataBillAccountbookereceiptApi(config);

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

            var alipayDataBillAccountbookereceiptApplyModel = new AlipayDataBillAccountbookereceiptApplyModel(); // AlipayDataBillAccountbookereceiptApplyModel |  (optional) 

            try
            {
                // 申请子账本电子回单(incubating)
                AlipayDataBillAccountbookereceiptApplyResponseModel result = apiInstance.Apply(alipayDataBillAccountbookereceiptApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillAccountbookereceiptApi.Apply: " + e.Message );
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
 **alipayDataBillAccountbookereceiptApplyModel** | **AlipayDataBillAccountbookereceiptApplyModel**|  | [optional] 

### Return type

**AlipayDataBillAccountbookereceiptApplyResponseModel**

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

<a name="query"></a>
# **Query**
> AlipayDataBillAccountbookereceiptQueryResponseModel Query (string fileId = null, string agreementNo = null)

查询子账本电子回单状态(incubating)

电子签章申请分两个步骤： 1、使用alipay.data.bill.ereceipt.apply创建申请，并获取file_id信息。 2、等待一段时间后，使用file_id查询alipay.data.bill.ereceipt.query申请信息。 单个申请建议每5分钟查询一次状态。汇总回单建议30分钟查询一次

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
            var apiInstance = new AlipayDataBillAccountbookereceiptApi(config);

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

            var fileId = 12345;  // string | 根据申请id查询状态 (optional) 
            var agreementNo = 20205215001418078112;  // string | 协议号 (optional) 

            try
            {
                // 查询子账本电子回单状态(incubating)
                AlipayDataBillAccountbookereceiptQueryResponseModel result = apiInstance.Query(fileId, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillAccountbookereceiptApi.Query: " + e.Message );
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
 **fileId** | **string**| 根据申请id查询状态 | [optional] 
 **agreementNo** | **string**| 协议号 | [optional] 

### Return type

**AlipayDataBillAccountbookereceiptQueryResponseModel**

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

