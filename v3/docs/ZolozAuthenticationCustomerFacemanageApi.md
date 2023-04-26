# AlipaySDKNet.OpenAPI.Api.ZolozAuthenticationCustomerFacemanageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](ZolozAuthenticationCustomerFacemanageApi.md#create) | **POST** /v3/zoloz/authentication/customer/facemanage/create | 热脸入库
[**Delete**](ZolozAuthenticationCustomerFacemanageApi.md#delete) | **POST** /v3/zoloz/authentication/customer/facemanage/delete | 热脸出库


<a name="create"></a>
# **Create**
> ZolozAuthenticationCustomerFacemanageCreateResponseModel Create (ZolozAuthenticationCustomerFacemanageCreateModel zolozAuthenticationCustomerFacemanageCreateModel = null)

热脸入库

热脸入库

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
            var apiInstance = new ZolozAuthenticationCustomerFacemanageApi(config);

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

            var zolozAuthenticationCustomerFacemanageCreateModel = new ZolozAuthenticationCustomerFacemanageCreateModel(); // ZolozAuthenticationCustomerFacemanageCreateModel |  (optional) 

            try
            {
                // 热脸入库
                ZolozAuthenticationCustomerFacemanageCreateResponseModel result = apiInstance.Create(zolozAuthenticationCustomerFacemanageCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZolozAuthenticationCustomerFacemanageApi.Create: " + e.Message );
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
 **zolozAuthenticationCustomerFacemanageCreateModel** | **ZolozAuthenticationCustomerFacemanageCreateModel**|  | [optional] 

### Return type

**ZolozAuthenticationCustomerFacemanageCreateResponseModel**

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

<a name="delete"></a>
# **Delete**
> ZolozAuthenticationCustomerFacemanageDeleteResponseModel Delete (ZolozAuthenticationCustomerFacemanageDeleteModel zolozAuthenticationCustomerFacemanageDeleteModel = null)

热脸出库

出库逻辑

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
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZolozAuthenticationCustomerFacemanageApi(config);

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

            var zolozAuthenticationCustomerFacemanageDeleteModel = new ZolozAuthenticationCustomerFacemanageDeleteModel(); // ZolozAuthenticationCustomerFacemanageDeleteModel |  (optional) 

            try
            {
                // 热脸出库
                ZolozAuthenticationCustomerFacemanageDeleteResponseModel result = apiInstance.Delete(zolozAuthenticationCustomerFacemanageDeleteModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZolozAuthenticationCustomerFacemanageApi.Delete: " + e.Message );
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
 **zolozAuthenticationCustomerFacemanageDeleteModel** | **ZolozAuthenticationCustomerFacemanageDeleteModel**|  | [optional] 

### Return type

**ZolozAuthenticationCustomerFacemanageDeleteResponseModel**

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

