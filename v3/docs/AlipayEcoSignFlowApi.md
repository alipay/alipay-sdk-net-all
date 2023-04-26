# AlipaySDKNet.OpenAPI.Api.AlipayEcoSignFlowApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Cancel**](AlipayEcoSignFlowApi.md#cancel) | **POST** /v3/alipay/eco/sign/flow/cancel | 签署流程撤销（E签宝）
[**Create**](AlipayEcoSignFlowApi.md#create) | **POST** /v3/alipay/eco/sign/flow/create | 创建流程（E签宝）
[**Finish**](AlipayEcoSignFlowApi.md#finish) | **POST** /v3/alipay/eco/sign/flow/finish | 签署流程归档
[**Query**](AlipayEcoSignFlowApi.md#query) | **GET** /v3/alipay/eco/sign/flow/query | 签署流程查询（E签宝）


<a name="cancel"></a>
# **Cancel**
> Object Cancel (string targetAppId = null, AlipayEcoSignFlowCancelModel alipayEcoSignFlowCancelModel = null)

签署流程撤销（E签宝）

签署流程撤销（E签宝）

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
    public class CancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoSignFlowApi(config);

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
            var alipayEcoSignFlowCancelModel = new AlipayEcoSignFlowCancelModel(); // AlipayEcoSignFlowCancelModel |  (optional) 

            try
            {
                // 签署流程撤销（E签宝）
                Object result = apiInstance.Cancel(targetAppId, alipayEcoSignFlowCancelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoSignFlowApi.Cancel: " + e.Message );
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
 **alipayEcoSignFlowCancelModel** | **AlipayEcoSignFlowCancelModel**|  | [optional] 

### Return type

**Object**

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

<a name="create"></a>
# **Create**
> AlipayEcoSignFlowCreateResponseModel Create (string targetAppId = null, AlipayEcoSignFlowCreateModel alipayEcoSignFlowCreateModel = null)

创建流程（E签宝）

创建流程（E签宝）。

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
            var apiInstance = new AlipayEcoSignFlowApi(config);

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
            var alipayEcoSignFlowCreateModel = new AlipayEcoSignFlowCreateModel(); // AlipayEcoSignFlowCreateModel |  (optional) 

            try
            {
                // 创建流程（E签宝）
                AlipayEcoSignFlowCreateResponseModel result = apiInstance.Create(targetAppId, alipayEcoSignFlowCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoSignFlowApi.Create: " + e.Message );
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
 **alipayEcoSignFlowCreateModel** | **AlipayEcoSignFlowCreateModel**|  | [optional] 

### Return type

**AlipayEcoSignFlowCreateResponseModel**

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

<a name="finish"></a>
# **Finish**
> Object Finish (string targetAppId = null, AlipayEcoSignFlowFinishModel alipayEcoSignFlowFinishModel = null)

签署流程归档

手动归档签署流程，归档后所有资源不可修改，归档前签署流程中的所有签署人必须都签署完成。如果创建流程时，设置了自动归档，则无需调用本接口，签署完成后系统会自动调用。

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
    public class FinishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoSignFlowApi(config);

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
            var alipayEcoSignFlowFinishModel = new AlipayEcoSignFlowFinishModel(); // AlipayEcoSignFlowFinishModel |  (optional) 

            try
            {
                // 签署流程归档
                Object result = apiInstance.Finish(targetAppId, alipayEcoSignFlowFinishModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoSignFlowApi.Finish: " + e.Message );
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
 **alipayEcoSignFlowFinishModel** | **AlipayEcoSignFlowFinishModel**|  | [optional] 

### Return type

**Object**

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
> AlipayEcoSignFlowQueryResponseModel Query (string targetAppId = null, string flowId = null)

签署流程查询（E签宝）

签署流程查询（E签宝）。可通过此接口查询流程、签署人的签署状态。

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
            var apiInstance = new AlipayEcoSignFlowApi(config);

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
            var flowId = 429b1d3038854cabbcdac0a63d7e4c0d;  // string | 流程id，通过 <a href =\"https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。 (optional) 

            try
            {
                // 签署流程查询（E签宝）
                AlipayEcoSignFlowQueryResponseModel result = apiInstance.Query(targetAppId, flowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoSignFlowApi.Query: " + e.Message );
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
 **flowId** | **string**| 流程id，通过 &lt;a href &#x3D;\&quot;https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\&quot;&gt;创建电子合同签署流程&lt;/a&gt;(alipay.eco.contract.signflows.create)接口获取。 | [optional] 

### Return type

**AlipayEcoSignFlowQueryResponseModel**

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

