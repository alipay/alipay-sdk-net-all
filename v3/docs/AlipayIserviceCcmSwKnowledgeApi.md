# AlipaySDKNet.OpenAPI.Api.AlipayIserviceCcmSwKnowledgeApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayIserviceCcmSwKnowledgeApi.md#modify) | **POST** /v3/alipay/iservice/ccm/sw/knowledge/modify | 知识库问答管理


<a name="modify"></a>
# **Modify**
> AlipayIserviceCcmSwKnowledgeModifyResponseModel Modify (AlipayIserviceCcmSwKnowledgeModifyModel alipayIserviceCcmSwKnowledgeModifyModel = null)

知识库问答管理

知识库问答管理

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
            var apiInstance = new AlipayIserviceCcmSwKnowledgeApi(config);

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

            var alipayIserviceCcmSwKnowledgeModifyModel = new AlipayIserviceCcmSwKnowledgeModifyModel(); // AlipayIserviceCcmSwKnowledgeModifyModel |  (optional) 

            try
            {
                // 知识库问答管理
                AlipayIserviceCcmSwKnowledgeModifyResponseModel result = apiInstance.Modify(alipayIserviceCcmSwKnowledgeModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayIserviceCcmSwKnowledgeApi.Modify: " + e.Message );
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
 **alipayIserviceCcmSwKnowledgeModifyModel** | **AlipayIserviceCcmSwKnowledgeModifyModel**|  | [optional] 

### Return type

**AlipayIserviceCcmSwKnowledgeModifyResponseModel**

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

