# AlipaySDKNet.OpenAPI.Api.AlipayUserTwostageCommonApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Use**](AlipayUserTwostageCommonApi.md#use) | **POST** /v3/alipay/user/twostage/common/use | 通用当面付二阶段接口


<a name="use"></a>
# **Use**
> AlipayUserTwostageCommonUseResponseModel Use (AlipayUserTwostageCommonUseModel alipayUserTwostageCommonUseModel = null)

通用当面付二阶段接口

商家通过小程序/卡券开放权益(优惠券)，用户在小程序/卡券授权后，打开付款码时通过该接口获取用户信息。

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
    public class UseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayUserTwostageCommonApi(config);

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

            var alipayUserTwostageCommonUseModel = new AlipayUserTwostageCommonUseModel(); // AlipayUserTwostageCommonUseModel |  (optional) 

            try
            {
                // 通用当面付二阶段接口
                AlipayUserTwostageCommonUseResponseModel result = apiInstance.Use(alipayUserTwostageCommonUseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserTwostageCommonApi.Use: " + e.Message );
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
 **alipayUserTwostageCommonUseModel** | **AlipayUserTwostageCommonUseModel**|  | [optional] 

### Return type

**AlipayUserTwostageCommonUseResponseModel**

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

