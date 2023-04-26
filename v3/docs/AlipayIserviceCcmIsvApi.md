# AlipaySDKNet.OpenAPI.Api.AlipayIserviceCcmIsvApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Initialize**](AlipayIserviceCcmIsvApi.md#initialize) | **POST** /v3/alipay/iservice/ccm/isv/initialize | ccm isv注册接口


<a name="initialize"></a>
# **Initialize**
> AlipayIserviceCcmIsvInitializeResponseModel Initialize (AlipayIserviceCcmIsvInitializeModel alipayIserviceCcmIsvInitializeModel = null)

ccm isv注册接口

商家 / ISV 开发的插件接入CCM（蚂蚁客户沟通管理平台）之前，需要先将自己的信息注册到 CCM，并设置一个用于 iframe 接口接入安全认证使用的公钥。

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
    public class InitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayIserviceCcmIsvApi(config);

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

            var alipayIserviceCcmIsvInitializeModel = new AlipayIserviceCcmIsvInitializeModel(); // AlipayIserviceCcmIsvInitializeModel |  (optional) 

            try
            {
                // ccm isv注册接口
                AlipayIserviceCcmIsvInitializeResponseModel result = apiInstance.Initialize(alipayIserviceCcmIsvInitializeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayIserviceCcmIsvApi.Initialize: " + e.Message );
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
 **alipayIserviceCcmIsvInitializeModel** | **AlipayIserviceCcmIsvInitializeModel**|  | [optional] 

### Return type

**AlipayIserviceCcmIsvInitializeResponseModel**

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

