# AlipaySDKNet.OpenAPI.Api.AlipayEcoFilePathApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEcoFilePathApi.md#query) | **GET** /v3/alipay/eco/file/path/query | 获取文件直传地址（E签宝）


<a name="query"></a>
# **Query**
> AlipayEcoFilePathQueryResponseModel Query (string targetAppId = null, string contentMd5 = null, string contentType = null, string fileName = null, int? fileSize = null)

获取文件直传地址（E签宝）

获取文件直传地址（E签宝）

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
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoFilePathApi(config);

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

            var targetAppId = "targetAppId_example";  // string | 目标isv应用ID (optional) 
            var contentMd5 = eGMHwA4TWnbg6PYKMxreUQ==;  // string | 先计算文件md5值，在对该md5值进行base64编码 (optional) 
            var contentType = application/octet-stream;  // string | 目标文件的MIME类型 (optional) 
            var fileName = 附件.zip;  // string | 文件名称。 注意：必须带上文件扩展名，不然会导致后续发起流程校验不通过。示例：合同.pdf。 (optional) 
            var fileSize = 2542635;  // int? | 文件大小，单位byte。最大允许上传30Mb (optional) 

            try
            {
                // 获取文件直传地址（E签宝）
                AlipayEcoFilePathQueryResponseModel result = apiInstance.Query(targetAppId, contentMd5, contentType, fileName, fileSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoFilePathApi.Query: " + e.Message );
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
 **targetAppId** | **string**| 目标isv应用ID | [optional] 
 **contentMd5** | **string**| 先计算文件md5值，在对该md5值进行base64编码 | [optional] 
 **contentType** | **string**| 目标文件的MIME类型 | [optional] 
 **fileName** | **string**| 文件名称。 注意：必须带上文件扩展名，不然会导致后续发起流程校验不通过。示例：合同.pdf。 | [optional] 
 **fileSize** | **int?**| 文件大小，单位byte。最大允许上传30Mb | [optional] 

### Return type

**AlipayEcoFilePathQueryResponseModel**

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

