# AlipaySDKNet.OpenAPI.Api.AlipayDataBillEreceiptagentApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayDataBillEreceiptagentApi.md#apply) | **POST** /v3/alipay/data/bill/ereceiptagent/apply | ISV代理商户申请电子回单


<a name="apply"></a>
# **Apply**
> AlipayDataBillEreceiptagentApplyResponseModel Apply (AlipayDataBillEreceiptagentApplyModel alipayDataBillEreceiptagentApplyModel = null)

ISV代理商户申请电子回单

ISV代理商户，申请商户的资金业务回单。  电子签章申请分两个步骤： 1、使用alipay.data.bill.ereceiptagent.apply创建申请，并获取file_id信息。 2、等待一段时间后，使用file_id查询alipay.data.bill.ereceipt.query申请信息。单个申请建议每5分钟查询一次状态，汇总（日/月）回单建议20分钟查询一次。月初回单生成较慢，请耐心等待（汇总回单在月初申请需要等待几个小时） 注：申请成功，并不代表明细查询的流水一定存在。如果流水不存在，在查询时将会提示。 

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
            var apiInstance = new AlipayDataBillEreceiptagentApi(config);

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

            var alipayDataBillEreceiptagentApplyModel = new AlipayDataBillEreceiptagentApplyModel(); // AlipayDataBillEreceiptagentApplyModel |  (optional) 

            try
            {
                // ISV代理商户申请电子回单
                AlipayDataBillEreceiptagentApplyResponseModel result = apiInstance.Apply(alipayDataBillEreceiptagentApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillEreceiptagentApi.Apply: " + e.Message );
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
 **alipayDataBillEreceiptagentApplyModel** | **AlipayDataBillEreceiptagentApplyModel**|  | [optional] 

### Return type

**AlipayDataBillEreceiptagentApplyResponseModel**

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

