# AlipaySDKNet.OpenAPI.Api.AlipayOpenSearchBoxApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayOpenSearchBoxApi.md#apply) | **POST** /v3/alipay/open/search/box/apply | 申请创建搜索直达配置
[**Batchquery**](AlipayOpenSearchBoxApi.md#batchquery) | **POST** /v3/alipay/open/search/box/batchquery | 批量查询搜索直达配置列表
[**Consult**](AlipayOpenSearchBoxApi.md#consult) | **POST** /v3/alipay/open/search/box/consult | 搜索直达创建预校验
[**Modify**](AlipayOpenSearchBoxApi.md#modify) | **POST** /v3/alipay/open/search/box/modify | 修改搜索直达配置
[**Offline**](AlipayOpenSearchBoxApi.md#offline) | **POST** /v3/alipay/open/search/box/offline | 下架搜索直达
[**Online**](AlipayOpenSearchBoxApi.md#online) | **POST** /v3/alipay/open/search/box/online | 上架搜索直达
[**Query**](AlipayOpenSearchBoxApi.md#query) | **GET** /v3/alipay/open/search/box/query | 查询搜索直达配置详情


<a name="apply"></a>
# **Apply**
> AlipayOpenSearchBoxApplyResponseModel Apply (AlipayOpenSearchBoxApplyModel alipayOpenSearchBoxApplyModel = null)

申请创建搜索直达配置

申请创建搜索直达配置，相关概念说明及准入条件详见 <a href=\"https://opendocs.alipay.com/mini/03fjba\"> 搜索直达 </a> 通过该接口创建搜索直达，满足准入门槛时，创建后立马生效。

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
    public class ApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var alipayOpenSearchBoxApplyModel = new AlipayOpenSearchBoxApplyModel(); // AlipayOpenSearchBoxApplyModel |  (optional) 

            try
            {
                // 申请创建搜索直达配置
                AlipayOpenSearchBoxApplyResponseModel result = apiInstance.Apply(alipayOpenSearchBoxApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Apply: " + e.Message );
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
 **alipayOpenSearchBoxApplyModel** | **AlipayOpenSearchBoxApplyModel**|  | [optional] 

### Return type

**AlipayOpenSearchBoxApplyResponseModel**

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

<a name="batchquery"></a>
# **Batchquery**
> AlipayOpenSearchBoxBatchqueryResponseModel Batchquery (AlipayOpenSearchBoxBatchqueryModel alipayOpenSearchBoxBatchqueryModel = null)

批量查询搜索直达配置列表

批量查询商户已开通搜索直达的小程序及直达信息（搜索直达名称和id）

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
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var alipayOpenSearchBoxBatchqueryModel = new AlipayOpenSearchBoxBatchqueryModel(); // AlipayOpenSearchBoxBatchqueryModel |  (optional) 

            try
            {
                // 批量查询搜索直达配置列表
                AlipayOpenSearchBoxBatchqueryResponseModel result = apiInstance.Batchquery(alipayOpenSearchBoxBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Batchquery: " + e.Message );
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
 **alipayOpenSearchBoxBatchqueryModel** | **AlipayOpenSearchBoxBatchqueryModel**|  | [optional] 

### Return type

**AlipayOpenSearchBoxBatchqueryResponseModel**

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

<a name="consult"></a>
# **Consult**
> AlipayOpenSearchBoxConsultResponseModel Consult (AlipayOpenSearchBoxConsultModel alipayOpenSearchBoxConsultModel = null)

搜索直达创建预校验

用于对搜索直达创建申请的入参和条件进行提前判断校验。 具体准入条件参考<a href=\"https://opendocs.alipay.com/pre-open/0311q3#%E5%87%86%E5%85%A5%E6%9D%A1%E4%BB%B6\">搜索直达准入条件</a>

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
    public class ConsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var alipayOpenSearchBoxConsultModel = new AlipayOpenSearchBoxConsultModel(); // AlipayOpenSearchBoxConsultModel |  (optional) 

            try
            {
                // 搜索直达创建预校验
                AlipayOpenSearchBoxConsultResponseModel result = apiInstance.Consult(alipayOpenSearchBoxConsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Consult: " + e.Message );
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
 **alipayOpenSearchBoxConsultModel** | **AlipayOpenSearchBoxConsultModel**|  | [optional] 

### Return type

**AlipayOpenSearchBoxConsultResponseModel**

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

<a name="modify"></a>
# **Modify**
> AlipayOpenSearchBoxModifyResponseModel Modify (AlipayOpenSearchBoxModifyModel alipayOpenSearchBoxModifyModel = null)

修改搜索直达配置

修改搜索直达配置模块，配置对应的模块参考：<a href=\"https://opendocs.alipay.com/mini/03fjba#%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E\"> 搜索直达模块说明 </a>

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
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var alipayOpenSearchBoxModifyModel = new AlipayOpenSearchBoxModifyModel(); // AlipayOpenSearchBoxModifyModel |  (optional) 

            try
            {
                // 修改搜索直达配置
                AlipayOpenSearchBoxModifyResponseModel result = apiInstance.Modify(alipayOpenSearchBoxModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Modify: " + e.Message );
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
 **alipayOpenSearchBoxModifyModel** | **AlipayOpenSearchBoxModifyModel**|  | [optional] 

### Return type

**AlipayOpenSearchBoxModifyResponseModel**

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

<a name="offline"></a>
# **Offline**
> Object Offline (AlipayOpenSearchBoxOfflineModel alipayOpenSearchBoxOfflineModel = null)

下架搜索直达

若不需要运营搜索直达时，可调用次接口下架搜索直达

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
    public class OfflineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var alipayOpenSearchBoxOfflineModel = new AlipayOpenSearchBoxOfflineModel(); // AlipayOpenSearchBoxOfflineModel |  (optional) 

            try
            {
                // 下架搜索直达
                Object result = apiInstance.Offline(alipayOpenSearchBoxOfflineModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Offline: " + e.Message );
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
 **alipayOpenSearchBoxOfflineModel** | **AlipayOpenSearchBoxOfflineModel**|  | [optional] 

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
> Object Online (AlipayOpenSearchBoxOnlineModel alipayOpenSearchBoxOnlineModel = null)

上架搜索直达

若搜索直达处于下架状态时，可通过此接口来重新上架直达，上架须满足搜索直达准入门槛，若不满足，则会上架失败并报错

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
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var alipayOpenSearchBoxOnlineModel = new AlipayOpenSearchBoxOnlineModel(); // AlipayOpenSearchBoxOnlineModel |  (optional) 

            try
            {
                // 上架搜索直达
                Object result = apiInstance.Online(alipayOpenSearchBoxOnlineModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Online: " + e.Message );
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
 **alipayOpenSearchBoxOnlineModel** | **AlipayOpenSearchBoxOnlineModel**|  | [optional] 

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
> AlipayOpenSearchBoxQueryResponseModel Query (string boxId = null, string merchantId = null)

查询搜索直达配置详情

查询商户已开通搜索直达的小程序及直达信息（搜索直达名称和id），各模块说明详见 <a href=\"https://opendocs.alipay.com/mini/03fjba\"> 搜索直达 </a>。

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
            var apiInstance = new AlipayOpenSearchBoxApi(config);

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

            var boxId = 20220308000000128693;  // string | 搜索直达配置id (optional) 
            var merchantId = 2088xxxxxxxxxxxx;  // string | 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\"运营支付宝小程序\"授权。 (optional) 

            try
            {
                // 查询搜索直达配置详情
                AlipayOpenSearchBoxQueryResponseModel result = apiInstance.Query(boxId, merchantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenSearchBoxApi.Query: " + e.Message );
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
 **boxId** | **string**| 搜索直达配置id | [optional] 
 **merchantId** | **string**| 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。 | [optional] 

### Return type

**AlipayOpenSearchBoxQueryResponseModel**

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

