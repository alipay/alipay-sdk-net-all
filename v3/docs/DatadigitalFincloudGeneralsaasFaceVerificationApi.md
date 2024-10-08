# AlipaySDKNet.OpenAPI.Api.DatadigitalFincloudGeneralsaasFaceVerificationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Initialize**](DatadigitalFincloudGeneralsaasFaceVerificationApi.md#initialize) | **POST** /v3/datadigital/fincloud/generalsaas/face/verification/initialize | 人脸核身初始化
[**Query**](DatadigitalFincloudGeneralsaasFaceVerificationApi.md#query) | **GET** /v3/datadigital/fincloud/generalsaas/face/verification/query | 人脸核身结果查询


<a name="initialize"></a>
# **Initialize**
> DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel Initialize (DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = null)

人脸核身初始化

人脸核身初始化接口

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
    public class InitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceVerificationApi(config);

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

            var datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = new DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel(); // DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel |  (optional) 

            try
            {
                // 人脸核身初始化
                DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel result = apiInstance.Initialize(datadigitalFincloudGeneralsaasFaceVerificationInitializeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceVerificationApi.Initialize: " + e.Message );
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
 **datadigitalFincloudGeneralsaasFaceVerificationInitializeModel** | **DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel**|  | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel**

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

<a name="query"></a>
# **Query**
> DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel Query (string certifyId = null, string needAlivePhoto = null)

人脸核身结果查询

查询核身结果

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
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceVerificationApi(config);

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

            var certifyId = adsfasdfasdf;  // string | 填入人脸核身初始化阶段获取到的certify_id (optional) 
            var needAlivePhoto = N;  // string | 是否需要返回活体结果图片，默认为N（不返图） (optional) 

            try
            {
                // 人脸核身结果查询
                DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel result = apiInstance.Query(certifyId, needAlivePhoto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceVerificationApi.Query: " + e.Message );
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
 **certifyId** | **string**| 填入人脸核身初始化阶段获取到的certify_id | [optional] 
 **needAlivePhoto** | **string**| 是否需要返回活体结果图片，默认为N（不返图） | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | common response |  -  |
| **0** | 请求失败 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

