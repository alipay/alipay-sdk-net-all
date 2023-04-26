# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerversionConditionApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenMiniInnerversionConditionApi.md#batchquery) | **POST** /v3/alipay/open/mini/innerversion/condition/batchquery | 根据状态批量查询版本信息


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenMiniInnerversionConditionBatchqueryResponseModel Batchquery (AlipayOpenMiniInnerversionConditionBatchqueryModel alipayOpenMiniInnerversionConditionBatchqueryModel = null)

根据状态批量查询版本信息

小程序提供一套针对一二方场景的开发者提供一套统一的内部能力开放体系，定向输出赋能

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniInnerversionConditionApi(config);

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

            var alipayOpenMiniInnerversionConditionBatchqueryModel = new AlipayOpenMiniInnerversionConditionBatchqueryModel(); // AlipayOpenMiniInnerversionConditionBatchqueryModel |  (optional) 

            try
            {
                // 根据状态批量查询版本信息
                AlipayOpenMiniInnerversionConditionBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenMiniInnerversionConditionBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerversionConditionApi.Batchquery: " + e.Message );
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
 **alipayOpenMiniInnerversionConditionBatchqueryModel** | **AlipayOpenMiniInnerversionConditionBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenMiniInnerversionConditionBatchqueryResponseModel**

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

