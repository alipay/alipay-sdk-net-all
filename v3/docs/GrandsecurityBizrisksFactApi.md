# AlipaySDKNet.OpenAPI.Api.GrandsecurityBizrisksFactApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Check**](GrandsecurityBizrisksFactApi.md#check) | **POST** /v3/stream/grandsecurity/bizrisks/fact/check | 事实核查服务


<a name="check"></a>
# **Check**
> GrandsecurityBizrisksFactCheckResponseModel Check (GrandsecurityBizrisksFactCheckModel grandsecurityBizrisksFactCheckModel = null)

事实核查服务

模型接口将根据前端返回的问题（query），基于真假结论、核心摘要、推理过程、相关证据、警告、机构名称等，将以上字段梳理为综合判定、判断依据、结论、研处意见及参考资料的四大模块结构，并传至前端提供C端。

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
    public class CheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new GrandsecurityBizrisksFactApi(config);

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

            var grandsecurityBizrisksFactCheckModel = new GrandsecurityBizrisksFactCheckModel(); // GrandsecurityBizrisksFactCheckModel |  (optional) 

            try
            {
                // 事实核查服务
                GrandsecurityBizrisksFactCheckResponseModel result = apiInstance.Check(grandsecurityBizrisksFactCheckModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GrandsecurityBizrisksFactApi.Check: " + e.Message );
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
 **grandsecurityBizrisksFactCheckModel** | **GrandsecurityBizrisksFactCheckModel**|  | [optional] 

### Return type

**GrandsecurityBizrisksFactCheckResponseModel**

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

