# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniVersionAuditApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayOpenMiniVersionAuditApi.md#apply) | **POST** /v3/alipay/open/mini/version/audit/apply | 小程序提交审核
[**Cancel**](AlipayOpenMiniVersionAuditApi.md#cancel) | **POST** /v3/alipay/open/mini/version/audit/cancel | 小程序撤销审核


<a name="apply"></a>
# **Apply**
> AlipayOpenMiniVersionAuditApplyResponseModel Apply (System.IO.Stream appLogo = null, AlipayOpenMiniVersionAuditApplyModel data = null, System.IO.Stream fifthLicensePic = null, System.IO.Stream fifthScreenShot = null, System.IO.Stream firstLicensePic = null, System.IO.Stream firstScreenShot = null, System.IO.Stream firstSpecialLicensePic = null, System.IO.Stream fourthLicensePic = null, System.IO.Stream fourthScreenShot = null, System.IO.Stream outDoorPic = null, System.IO.Stream secondLicensePic = null, System.IO.Stream secondScreenShot = null, System.IO.Stream secondSpecialLicensePic = null, System.IO.Stream testFileName = null, System.IO.Stream thirdLicensePic = null, System.IO.Stream thirdScreenShot = null, System.IO.Stream thirdSpecialLicensePic = null)

小程序提交审核

小程序提交审核。 1、本接口中关于小程序基础信息的一些字段例如小程序名称、小程序logo、客服电话等，这些信息如果你前期已经设置过，平台将会在你本次调用接口的时候，将上一次设置的信息自动填入，所以允许你本次调用时不传入。如果你前期还未设置过这些信息，则本次调用是需要必传的。具体的字段要求详见每个字段的描述。你可以用<a href=\"https://opendocs.alipay.com/apis/05ujoy\" target=\"_blank\">alipay.open.mini.version.detail.query</a>接口查询小程序信息之前是否已经设置。 2、小程序版本信息例如小程序版本号、小程序版本描述，这些信息是需要你每次调用接口必传的。 3、本接口涉及到“审核流程拆分”、“审核加急”、“自动上架”的功能，具体功能详见接口字段audit_rule、speed_up、auto_online描述。 4、普通模板构建的商家小程序限 5个小程序/模板/日，可以升级为标准版，标准版没有数量限制。

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
            var apiInstance = new AlipayOpenMiniVersionAuditApi(config);

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

            var appLogo = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var data = new AlipayOpenMiniVersionAuditApplyModel(); // AlipayOpenMiniVersionAuditApplyModel |  (optional) 
            var fifthLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var fifthScreenShot = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var firstLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var firstScreenShot = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var firstSpecialLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var fourthLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var fourthScreenShot = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var outDoorPic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var secondLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var secondScreenShot = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var secondSpecialLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var testFileName = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var thirdLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var thirdScreenShot = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var thirdSpecialLicensePic = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 小程序提交审核
                AlipayOpenMiniVersionAuditApplyResponseModel result = apiInstance.Apply(appLogo, data, fifthLicensePic, fifthScreenShot, firstLicensePic, firstScreenShot, firstSpecialLicensePic, fourthLicensePic, fourthScreenShot, outDoorPic, secondLicensePic, secondScreenShot, secondSpecialLicensePic, testFileName, thirdLicensePic, thirdScreenShot, thirdSpecialLicensePic);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniVersionAuditApi.Apply: " + e.Message );
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
 **appLogo** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **data** | **AlipayOpenMiniVersionAuditApplyModel**|  | [optional] 
 **fifthLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **fifthScreenShot** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **firstLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **firstScreenShot** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **firstSpecialLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **fourthLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **fourthScreenShot** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **outDoorPic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **secondLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **secondScreenShot** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **secondSpecialLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **testFileName** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **thirdLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **thirdScreenShot** | **System.IO.Stream****System.IO.Stream**|  | [optional] 
 **thirdSpecialLicensePic** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

**AlipayOpenMiniVersionAuditApplyResponseModel**

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

<a name="cancel"></a>
# **Cancel**
> Object Cancel (AlipayOpenMiniVersionAuditCancelModel alipayOpenMiniVersionAuditCancelModel = null)

小程序撤销审核

三方实例化小程序撤销审核

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
    public class CancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniVersionAuditApi(config);

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

            var alipayOpenMiniVersionAuditCancelModel = new AlipayOpenMiniVersionAuditCancelModel(); // AlipayOpenMiniVersionAuditCancelModel |  (optional) 

            try
            {
                // 小程序撤销审核
                Object result = apiInstance.Cancel(alipayOpenMiniVersionAuditCancelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniVersionAuditApi.Cancel: " + e.Message );
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
 **alipayOpenMiniVersionAuditCancelModel** | **AlipayOpenMiniVersionAuditCancelModel**|  | [optional] 

### Return type

**Object**

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

