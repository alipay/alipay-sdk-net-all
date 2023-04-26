# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityVoucherApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Append**](AlipayMarketingActivityVoucherApi.md#append) | **POST** /v3/alipay/marketing/activity/voucher/append | 追加支付券预算
[**Create**](AlipayMarketingActivityVoucherApi.md#create) | **POST** /v3/alipay/marketing/activity/voucher/create | 创建支付券
[**Modify**](AlipayMarketingActivityVoucherApi.md#modify) | **POST** /v3/alipay/marketing/activity/voucher/modify | 修改支付券基本信息
[**Publish**](AlipayMarketingActivityVoucherApi.md#publish) | **POST** /v3/alipay/marketing/activity/voucher/publish | 激活支付券
[**Query**](AlipayMarketingActivityVoucherApi.md#query) | **GET** /v3/alipay/marketing/activity/voucher/query | 查询支付券详情
[**Send**](AlipayMarketingActivityVoucherApi.md#send) | **POST** /v3/alipay/marketing/activity/voucher/send | 发放支付券
[**Stop**](AlipayMarketingActivityVoucherApi.md#stop) | **POST** /v3/alipay/marketing/activity/voucher/stop | 停止支付券


<a name="append"></a>
# **Append**
> AlipayMarketingActivityVoucherAppendResponseModel Append (AlipayMarketingActivityVoucherAppendModel alipayMarketingActivityVoucherAppendModel = null)

追加支付券预算

支付券激活成功后，调用该接口追加支付券预算。追加支付券预算接口同步返回请求受理结果，后续通过alipay.marketing.activity.message.appended消息接口异步发送追加支付券预算成功事件消息。  如果成功消息长时间未送达，请联系相关技术人员。

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
    public class AppendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var alipayMarketingActivityVoucherAppendModel = new AlipayMarketingActivityVoucherAppendModel(); // AlipayMarketingActivityVoucherAppendModel |  (optional) 

            try
            {
                // 追加支付券预算
                AlipayMarketingActivityVoucherAppendResponseModel result = apiInstance.Append(alipayMarketingActivityVoucherAppendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Append: " + e.Message );
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
 **alipayMarketingActivityVoucherAppendModel** | **AlipayMarketingActivityVoucherAppendModel**|  | [optional] 

### Return type

**AlipayMarketingActivityVoucherAppendResponseModel**

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
> AlipayMarketingActivityVoucherCreateResponseModel Create (AlipayMarketingActivityVoucherCreateModel alipayMarketingActivityVoucherCreateModel = null)

创建支付券

商户通过调用此接口创建支付券，包括预充值&免充值支付券，接口同步返回创建处理结果。创建完成后将获得活动id，可用于各个营销场景的活动投放。

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
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var alipayMarketingActivityVoucherCreateModel = new AlipayMarketingActivityVoucherCreateModel(); // AlipayMarketingActivityVoucherCreateModel |  (optional) 

            try
            {
                // 创建支付券
                AlipayMarketingActivityVoucherCreateResponseModel result = apiInstance.Create(alipayMarketingActivityVoucherCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Create: " + e.Message );
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
 **alipayMarketingActivityVoucherCreateModel** | **AlipayMarketingActivityVoucherCreateModel**|  | [optional] 

### Return type

**AlipayMarketingActivityVoucherCreateResponseModel**

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
> Object Modify (AlipayMarketingActivityVoucherModifyModel alipayMarketingActivityVoucherModifyModel = null)

修改支付券基本信息

商户可以通过该接口修改支付券基本信息。 接口同步返回修改请求受理结果，后续通过alipay.marketing.activity.message.modified消息接口异步发送修改活动成功事件消息。   特别注意：修改支付券接口返回结果并不代表活动修改成功，必须等待消息回调后才能确保成功。 如果成功消息长时间未送达，请联系相关技术人员。 

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
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var alipayMarketingActivityVoucherModifyModel = new AlipayMarketingActivityVoucherModifyModel(); // AlipayMarketingActivityVoucherModifyModel |  (optional) 

            try
            {
                // 修改支付券基本信息
                Object result = apiInstance.Modify(alipayMarketingActivityVoucherModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Modify: " + e.Message );
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
 **alipayMarketingActivityVoucherModifyModel** | **AlipayMarketingActivityVoucherModifyModel**|  | [optional] 

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

<a name="publish"></a>
# **Publish**
> AlipayMarketingActivityVoucherPublishResponseModel Publish (AlipayMarketingActivityVoucherPublishModel alipayMarketingActivityVoucherPublishModel = null)

激活支付券

支付券创建成功后，通过调用此接口激活支付券。 激活支付券接口同步返回请求受理结果，后续通过alipay.marketing.activity.message.created消息接口异步发送激活支付券成功事件消息。 如果成功消息长时间未送达，请联系相关技术人员。 

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
    public class PublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var alipayMarketingActivityVoucherPublishModel = new AlipayMarketingActivityVoucherPublishModel(); // AlipayMarketingActivityVoucherPublishModel |  (optional) 

            try
            {
                // 激活支付券
                AlipayMarketingActivityVoucherPublishResponseModel result = apiInstance.Publish(alipayMarketingActivityVoucherPublishModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Publish: " + e.Message );
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
 **alipayMarketingActivityVoucherPublishModel** | **AlipayMarketingActivityVoucherPublishModel**|  | [optional] 

### Return type

**AlipayMarketingActivityVoucherPublishResponseModel**

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
> AlipayMarketingActivityVoucherQueryResponseModel Query (string activityId = null, string merchantAccessMode = null)

查询支付券详情

通过此接口可查询支付券活动信息，包括活动的配置信息以及活动概况数据。

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
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动 id (optional) 
            var merchantAccessMode = AGENCY_MODE;  // string | 商户接入模式。 (optional) 

            try
            {
                // 查询支付券详情
                AlipayMarketingActivityVoucherQueryResponseModel result = apiInstance.Query(activityId, merchantAccessMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Query: " + e.Message );
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
 **activityId** | **string**| 活动 id | [optional] 
 **merchantAccessMode** | **string**| 商户接入模式。 | [optional] 

### Return type

**AlipayMarketingActivityVoucherQueryResponseModel**

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

<a name="send"></a>
# **Send**
> AlipayMarketingActivityVoucherSendResponseModel Send (AlipayMarketingActivityVoucherSendModel alipayMarketingActivityVoucherSendModel = null)

发放支付券

API完成制券后，可使用发放支付券接口发券。通过调用此接口可发放支付券给指定用户，发券场景可以是小程序、H5、APP等。

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
    public class SendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var alipayMarketingActivityVoucherSendModel = new AlipayMarketingActivityVoucherSendModel(); // AlipayMarketingActivityVoucherSendModel |  (optional) 

            try
            {
                // 发放支付券
                AlipayMarketingActivityVoucherSendResponseModel result = apiInstance.Send(alipayMarketingActivityVoucherSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Send: " + e.Message );
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
 **alipayMarketingActivityVoucherSendModel** | **AlipayMarketingActivityVoucherSendModel**|  | [optional] 

### Return type

**AlipayMarketingActivityVoucherSendResponseModel**

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

<a name="stop"></a>
# **Stop**
> Object Stop (AlipayMarketingActivityVoucherStopModel alipayMarketingActivityVoucherStopModel = null)

停止支付券

商家调用该接口停止支付券。 停止支付券接口同步返回请求受理结果，后续通过alipay.marketing.activity.message.stopped消息接口异步发送停止活动成功事件。 如果成功消息长时间未送达，请联系相关技术人员。

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
    public class StopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityVoucherApi(config);

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

            var alipayMarketingActivityVoucherStopModel = new AlipayMarketingActivityVoucherStopModel(); // AlipayMarketingActivityVoucherStopModel |  (optional) 

            try
            {
                // 停止支付券
                Object result = apiInstance.Stop(alipayMarketingActivityVoucherStopModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityVoucherApi.Stop: " + e.Message );
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
 **alipayMarketingActivityVoucherStopModel** | **AlipayMarketingActivityVoucherStopModel**|  | [optional] 

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

