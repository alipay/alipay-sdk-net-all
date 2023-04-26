# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicAccountApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayOpenPublicAccountApi.md#create) | **POST** /v3/alipay/open/public/account/create | 添加绑定商户会员号
[**Delete**](AlipayOpenPublicAccountApi.md#delete) | **DELETE** /v3/alipay/open/public/account/delete | 解除绑定商户会员号
[**Query**](AlipayOpenPublicAccountApi.md#query) | **GET** /v3/alipay/open/public/account/query | 查询绑定商户会员号
[**Reset**](AlipayOpenPublicAccountApi.md#reset) | **POST** /v3/alipay/open/public/account/reset | 重新设置绑定商家会员号


<a name="create"></a>
# **Create**
> AlipayOpenPublicAccountCreateResponseModel Create (AlipayOpenPublicAccountCreateModel alipayOpenPublicAccountCreateModel = null)

添加绑定商户会员号

当用户成为商户的关注用户后，可以在商户的服务窗中点击“添加绑定商户会员号”功能，支付宝系统收到操作请求后将该动作通知给商户（使用用户发送信息到商户接口，其中eventType（事件类型）为click，actionParam（按钮标识）为authentication），商户根据此通知调用商户回复消息接口（其中须包含Url链接地址），支付宝收到商户的回复消息中的链接地址后，自动跳转至商户平台的上商户会员绑定界面中，让用户完成账户绑定。 当用户有效完成账户绑定后，商户调用本接口，把绑定结果数据通知给支付宝。

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
            var apiInstance = new AlipayOpenPublicAccountApi(config);

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

            var alipayOpenPublicAccountCreateModel = new AlipayOpenPublicAccountCreateModel(); // AlipayOpenPublicAccountCreateModel |  (optional) 

            try
            {
                // 添加绑定商户会员号
                AlipayOpenPublicAccountCreateResponseModel result = apiInstance.Create(alipayOpenPublicAccountCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicAccountApi.Create: " + e.Message );
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
 **alipayOpenPublicAccountCreateModel** | **AlipayOpenPublicAccountCreateModel**|  | [optional] 

### Return type

**AlipayOpenPublicAccountCreateResponseModel**

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
> Object Delete (string agreementId = null, string bindAccountNo = null, string fromUserId = null, string openId = null)

解除绑定商户会员号

在支付宝服务窗中目前一共有三种解除绑定商户会员号的场景，具体如下：  用户取消关注服务窗  用户在服务窗内手动执行解除绑定操作  开发者调用解除绑定商户会员号接口解除绑定

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
            var apiInstance = new AlipayOpenPublicAccountApi(config);

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

            var agreementId = 29022222;  // string | 协议号，商户会员在支付宝服务窗账号中的唯一标识，与bind_account_no不能同时为空 (optional) 
            var bindAccountNo = test001;  // string | 绑定帐号，建议在开发者的系统中保持唯一性，与agreement_id不能同时为空 (optional) 
            var fromUserId = 2088656734541243;  // string | 绑定用户的支付宝userid，2088开头16位长度的字符串，与agreementId不能同时为空 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 支付宝用户的唯一标识 (optional) 

            try
            {
                // 解除绑定商户会员号
                Object result = apiInstance.Delete(agreementId, bindAccountNo, fromUserId, openId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicAccountApi.Delete: " + e.Message );
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
 **agreementId** | **string**| 协议号，商户会员在支付宝服务窗账号中的唯一标识，与bind_account_no不能同时为空 | [optional] 
 **bindAccountNo** | **string**| 绑定帐号，建议在开发者的系统中保持唯一性，与agreement_id不能同时为空 | [optional] 
 **fromUserId** | **string**| 绑定用户的支付宝userid，2088开头16位长度的字符串，与agreementId不能同时为空 | [optional] 
 **openId** | **string**| 支付宝用户的唯一标识 | [optional] 

### Return type

**Object**

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

<a name="query"></a>
# **Query**
> AlipayOpenPublicAccountQueryResponseModel Query (string userId = null, string openId = null)

查询绑定商户会员号

当用户成为商户的关注用户之后，则商户可以通过本接口查询关注者的绑定账户，以便补全异常情况下的单边账户数据。

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
            var apiInstance = new AlipayOpenPublicAccountApi(config);

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

            var userId = 2088123412341234;  // string | 用户的支付宝用户号，2088开头。 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 支付宝用户的唯一标识 (optional) 

            try
            {
                // 查询绑定商户会员号
                AlipayOpenPublicAccountQueryResponseModel result = apiInstance.Query(userId, openId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicAccountApi.Query: " + e.Message );
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
 **userId** | **string**| 用户的支付宝用户号，2088开头。 | [optional] 
 **openId** | **string**| 支付宝用户的唯一标识 | [optional] 

### Return type

**AlipayOpenPublicAccountQueryResponseModel**

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

<a name="reset"></a>
# **Reset**
> AlipayOpenPublicAccountResetResponseModel Reset (AlipayOpenPublicAccountResetModel alipayOpenPublicAccountResetModel = null)

重新设置绑定商家会员号

如果商户想要重置已经添加的外部账户，可以通过该接口完成。重置后，原有的外部户将删除，新的外部户添加进去。

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
    public class ResetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayOpenPublicAccountApi(config);

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

            var alipayOpenPublicAccountResetModel = new AlipayOpenPublicAccountResetModel(); // AlipayOpenPublicAccountResetModel |  (optional) 

            try
            {
                // 重新设置绑定商家会员号
                AlipayOpenPublicAccountResetResponseModel result = apiInstance.Reset(alipayOpenPublicAccountResetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicAccountApi.Reset: " + e.Message );
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
 **alipayOpenPublicAccountResetModel** | **AlipayOpenPublicAccountResetModel**|  | [optional] 

### Return type

**AlipayOpenPublicAccountResetResponseModel**

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

