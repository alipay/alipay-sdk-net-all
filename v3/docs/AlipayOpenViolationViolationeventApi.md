# AlipaySDKNet.OpenAPI.Api.AlipayOpenViolationViolationeventApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayOpenViolationViolationeventApi.md#batchquery) | **POST** /v3/alipay/open/violation/violationevent/batchquery | 违规记录列表查询


<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenViolationViolationeventBatchqueryResponseModel Batchquery (AlipayOpenViolationViolationeventBatchqueryModel alipayOpenViolationViolationeventBatchqueryModel = null)

违规记录列表查询

违规记录列表查询

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
            var apiInstance = new AlipayOpenViolationViolationeventApi(config);

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

            var alipayOpenViolationViolationeventBatchqueryModel = new AlipayOpenViolationViolationeventBatchqueryModel(); // AlipayOpenViolationViolationeventBatchqueryModel |  (optional) 

            try
            {
                // 违规记录列表查询
                AlipayOpenViolationViolationeventBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenViolationViolationeventBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenViolationViolationeventApi.Batchquery: " + e.Message );
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
 **alipayOpenViolationViolationeventBatchqueryModel** | **AlipayOpenViolationViolationeventBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenViolationViolationeventBatchqueryResponseModel**

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

