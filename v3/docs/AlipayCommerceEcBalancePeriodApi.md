# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcBalancePeriodApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayCommerceEcBalancePeriodApi.md#modify) | **POST** /v3/alipay/commerce/ec/balance/period/modify | 企业码月对账单账期修改


<a name="modify"></a>
# **Modify**
> AlipayCommerceEcBalancePeriodModifyResponseModel Modify (AlipayCommerceEcBalancePeriodModifyModel alipayCommerceEcBalancePeriodModifyModel = null)

企业码月对账单账期修改

用于在企业码B端后台创建的企业调整月对账单账期

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
            var apiInstance = new AlipayCommerceEcBalancePeriodApi(config);

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

            var alipayCommerceEcBalancePeriodModifyModel = new AlipayCommerceEcBalancePeriodModifyModel(); // AlipayCommerceEcBalancePeriodModifyModel |  (optional) 

            try
            {
                // 企业码月对账单账期修改
                AlipayCommerceEcBalancePeriodModifyResponseModel result = apiInstance.Modify(alipayCommerceEcBalancePeriodModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcBalancePeriodApi.Modify: " + e.Message );
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
 **alipayCommerceEcBalancePeriodModifyModel** | **AlipayCommerceEcBalancePeriodModifyModel**|  | [optional] 

### Return type

**AlipayCommerceEcBalancePeriodModifyResponseModel**

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

