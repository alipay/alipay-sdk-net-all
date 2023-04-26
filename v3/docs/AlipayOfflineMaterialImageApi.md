# AlipaySDKNet.OpenAPI.Api.AlipayOfflineMaterialImageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Upload**](AlipayOfflineMaterialImageApi.md#upload) | **POST** /v3/alipay/offline/material/image/upload | 上传门店照片和视频接口


<a name="upload"></a>
# **Upload**
> AlipayOfflineMaterialImageUploadResponseModel Upload (AlipayOfflineMaterialImageUploadModel data = null, System.IO.Stream imageContent = null)

上传门店照片和视频接口

系统商需要先将商户需要使用的图片和视频，上传支付宝服务器,生成对应的图片ID后才能够在口碑平台上配置相应图片

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
            var apiInstance = new AlipayOfflineMaterialImageApi(config);

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

            var data = new AlipayOfflineMaterialImageUploadModel(); // AlipayOfflineMaterialImageUploadModel |  (optional) 
            var imageContent = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 上传门店照片和视频接口
                AlipayOfflineMaterialImageUploadResponseModel result = apiInstance.Upload(data, imageContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOfflineMaterialImageApi.Upload: " + e.Message );
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
 **data** | **AlipayOfflineMaterialImageUploadModel**|  | [optional] 
 **imageContent** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

**AlipayOfflineMaterialImageUploadResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

