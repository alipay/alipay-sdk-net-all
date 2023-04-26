# AlipaySDKNet.OpenAPI.Api.ZhimaCustomerJobworthPictureApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Upload**](ZhimaCustomerJobworthPictureApi.md#upload) | **POST** /v3/zhima/customer/jobworth/picture/upload | 职得工作证图片上传


<a name="upload"></a>
# **Upload**
> ZhimaCustomerJobworthPictureUploadResponseModel Upload (ZhimaCustomerJobworthPictureUploadModel zhimaCustomerJobworthPictureUploadModel = null)

职得工作证图片上传

工作证图片上传通用接口

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
            var apiInstance = new ZhimaCustomerJobworthPictureApi(config);

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

            var zhimaCustomerJobworthPictureUploadModel = new ZhimaCustomerJobworthPictureUploadModel(); // ZhimaCustomerJobworthPictureUploadModel |  (optional) 

            try
            {
                // 职得工作证图片上传
                ZhimaCustomerJobworthPictureUploadResponseModel result = apiInstance.Upload(zhimaCustomerJobworthPictureUploadModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCustomerJobworthPictureApi.Upload: " + e.Message );
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
 **zhimaCustomerJobworthPictureUploadModel** | **ZhimaCustomerJobworthPictureUploadModel**|  | [optional] 

### Return type

**ZhimaCustomerJobworthPictureUploadResponseModel**

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

