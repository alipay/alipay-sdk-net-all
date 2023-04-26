# AlipaySDKNet.OpenAPI.Api.AlipayOpenAgentFacetofaceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Sign**](AlipayOpenAgentFacetofaceApi.md#sign) | **POST** /v3/alipay/open/agent/facetoface/sign | 代签约当面付产品


<a name="sign"></a>
# **Sign**
> Object Sign (System.IO.Stream businessLicenseAuthPic = null, System.IO.Stream businessLicensePic = null, AlipayOpenAgentFacetofaceSignModel data = null, System.IO.Stream shopScenePic = null, System.IO.Stream shopSignBoardPic = null, System.IO.Stream specialLicensePic = null)

代签约当面付产品

三方应用代理签约当面付产品，需要配合开启事务接口使用

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
    public class SignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenAgentFacetofaceApi(config);

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

            var businessLicenseAuthPic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var businessLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var data = new AlipayOpenAgentFacetofaceSignModel(); // AlipayOpenAgentFacetofaceSignModel |  (optional) 
            var shopScenePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var shopSignBoardPic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var specialLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 代签约当面付产品
                Object result = apiInstance.Sign(businessLicenseAuthPic, businessLicensePic, data, shopScenePic, shopSignBoardPic, specialLicensePic);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenAgentFacetofaceApi.Sign: " + e.Message );
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
 **businessLicenseAuthPic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **businessLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **data** | **AlipayOpenAgentFacetofaceSignModel**|  | [optional] 
 **shopScenePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **shopSignBoardPic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **specialLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

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

