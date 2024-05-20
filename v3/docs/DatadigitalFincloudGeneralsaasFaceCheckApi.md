# AlipaySDKNet.OpenAPI.Api.DatadigitalFincloudGeneralsaasFaceCheckApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Initialize**](DatadigitalFincloudGeneralsaasFaceCheckApi.md#initialize) | **POST** /v3/datadigital/fincloud/generalsaas/face/check/initialize | 活体检测初始化
[**Query**](DatadigitalFincloudGeneralsaasFaceCheckApi.md#query) | **GET** /v3/datadigital/fincloud/generalsaas/face/check/query | 活体检测结果查询


<a name="initialize"></a>
# **Initialize**
> DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel Initialize (DatadigitalFincloudGeneralsaasFaceCheckInitializeModel datadigitalFincloudGeneralsaasFaceCheckInitializeModel = null)

活体检测初始化

人脸检测业务单据初始化

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
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceCheckApi(config);

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

            var datadigitalFincloudGeneralsaasFaceCheckInitializeModel = new DatadigitalFincloudGeneralsaasFaceCheckInitializeModel(); // DatadigitalFincloudGeneralsaasFaceCheckInitializeModel |  (optional) 

            try
            {
                // 活体检测初始化
                DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel result = apiInstance.Initialize(datadigitalFincloudGeneralsaasFaceCheckInitializeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceCheckApi.Initialize: " + e.Message );
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
 **datadigitalFincloudGeneralsaasFaceCheckInitializeModel** | **DatadigitalFincloudGeneralsaasFaceCheckInitializeModel**|  | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel**

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
> DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel Query (string certifyId = null, string needAlivePhoto = null, string needScore = null, string needQualityScore = null, string needAttackResult = null)

活体检测结果查询

用于查询活体检测结果。

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
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceCheckApi(config);

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

            var certifyId = dddddfsss88833ssf;  // string | 传入初始化接口datadigital.fincloud.generalsaas.face.check.initialize 得到的certify_id (optional) 
            var needAlivePhoto = Y_M;  // string | 是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图）。非必填，默认为N (optional) 
            var needScore = Y;  // string | 该入参已经废弃。 (optional) 
            var needQualityScore = N;  // string | 是否需要返回图片质量分，非必填，默认值为N。 N表示不需要，Y表示需要 (optional) 
            var needAttackResult = N;  // string | 该参数已废弃 (optional) 

            try
            {
                // 活体检测结果查询
                DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel result = apiInstance.Query(certifyId, needAlivePhoto, needScore, needQualityScore, needAttackResult);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceCheckApi.Query: " + e.Message );
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
 **certifyId** | **string**| 传入初始化接口datadigital.fincloud.generalsaas.face.check.initialize 得到的certify_id | [optional] 
 **needAlivePhoto** | **string**| 是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图）。非必填，默认为N | [optional] 
 **needScore** | **string**| 该入参已经废弃。 | [optional] 
 **needQualityScore** | **string**| 是否需要返回图片质量分，非必填，默认值为N。 N表示不需要，Y表示需要 | [optional] 
 **needAttackResult** | **string**| 该参数已废弃 | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel**

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

