# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniTemplatemsgMaketingstatusApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayOpenMiniTemplatemsgMaketingstatusApi.md#modify) | **POST** /v3/alipay/open/mini/templatemsg/maketingstatus/modify | 小程序模板消息营销投放详情状态修改


<a name="modify"></a>
# **Modify**
> Object Modify (AlipayOpenMiniTemplatemsgMaketingstatusModifyModel alipayOpenMiniTemplatemsgMaketingstatusModifyModel = null)

小程序模板消息营销投放详情状态修改

小程序模板消息营销投放详情状态修改

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
    public class ModifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniTemplatemsgMaketingstatusApi(config);

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

            var alipayOpenMiniTemplatemsgMaketingstatusModifyModel = new AlipayOpenMiniTemplatemsgMaketingstatusModifyModel(); // AlipayOpenMiniTemplatemsgMaketingstatusModifyModel |  (optional) 

            try
            {
                // 小程序模板消息营销投放详情状态修改
                Object result = apiInstance.Modify(alipayOpenMiniTemplatemsgMaketingstatusModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniTemplatemsgMaketingstatusApi.Modify: " + e.Message );
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
 **alipayOpenMiniTemplatemsgMaketingstatusModifyModel** | **AlipayOpenMiniTemplatemsgMaketingstatusModifyModel**|  | [optional] 

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

