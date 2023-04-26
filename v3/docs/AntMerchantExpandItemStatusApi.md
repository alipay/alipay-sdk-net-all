# AlipaySDKNet.OpenAPI.Api.AntMerchantExpandItemStatusApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AntMerchantExpandItemStatusApi.md#modify) | **POST** /v3/ant/merchant/expand/item/status/modify | 商品状态修改接口


<a name="modify"></a>
# **Modify**
> AntMerchantExpandItemStatusModifyResponseModel Modify (AntMerchantExpandItemStatusModifyModel antMerchantExpandItemStatusModifyModel = null)

商品状态修改接口

用于服务商或商户修改商品状态

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
            var apiInstance = new AntMerchantExpandItemStatusApi(config);

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

            var antMerchantExpandItemStatusModifyModel = new AntMerchantExpandItemStatusModifyModel(); // AntMerchantExpandItemStatusModifyModel |  (optional) 

            try
            {
                // 商品状态修改接口
                AntMerchantExpandItemStatusModifyResponseModel result = apiInstance.Modify(antMerchantExpandItemStatusModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandItemStatusApi.Modify: " + e.Message );
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
 **antMerchantExpandItemStatusModifyModel** | **AntMerchantExpandItemStatusModifyModel**|  | [optional] 

### Return type

**AntMerchantExpandItemStatusModifyResponseModel**

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

