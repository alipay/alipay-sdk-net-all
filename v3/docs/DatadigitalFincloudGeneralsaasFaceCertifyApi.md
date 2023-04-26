# AlipaySDKNet.OpenAPI.Api.DatadigitalFincloudGeneralsaasFaceCertifyApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Initialize**](DatadigitalFincloudGeneralsaasFaceCertifyApi.md#initialize) | **POST** /v3/datadigital/fincloud/generalsaas/face/certify/initialize | H5人脸核身初始化
[**Query**](DatadigitalFincloudGeneralsaasFaceCertifyApi.md#query) | **GET** /v3/datadigital/fincloud/generalsaas/face/certify/query | H5人脸核身查询记录
[**Verify**](DatadigitalFincloudGeneralsaasFaceCertifyApi.md#verify) | **POST** /v3/datadigital/fincloud/generalsaas/face/certify/verify | H5人脸核身开始认证


<a name="initialize"></a>
# **Initialize**
> DatadigitalFincloudGeneralsaasFaceCertifyInitializeResponseModel Initialize (DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel datadigitalFincloudGeneralsaasFaceCertifyInitializeModel = null)

H5人脸核身初始化

人脸核身初始化服务，用于创建认证流程。供外部客户使用该项服务。

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
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceCertifyApi(config);

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

            var datadigitalFincloudGeneralsaasFaceCertifyInitializeModel = new DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel(); // DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel |  (optional) 

            try
            {
                // H5人脸核身初始化
                DatadigitalFincloudGeneralsaasFaceCertifyInitializeResponseModel result = apiInstance.Initialize(datadigitalFincloudGeneralsaasFaceCertifyInitializeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceCertifyApi.Initialize: " + e.Message );
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
 **datadigitalFincloudGeneralsaasFaceCertifyInitializeModel** | **DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel**|  | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceCertifyInitializeResponseModel**

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
> DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel Query (string certifyId = null)

H5人脸核身查询记录

商户在用户使用支付宝完成刷脸之后，调用本接口查询核身结果状态及相关数据

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
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceCertifyApi(config);

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

            var certifyId = 03cdsfsss20048373;  // string | 本次申请操作的唯一标识，通过datadigital.fincloud.generalsaas.face.certify.initialize 接口同步响应获取。 (optional) 

            try
            {
                // H5人脸核身查询记录
                DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel result = apiInstance.Query(certifyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceCertifyApi.Query: " + e.Message );
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
 **certifyId** | **string**| 本次申请操作的唯一标识，通过datadigital.fincloud.generalsaas.face.certify.initialize 接口同步响应获取。 | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel**

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

<a name="verify"></a>
# **Verify**
> DatadigitalFincloudGeneralsaasFaceCertifyVerifyResponseModel Verify (DatadigitalFincloudGeneralsaasFaceCertifyVerifyModel datadigitalFincloudGeneralsaasFaceCertifyVerifyModel = null)

H5人脸核身开始认证

H5人脸核身服务开始认证。请根据返回结果渲染页面。

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
    public class VerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new DatadigitalFincloudGeneralsaasFaceCertifyApi(config);

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

            var datadigitalFincloudGeneralsaasFaceCertifyVerifyModel = new DatadigitalFincloudGeneralsaasFaceCertifyVerifyModel(); // DatadigitalFincloudGeneralsaasFaceCertifyVerifyModel |  (optional) 

            try
            {
                // H5人脸核身开始认证
                DatadigitalFincloudGeneralsaasFaceCertifyVerifyResponseModel result = apiInstance.Verify(datadigitalFincloudGeneralsaasFaceCertifyVerifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadigitalFincloudGeneralsaasFaceCertifyApi.Verify: " + e.Message );
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
 **datadigitalFincloudGeneralsaasFaceCertifyVerifyModel** | **DatadigitalFincloudGeneralsaasFaceCertifyVerifyModel**|  | [optional] 

### Return type

**DatadigitalFincloudGeneralsaasFaceCertifyVerifyResponseModel**

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

