# AlipaySDKNet.OpenAPI.Api.ZhimaCustomerJobworthPositionApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](ZhimaCustomerJobworthPositionApi.md#add) | **POST** /v3/zhima/customer/jobworth/position/add | 职得工作证岗位收集


<a name="add"></a>
# **Add**
> ZhimaCustomerJobworthPositionAddResponseModel Add (ZhimaCustomerJobworthPositionAddModel zhimaCustomerJobworthPositionAddModel = null)

职得工作证岗位收集

保存商户传入岗位信息，当接口调用成功，业务问题时返回subcode

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
    public class AddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaCustomerJobworthPositionApi(config);

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

            var zhimaCustomerJobworthPositionAddModel = new ZhimaCustomerJobworthPositionAddModel(); // ZhimaCustomerJobworthPositionAddModel |  (optional) 

            try
            {
                // 职得工作证岗位收集
                ZhimaCustomerJobworthPositionAddResponseModel result = apiInstance.Add(zhimaCustomerJobworthPositionAddModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCustomerJobworthPositionApi.Add: " + e.Message );
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
 **zhimaCustomerJobworthPositionAddModel** | **ZhimaCustomerJobworthPositionAddModel**|  | [optional] 

### Return type

**ZhimaCustomerJobworthPositionAddResponseModel**

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

