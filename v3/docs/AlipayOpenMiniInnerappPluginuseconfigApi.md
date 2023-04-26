# AlipaySDKNet.OpenAPI.Api.AlipayOpenMiniInnerappPluginuseconfigApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Cancel**](AlipayOpenMiniInnerappPluginuseconfigApi.md#cancel) | **POST** /v3/alipay/open/mini/innerapp/pluginuseconfig/cancel | 撤销插件端版本配置灰度
[**Online**](AlipayOpenMiniInnerappPluginuseconfigApi.md#online) | **POST** /v3/alipay/open/mini/innerapp/pluginuseconfig/online | 上线插件使用端版本配置
[**Upgrade**](AlipayOpenMiniInnerappPluginuseconfigApi.md#upgrade) | **POST** /v3/alipay/open/mini/innerapp/pluginuseconfig/upgrade | 灰度端版本配置


<a name="cancel"></a>
# **Cancel**
> Object Cancel (AlipayOpenMiniInnerappPluginuseconfigCancelModel alipayOpenMiniInnerappPluginuseconfigCancelModel = null)

撤销插件端版本配置灰度

结束插件端版本配置灰度

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
            var apiInstance = new AlipayOpenMiniInnerappPluginuseconfigApi(config);

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

            var alipayOpenMiniInnerappPluginuseconfigCancelModel = new AlipayOpenMiniInnerappPluginuseconfigCancelModel(); // AlipayOpenMiniInnerappPluginuseconfigCancelModel |  (optional) 

            try
            {
                // 撤销插件端版本配置灰度
                Object result = apiInstance.Cancel(alipayOpenMiniInnerappPluginuseconfigCancelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappPluginuseconfigApi.Cancel: " + e.Message );
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
 **alipayOpenMiniInnerappPluginuseconfigCancelModel** | **AlipayOpenMiniInnerappPluginuseconfigCancelModel**|  | [optional] 

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

<a name="online"></a>
# **Online**
> Object Online (AlipayOpenMiniInnerappPluginuseconfigOnlineModel alipayOpenMiniInnerappPluginuseconfigOnlineModel = null)

上线插件使用端版本配置

小程序使用插件版本全量上线

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
    public class OnlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniInnerappPluginuseconfigApi(config);

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

            var alipayOpenMiniInnerappPluginuseconfigOnlineModel = new AlipayOpenMiniInnerappPluginuseconfigOnlineModel(); // AlipayOpenMiniInnerappPluginuseconfigOnlineModel |  (optional) 

            try
            {
                // 上线插件使用端版本配置
                Object result = apiInstance.Online(alipayOpenMiniInnerappPluginuseconfigOnlineModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappPluginuseconfigApi.Online: " + e.Message );
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
 **alipayOpenMiniInnerappPluginuseconfigOnlineModel** | **AlipayOpenMiniInnerappPluginuseconfigOnlineModel**|  | [optional] 

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

<a name="upgrade"></a>
# **Upgrade**
> Object Upgrade (AlipayOpenMiniInnerappPluginuseconfigUpgradeModel alipayOpenMiniInnerappPluginuseconfigUpgradeModel = null)

灰度端版本配置

升级/降级 端版本配置

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
    public class UpgradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenMiniInnerappPluginuseconfigApi(config);

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

            var alipayOpenMiniInnerappPluginuseconfigUpgradeModel = new AlipayOpenMiniInnerappPluginuseconfigUpgradeModel(); // AlipayOpenMiniInnerappPluginuseconfigUpgradeModel |  (optional) 

            try
            {
                // 灰度端版本配置
                Object result = apiInstance.Upgrade(alipayOpenMiniInnerappPluginuseconfigUpgradeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenMiniInnerappPluginuseconfigApi.Upgrade: " + e.Message );
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
 **alipayOpenMiniInnerappPluginuseconfigUpgradeModel** | **AlipayOpenMiniInnerappPluginuseconfigUpgradeModel**|  | [optional] 

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

