# AlipaySDKNet.OpenAPI.Api.AlipayEcoContractSignflowsApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEcoContractSignflowsApi.md#create) | **POST** /v3/alipay/eco/contract/signflows/create | 创建电子合同签署流程(E签宝)


<a name="create"></a>
# **Create**
> AlipayEcoContractSignflowsCreateResponseModel Create (string targetAppId = null, AlipayEcoContractSignflowsCreateModel alipayEcoContractSignflowsCreateModel = null)

创建电子合同签署流程(E签宝)

根据配置好的合同模板，调用接口填充内容并指定签署人创建电子合同签署流程。

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoContractSignflowsApi(config);

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

            var targetAppId = "targetAppId_example";  // string | 目标isv应用ID (optional) 
            var alipayEcoContractSignflowsCreateModel = new AlipayEcoContractSignflowsCreateModel(); // AlipayEcoContractSignflowsCreateModel |  (optional) 

            try
            {
                // 创建电子合同签署流程(E签宝)
                AlipayEcoContractSignflowsCreateResponseModel result = apiInstance.Create(targetAppId, alipayEcoContractSignflowsCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoContractSignflowsApi.Create: " + e.Message );
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
 **targetAppId** | **string**| 目标isv应用ID | [optional] 
 **alipayEcoContractSignflowsCreateModel** | **AlipayEcoContractSignflowsCreateModel**|  | [optional] 

### Return type

**AlipayEcoContractSignflowsCreateResponseModel**

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

