# AlipaySDKNet.OpenAPI.Api.ZhimaCustomerJobworthJobdataApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](ZhimaCustomerJobworthJobdataApi.md#add) | **POST** /v3/zhima/customer/jobworth/jobdata/add | 工作证职业数据回流接口


<a name="add"></a>
# **Add**
> ZhimaCustomerJobworthJobdataAddResponseModel Add (ZhimaCustomerJobworthJobdataAddModel zhimaCustomerJobworthJobdataAddModel = null)

工作证职业数据回流接口

合作的三方伙伴通过该接口，将数据回传到工作证

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
            var apiInstance = new ZhimaCustomerJobworthJobdataApi(config);

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

            var zhimaCustomerJobworthJobdataAddModel = new ZhimaCustomerJobworthJobdataAddModel(); // ZhimaCustomerJobworthJobdataAddModel |  (optional) 

            try
            {
                // 工作证职业数据回流接口
                ZhimaCustomerJobworthJobdataAddResponseModel result = apiInstance.Add(zhimaCustomerJobworthJobdataAddModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCustomerJobworthJobdataApi.Add: " + e.Message );
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
 **zhimaCustomerJobworthJobdataAddModel** | **ZhimaCustomerJobworthJobdataAddModel**|  | [optional] 

### Return type

**ZhimaCustomerJobworthJobdataAddResponseModel**

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

