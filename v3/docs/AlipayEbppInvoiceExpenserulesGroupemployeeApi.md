# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpenserulesGroupemployeeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayEbppInvoiceExpenserulesGroupemployeeApi.md#modify) | **POST** /v3/alipay/ebpp/invoice/expenserules/groupemployee/modify | 修改费控规则员工


<a name="modify"></a>
# **Modify**
> AlipayEbppInvoiceExpenserulesGroupemployeeModifyResponseModel Modify (AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel alipayEbppInvoiceExpenserulesGroupemployeeModifyModel = null)

修改费控规则员工

修改费控规则员工

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
    public class ModifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceExpenserulesGroupemployeeApi(config);

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

            var alipayEbppInvoiceExpenserulesGroupemployeeModifyModel = new AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel(); // AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel |  (optional) 

            try
            {
                // 修改费控规则员工
                AlipayEbppInvoiceExpenserulesGroupemployeeModifyResponseModel result = apiInstance.Modify(alipayEbppInvoiceExpenserulesGroupemployeeModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpenserulesGroupemployeeApi.Modify: " + e.Message );
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
 **alipayEbppInvoiceExpenserulesGroupemployeeModifyModel** | **AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpenserulesGroupemployeeModifyResponseModel**

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

