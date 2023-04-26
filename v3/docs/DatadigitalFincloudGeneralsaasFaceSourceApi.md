# AlipaySDKNet.OpenAPI.Api.DatadigitalFincloudGeneralsaasFaceSourceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Certify**](DatadigitalFincloudGeneralsaasFaceSourceApi.md#certify) | **POST** /v3/datadigital/fincloud/generalsaas/face/source/certify | 权威核验源的核验接口


<a name="certify"></a>
# **Certify**
> DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel Certify (DatadigitalFincloudGeneralsaasFaceSourceCertifyModel data = null, System.IO.Stream fileContent = null)

权威核验源的核验接口

上传人脸照片，调用权威核验源进行验证

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
    public class CertifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceSourceApi(config);

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

            var data = new DatadigitalFincloudGeneralsaasFaceSourceCertifyModel(); // DatadigitalFincloudGeneralsaasFaceSourceCertifyModel |  (optional) 
            var fileContent = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 权威核验源的核验接口
                DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel result = apiInstance.Certify(data, fileContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceSourceApi.Certify: " + e.Message );
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
 **data** | **DatadigitalFincloudGeneralsaasFaceSourceCertifyModel**|  | [optional] 
 **fileContent** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel**

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

