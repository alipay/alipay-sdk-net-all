# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniIndividualBusinessApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Certify**](AlipayOpenMiniIndividualBusinessApi.md#certify) | **POST** /v3/alipay/open/mini/individual/business/certify | 个人账户升级为个体工商户


<a name="certify"></a>
# **Certify**
> AlipayOpenMiniIndividualBusinessCertifyResponseModel Certify (AlipayOpenMiniIndividualBusinessCertifyModel alipayOpenMiniIndividualBusinessCertifyModel = null)

个人账户升级为个体工商户

小程序场景下，个体工商户具有和企业账户相同的能力，通过本接口，可以将符合资质的个人账户升级为个体工商户

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
            var apiInstance = new AlipayOpenMiniIndividualBusinessApi(config);

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

            var alipayOpenMiniIndividualBusinessCertifyModel = new AlipayOpenMiniIndividualBusinessCertifyModel(); // AlipayOpenMiniIndividualBusinessCertifyModel |  (optional) 

            try
            {
                // 个人账户升级为个体工商户
                AlipayOpenMiniIndividualBusinessCertifyResponseModel result = apiInstance.Certify(alipayOpenMiniIndividualBusinessCertifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniIndividualBusinessApi.Certify: " + e.Message );
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
 **alipayOpenMiniIndividualBusinessCertifyModel** | **AlipayOpenMiniIndividualBusinessCertifyModel**|  | [optional] 

### Return type

**AlipayOpenMiniIndividualBusinessCertifyResponseModel**

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

