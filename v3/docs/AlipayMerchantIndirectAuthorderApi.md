# AlipaySDKNet.OpenAPI.Api.AlipayMerchantIndirectAuthorderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Close**](AlipayMerchantIndirectAuthorderApi.md#close) | **PUT** /v3/alipay/merchant/indirect/authorder/close | 商家认证申请单撤销
[**Create**](AlipayMerchantIndirectAuthorderApi.md#create) | **POST** /v3/alipay/merchant/indirect/authorder/create | 商家认证申请单提交
[**Querystatus**](AlipayMerchantIndirectAuthorderApi.md#querystatus) | **POST** /v3/alipay/merchant/indirect/authorder/querystatus | 查询商家认证申请单状态


<a name="close"></a>
# **Close**
> Object Close (AlipayMerchantIndirectAuthorderCloseModel alipayMerchantIndirectAuthorderCloseModel = null)

商家认证申请单撤销

申请单处于审核中、审核失败、待确认等状态时，申请单可撤销，撤销后可重新调用提交申请单接口上传申请单信息

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
    public class CloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMerchantIndirectAuthorderApi(config);

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

            var alipayMerchantIndirectAuthorderCloseModel = new AlipayMerchantIndirectAuthorderCloseModel(); // AlipayMerchantIndirectAuthorderCloseModel |  (optional) 

            try
            {
                // 商家认证申请单撤销
                Object result = apiInstance.Close(alipayMerchantIndirectAuthorderCloseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantIndirectAuthorderApi.Close: " + e.Message );
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
 **alipayMerchantIndirectAuthorderCloseModel** | **AlipayMerchantIndirectAuthorderCloseModel**|  | [optional] 

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
> AlipayMerchantIndirectAuthorderCreateResponseModel Create (AlipayMerchantIndirectAuthorderCreateModel alipayMerchantIndirectAuthorderCreateModel = null)

商家认证申请单提交

间连商户认证申请单提交，用于支付宝间连商家认证

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
            var apiInstance = new AlipayMerchantIndirectAuthorderApi(config);

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

            var alipayMerchantIndirectAuthorderCreateModel = new AlipayMerchantIndirectAuthorderCreateModel(); // AlipayMerchantIndirectAuthorderCreateModel |  (optional) 

            try
            {
                // 商家认证申请单提交
                AlipayMerchantIndirectAuthorderCreateResponseModel result = apiInstance.Create(alipayMerchantIndirectAuthorderCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantIndirectAuthorderApi.Create: " + e.Message );
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
 **alipayMerchantIndirectAuthorderCreateModel** | **AlipayMerchantIndirectAuthorderCreateModel**|  | [optional] 

### Return type

**AlipayMerchantIndirectAuthorderCreateResponseModel**

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

<a name="querystatus"></a>
# **Querystatus**
> AlipayMerchantIndirectAuthorderQuerystatusResponseModel Querystatus (AlipayMerchantIndirectAuthorderQuerystatusModel alipayMerchantIndirectAuthorderQuerystatusModel = null)

查询商家认证申请单状态

查询商家认证申请单状态，以及失败原因

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
    public class QuerystatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMerchantIndirectAuthorderApi(config);

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

            var alipayMerchantIndirectAuthorderQuerystatusModel = new AlipayMerchantIndirectAuthorderQuerystatusModel(); // AlipayMerchantIndirectAuthorderQuerystatusModel |  (optional) 

            try
            {
                // 查询商家认证申请单状态
                AlipayMerchantIndirectAuthorderQuerystatusResponseModel result = apiInstance.Querystatus(alipayMerchantIndirectAuthorderQuerystatusModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantIndirectAuthorderApi.Querystatus: " + e.Message );
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
 **alipayMerchantIndirectAuthorderQuerystatusModel** | **AlipayMerchantIndirectAuthorderQuerystatusModel**|  | [optional] 

### Return type

**AlipayMerchantIndirectAuthorderQuerystatusResponseModel**

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

