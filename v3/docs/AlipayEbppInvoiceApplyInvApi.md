# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceApplyInvApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Upload**](AlipayEbppInvoiceApplyInvApi.md#upload) | **PUT** /v3/alipay/ebpp/invoice/apply/inv/upload | 发票回传


<a name="upload"></a>
# **Upload**
> AlipayEbppInvoiceApplyInvUploadResponseModel Upload (AlipayEbppInvoiceApplyInvUploadModel alipayEbppInvoiceApplyInvUploadModel = null)

发票回传

发票回传接口适用于以下场景： 1、间联开票模式：阿里发票平台向ISV提交了原始发票申请，商户在ISV后台开具发票成功后，基于申请ID(apply_id)回传发票至阿里发票平台归集与交付。 2、直连开票模式：阿里发票平台请求ISV开票，ISV系统异步执行开票事务后，基于开票流水号(serial_no)回传开票结果至阿里发票平台归集与交付。 3、ISV直接回传发票给阿里发票平台，进行归集，并交付给业务前台和用户。

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
    public class UploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppInvoiceApplyInvApi(config);

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

            var alipayEbppInvoiceApplyInvUploadModel = new AlipayEbppInvoiceApplyInvUploadModel(); // AlipayEbppInvoiceApplyInvUploadModel |  (optional) 

            try
            {
                // 发票回传
                AlipayEbppInvoiceApplyInvUploadResponseModel result = apiInstance.Upload(alipayEbppInvoiceApplyInvUploadModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceApplyInvApi.Upload: " + e.Message );
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
 **alipayEbppInvoiceApplyInvUploadModel** | **AlipayEbppInvoiceApplyInvUploadModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceApplyInvUploadResponseModel**

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

