# AlipaySDKNet.OpenAPI.Api.AlipayUserAgreementExecutionplanApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayUserAgreementExecutionplanApi.md#modify) | **POST** /v3/alipay/user/agreement/executionplan/modify | 周期性扣款协议执行计划修改接口


<a name="modify"></a>
# **Modify**
> AlipayUserAgreementExecutionplanModifyResponseModel Modify (AlipayUserAgreementExecutionplanModifyModel alipayUserAgreementExecutionplanModifyModel = null)

周期性扣款协议执行计划修改接口

周期性扣款产品，商户延期扣款接口

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
            var apiInstance = new AlipayUserAgreementExecutionplanApi(config);

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

            var alipayUserAgreementExecutionplanModifyModel = new AlipayUserAgreementExecutionplanModifyModel(); // AlipayUserAgreementExecutionplanModifyModel |  (optional) 

            try
            {
                // 周期性扣款协议执行计划修改接口
                AlipayUserAgreementExecutionplanModifyResponseModel result = apiInstance.Modify(alipayUserAgreementExecutionplanModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserAgreementExecutionplanApi.Modify: " + e.Message );
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
 **alipayUserAgreementExecutionplanModifyModel** | **AlipayUserAgreementExecutionplanModifyModel**|  | [optional] 

### Return type

**AlipayUserAgreementExecutionplanModifyResponseModel**

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

