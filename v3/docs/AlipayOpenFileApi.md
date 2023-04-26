# AlipaySDKNet.OpenAPI.Api.AlipayOpenFileApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Upload**](AlipayOpenFileApi.md#upload) | **POST** /v3/alipay/open/file/upload | 支付宝文件上传接口


<a name="upload"></a>
# **Upload**
> AlipayOpenFileUploadResponseModel Upload (AlipayOpenFileUploadModel data = null, System.IO.Stream fileContent = null)

支付宝文件上传接口

支付宝通用文件上传接口，支付宝开发者可以调用此接口上传文件，文件可以提供给其他业务使用，例如：上传素材（视频/图片），素材可以供给到生活号+/小程序等其他开放应用后正式发布。 该接口支持使用支付宝SDK和HTTP POST请求，两种方式示例如下： 1. 使用支付宝SDK时，可以直接使用FileItem上传，代码片段参考下文 2. 使用直接使用http协议时，需要忽略file_content参数，文件放入表单中，其余参数放入URL中，其中将参数（不包括文件和file_content）按<a href=\"https://opendocs.alipay.com/common/02kf5q#%E8%87%AA%E8%A1%8C%E5%AE%9E%E7%8E%B0%E7%AD%BE%E5%90%8D\">自行实现签名</a>文档实现，示例： curl - -request POST 'http://openapi.alipay.com/gateway.do?charset=GBK&biz_content=%7B%22biz_code%22%3A%22content_creation%22%2C%22extra_parameters%22%3A%7B%22extern_upload%22%3A%22youku%22%2C%22alipay_user_id%22%3A%22xxxx%22%7D%7D&method=alipay.open.file.upload&format=json&sign=xxx&app_id=2014060600164699&version=1.0&sign_type=RSA2&timestamp=xxx'  - -form 'file=@\"xx.mp4\"'

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
            var apiInstance = new AlipayOpenFileApi(config);

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

            var data = new AlipayOpenFileUploadModel(); // AlipayOpenFileUploadModel |  (optional) 
            var fileContent = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 支付宝文件上传接口
                AlipayOpenFileUploadResponseModel result = apiInstance.Upload(data, fileContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenFileApi.Upload: " + e.Message );
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
 **data** | **AlipayOpenFileUploadModel**|  | [optional] 
 **fileContent** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

**AlipayOpenFileUploadResponseModel**

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

