# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCardActivateurlApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayMarketingCardActivateurlApi.md#apply) | **POST** /v3/alipay/marketing/card/activateurl/apply | 获取会员卡领卡投放链接


<a name="apply"></a>
# **Apply**
> AlipayMarketingCardActivateurlApplyResponseModel Apply (AlipayMarketingCardActivateurlApplyModel alipayMarketingCardActivateurlApplyModel = null)

获取会员卡领卡投放链接

会员卡开卡业务，开发者通过该接口获取用户开卡链接，用于会员卡投放。

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
            var apiInstance = new AlipayMarketingCardActivateurlApi(config);

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

            var alipayMarketingCardActivateurlApplyModel = new AlipayMarketingCardActivateurlApplyModel(); // AlipayMarketingCardActivateurlApplyModel |  (optional) 

            try
            {
                // 获取会员卡领卡投放链接
                AlipayMarketingCardActivateurlApplyResponseModel result = apiInstance.Apply(alipayMarketingCardActivateurlApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardActivateurlApi.Apply: " + e.Message );
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
 **alipayMarketingCardActivateurlApplyModel** | **AlipayMarketingCardActivateurlApplyModel**|  | [optional] 

### Return type

**AlipayMarketingCardActivateurlApplyResponseModel**

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

