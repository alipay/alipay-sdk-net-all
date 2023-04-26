# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcJointaccountbillDetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayCommerceEcJointaccountbillDetailApi.md#batchquery) | **GET** /v3/alipay/commerce/ec/jointaccountbill/detail/batchquery | 企业账单批量分页查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel Batchquery (string enterpriseId = null, string bizScene = null, string userId = null, string openId = null, string employeeId = null, string pageNum = null, string pageSize = null, string startDate = null, string endDate = null)

企业账单批量分页查询

分页查询企业账单

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceEcJointaccountbillDetailApi(config);

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

            var enterpriseId = 2088123456789000;  // string | 企业ID (optional) 
            var bizScene = ISV_DEFAULT;  // string | 业务场景。不传默认为ISV_DEFAULT (optional) 
            var userId = 2088123456789000;  // string | 员工支付宝UID (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 员工支付宝UID (optional) 
            var employeeId = 2288029541813166;  // string | 员工id (optional) 
            var pageNum = 1;  // string | 页码 (optional) 
            var pageSize = 20;  // string | 每页大小 (optional) 
            var startDate = yyyy-MM-dd HH:mm:ss;  // string | 起始日期 (optional) 
            var endDate = yyyy-MM-dd HH:mm:ss;  // string | 截止日期 (optional) 

            try
            {
                // 企业账单批量分页查询
                AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel result = apiInstance.Batchquery(enterpriseId, bizScene, userId, openId, employeeId, pageNum, pageSize, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcJointaccountbillDetailApi.Batchquery: " + e.Message );
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
 **bizScene** | **string**| 业务场景。不传默认为ISV_DEFAULT | [optional] 
 **userId** | **string**| 员工支付宝UID | [optional] 
 **openId** | **string**| 员工支付宝UID | [optional] 
 **employeeId** | **string**| 员工id | [optional] 
 **pageNum** | **string**| 页码 | [optional] 
 **pageSize** | **string**| 每页大小 | [optional] 
 **startDate** | **string**| 起始日期 | [optional] 
 **endDate** | **string**| 截止日期 | [optional] 

### Return type

**AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel**

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

