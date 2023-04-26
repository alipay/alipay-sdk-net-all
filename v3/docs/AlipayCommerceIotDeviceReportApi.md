# AlipaySDKNet.OpenAPI.Api.AlipayCommerceIotDeviceReportApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Upload**](AlipayCommerceIotDeviceReportApi.md#upload) | **POST** /v3/alipay/commerce/iot/device/report/upload | 设备检测报告上传


<a name="upload"></a>
# **Upload**
> AlipayCommerceIotDeviceReportUploadResponseModel Upload (AlipayCommerceIotDeviceReportUploadModel alipayCommerceIotDeviceReportUploadModel = null)

设备检测报告上传

设备检测报告上传

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
            var apiInstance = new AlipayCommerceIotDeviceReportApi(config);

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

            var alipayCommerceIotDeviceReportUploadModel = new AlipayCommerceIotDeviceReportUploadModel(); // AlipayCommerceIotDeviceReportUploadModel |  (optional) 

            try
            {
                // 设备检测报告上传
                AlipayCommerceIotDeviceReportUploadResponseModel result = apiInstance.Upload(alipayCommerceIotDeviceReportUploadModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceIotDeviceReportApi.Upload: " + e.Message );
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
 **alipayCommerceIotDeviceReportUploadModel** | **AlipayCommerceIotDeviceReportUploadModel**|  | [optional] 

### Return type

**AlipayCommerceIotDeviceReportUploadResponseModel**

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

