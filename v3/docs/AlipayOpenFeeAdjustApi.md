# AlipaySDKNet.OpenAPI.Api.AlipayOpenFeeAdjustApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayOpenFeeAdjustApi.md#apply) | **POST** /v3/alipay/open/fee/adjust/apply | 特殊费率申请


<a name="apply"></a>
# **Apply**
> Object Apply (System.IO.Stream attachment = null, System.IO.Stream certPic = null, AlipayOpenFeeAdjustApplyModel data = null, System.IO.Stream shopScenePic = null, System.IO.Stream shopSignPic = null)

特殊费率申请

服务商替代签约或交易传参的商户申请费率

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
            var apiInstance = new AlipayOpenFeeAdjustApi(config);

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

            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var certPic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var data = new AlipayOpenFeeAdjustApplyModel(); // AlipayOpenFeeAdjustApplyModel |  (optional) 
            var shopScenePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var shopSignPic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 特殊费率申请
                Object result = apiInstance.Apply(attachment, certPic, data, shopScenePic, shopSignPic);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenFeeAdjustApi.Apply: " + e.Message );
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
 **attachment** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **certPic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **data** | **AlipayOpenFeeAdjustApplyModel**|  | [optional] 
 **shopScenePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **shopSignPic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

**Object**

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

