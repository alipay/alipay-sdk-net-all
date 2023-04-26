# AlipaySDKNet.OpenAPI.Api.AlipayEcoEduKtSchoolinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayEcoEduKtSchoolinfoApi.md#modify) | **POST** /v3/alipay/eco/edu/kt/schoolinfo/modify | 教育缴费学校信息录入接口


<a name="modify"></a>
# **Modify**
> AlipayEcoEduKtSchoolinfoModifyResponseModel Modify (AlipayEcoEduKtSchoolinfoModifyModel alipayEcoEduKtSchoolinfoModifyModel = null)

教育缴费学校信息录入接口

ISV与支付宝签约后，通过此接口同步学校信息到中小学教育平台。

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
            var apiInstance = new AlipayEcoEduKtSchoolinfoApi(config);

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

            var alipayEcoEduKtSchoolinfoModifyModel = new AlipayEcoEduKtSchoolinfoModifyModel(); // AlipayEcoEduKtSchoolinfoModifyModel |  (optional) 

            try
            {
                // 教育缴费学校信息录入接口
                AlipayEcoEduKtSchoolinfoModifyResponseModel result = apiInstance.Modify(alipayEcoEduKtSchoolinfoModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoEduKtSchoolinfoApi.Modify: " + e.Message );
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
 **alipayEcoEduKtSchoolinfoModifyModel** | **AlipayEcoEduKtSchoolinfoModifyModel**|  | [optional] 

### Return type

**AlipayEcoEduKtSchoolinfoModifyResponseModel**

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

