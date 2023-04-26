# AlipaySDKNet.OpenAPI.Api.AlipayUserTwostageIndirectApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Use**](AlipayUserTwostageIndirectApi.md#use) | **POST** /v3/alipay/user/twostage/indirect/use | 双联二阶段


<a name="use"></a>
# **Use**
> AlipayUserTwostageIndirectUseResponseModel Use (AlipayUserTwostageIndirectUseModel alipayUserTwostageIndirectUseModel = null)

双联二阶段

间连模式通过双联向银行输出付款码查UID接口. 双联二阶段里，授权之后调用该接口，进行解码并校验双联pid、银行orgId、isv sourceId及学校smid之间的级联关系；检查授权关系；解码并返回用户uid

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
            var apiInstance = new AlipayUserTwostageIndirectApi(config);

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

            var alipayUserTwostageIndirectUseModel = new AlipayUserTwostageIndirectUseModel(); // AlipayUserTwostageIndirectUseModel |  (optional) 

            try
            {
                // 双联二阶段
                AlipayUserTwostageIndirectUseResponseModel result = apiInstance.Use(alipayUserTwostageIndirectUseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserTwostageIndirectApi.Use: " + e.Message );
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
 **alipayUserTwostageIndirectUseModel** | **AlipayUserTwostageIndirectUseModel**|  | [optional] 

### Return type

**AlipayUserTwostageIndirectUseResponseModel**

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

