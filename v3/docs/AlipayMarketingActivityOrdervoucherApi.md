# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityOrdervoucherApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Append**](AlipayMarketingActivityOrdervoucherApi.md#append) | **PATCH** /v3/alipay/marketing/ordervoucher/activity/{activity_id}/append | 修改商家券活动发券数量上限
[**Associate**](AlipayMarketingActivityOrdervoucherApi.md#associate) | **POST** /v3/alipay/marketing/activity/ordervoucher/associate | 关联订单信息
[**Codecount**](AlipayMarketingActivityOrdervoucherApi.md#codecount) | **GET** /v3/alipay/marketing/ordervoucher/activity/{activity_id}/voucher/codecount | 统计商家券券码数量
[**Codedeposit**](AlipayMarketingActivityOrdervoucherApi.md#codedeposit) | **POST** /v3/alipay/marketing/ordervoucher/activity/{activity_id}/voucher/codedeposit | 同步商家券券码
[**Create**](AlipayMarketingActivityOrdervoucherApi.md#create) | **POST** /v3/alipay/marketing/ordervoucher/activity | 创建商家券活动
[**Disassociate**](AlipayMarketingActivityOrdervoucherApi.md#disassociate) | **POST** /v3/alipay/marketing/activity/ordervoucher/disassociate | 取消关联订单信息
[**Modify**](AlipayMarketingActivityOrdervoucherApi.md#modify) | **PATCH** /v3/alipay/marketing/ordervoucher/activity/{activity_id} | 修改商家券活动基本信息
[**Query**](AlipayMarketingActivityOrdervoucherApi.md#query) | **GET** /v3/alipay/marketing/activity/ordervoucher/query | 查询商家券活动
[**Refund**](AlipayMarketingActivityOrdervoucherApi.md#refund) | **POST** /v3/alipay/marketing/ordervoucher/activity/{activity_id}/voucher/{voucher_code}/refund | 取消券核销状态
[**Stop**](AlipayMarketingActivityOrdervoucherApi.md#stop) | **PATCH** /v3/alipay/marketing/ordervoucher/activity/{activity_id}/stop | 停止商家券活动
[**Use**](AlipayMarketingActivityOrdervoucherApi.md#use) | **POST** /v3/alipay/marketing/ordervoucher/activity/{activity_id}/voucher/{voucher_code}/use | 同步券核销状态


<a name="append"></a>
# **Append**
> Object Append (string activityId, AlipayMarketingActivityOrdervoucherAppendModel alipayMarketingActivityOrdervoucherAppendModel = null)

修改商家券活动发券数量上限

商家调用该接口修改商家券活动预算上限，以此来追加商家券活动预算。 修改商家券活动预算上限同步返回追加请求受理结果，后续通过alipay.marketing.activity.message.appended消息接口异步发送发券数量上限修改成功事件消息。 code_mode=MERCHANT_UPLOAD场景下，必须先导入券码后，方可追加商家券预算。

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
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id
            var alipayMarketingActivityOrdervoucherAppendModel = new AlipayMarketingActivityOrdervoucherAppendModel(); // AlipayMarketingActivityOrdervoucherAppendModel |  (optional) 

            try
            {
                // 修改商家券活动发券数量上限
                Object result = apiInstance.Append(activityId, alipayMarketingActivityOrdervoucherAppendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Append: " + e.Message );
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
 **activityId** | **string**| 活动id | 
 **alipayMarketingActivityOrdervoucherAppendModel** | **AlipayMarketingActivityOrdervoucherAppendModel**|  | [optional] 

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

<a name="associate"></a>
# **Associate**
> AlipayMarketingActivityOrdervoucherAssociateResponseModel Associate (AlipayMarketingActivityOrdervoucherAssociateModel alipayMarketingActivityOrdervoucherAssociateModel = null)

关联订单信息

将已发放的商家券券码与订单信息关联，用于后续参与返佣激励等操作的统计。 

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
    public class AssociateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var alipayMarketingActivityOrdervoucherAssociateModel = new AlipayMarketingActivityOrdervoucherAssociateModel(); // AlipayMarketingActivityOrdervoucherAssociateModel |  (optional) 

            try
            {
                // 关联订单信息
                AlipayMarketingActivityOrdervoucherAssociateResponseModel result = apiInstance.Associate(alipayMarketingActivityOrdervoucherAssociateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Associate: " + e.Message );
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
 **alipayMarketingActivityOrdervoucherAssociateModel** | **AlipayMarketingActivityOrdervoucherAssociateModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherAssociateResponseModel**

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

<a name="codecount"></a>
# **Codecount**
> AlipayMarketingActivityOrdervoucherCodecountResponseModel Codecount (string activityId, string merchantAccessMode = null)

统计商家券券码数量

商家调用该接口查询活动中的有效券码个数。接口同步返回查询结果。

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
    public class CodecountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id
            var merchantAccessMode = SELF_MODE;  // string | 商户接入模式 (optional) 

            try
            {
                // 统计商家券券码数量
                AlipayMarketingActivityOrdervoucherCodecountResponseModel result = apiInstance.Codecount(activityId, merchantAccessMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Codecount: " + e.Message );
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
 **activityId** | **string**| 活动id | 
 **merchantAccessMode** | **string**| 商户接入模式 | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherCodecountResponseModel**

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

<a name="codedeposit"></a>
# **Codedeposit**
> AlipayMarketingActivityOrdervoucherCodedepositResponseModel Codedeposit (string activityId, AlipayMarketingActivityOrdervoucherCodedepositModel alipayMarketingActivityOrdervoucherCodedepositModel = null)

同步商家券券码

商家调用该接口同步导入商家券券码，接口同步返回导入结果。请在接收alipay.marketing.activity.message.created消息后，再进行调用。

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
    public class CodedepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id  限制 请在接收alipay.marketing.activity.message.created消息后，再进行调用。
            var alipayMarketingActivityOrdervoucherCodedepositModel = new AlipayMarketingActivityOrdervoucherCodedepositModel(); // AlipayMarketingActivityOrdervoucherCodedepositModel |  (optional) 

            try
            {
                // 同步商家券券码
                AlipayMarketingActivityOrdervoucherCodedepositResponseModel result = apiInstance.Codedeposit(activityId, alipayMarketingActivityOrdervoucherCodedepositModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Codedeposit: " + e.Message );
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
 **activityId** | **string**| 活动id  限制 请在接收alipay.marketing.activity.message.created消息后，再进行调用。 | 
 **alipayMarketingActivityOrdervoucherCodedepositModel** | **AlipayMarketingActivityOrdervoucherCodedepositModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherCodedepositResponseModel**

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
> AlipayMarketingActivityOrdervoucherCreateResponseModel Create (AlipayMarketingActivityOrdervoucherCreateModel alipayMarketingActivityOrdervoucherCreateModel = null)

创建商家券活动

商家调用该接口创建商家券活动。 创建商家券活动接口同步返回创建请求受理结果，后续通过alipay.marketing.activity.message.created消息接口异步发送活动创建成功事件消息。  如果在code_mode=MERCHANT_UPLOAD的模式下，创建商家券活动后，还需要进行券码导入操作，以及预算追加操作，然后商家券才能进行发放。

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
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var alipayMarketingActivityOrdervoucherCreateModel = new AlipayMarketingActivityOrdervoucherCreateModel(); // AlipayMarketingActivityOrdervoucherCreateModel |  (optional) 

            try
            {
                // 创建商家券活动
                AlipayMarketingActivityOrdervoucherCreateResponseModel result = apiInstance.Create(alipayMarketingActivityOrdervoucherCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Create: " + e.Message );
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
 **alipayMarketingActivityOrdervoucherCreateModel** | **AlipayMarketingActivityOrdervoucherCreateModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherCreateResponseModel**

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

<a name="disassociate"></a>
# **Disassociate**
> AlipayMarketingActivityOrdervoucherDisassociateResponseModel Disassociate (AlipayMarketingActivityOrdervoucherDisassociateModel alipayMarketingActivityOrdervoucherDisassociateModel = null)

取消关联订单信息

取消商家券与订单信息的关联关系.

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
    public class DisassociateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var alipayMarketingActivityOrdervoucherDisassociateModel = new AlipayMarketingActivityOrdervoucherDisassociateModel(); // AlipayMarketingActivityOrdervoucherDisassociateModel |  (optional) 

            try
            {
                // 取消关联订单信息
                AlipayMarketingActivityOrdervoucherDisassociateResponseModel result = apiInstance.Disassociate(alipayMarketingActivityOrdervoucherDisassociateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Disassociate: " + e.Message );
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
 **alipayMarketingActivityOrdervoucherDisassociateModel** | **AlipayMarketingActivityOrdervoucherDisassociateModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherDisassociateResponseModel**

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
> AlipayMarketingActivityOrdervoucherModifyResponseModel Modify (string activityId, AlipayMarketingActivityOrdervoucherModifyModel alipayMarketingActivityOrdervoucherModifyModel = null)

修改商家券活动基本信息

商家调用该接口修改商家券活动基本信息。 修改商家券活动基本信息接口同步返回修改请求受理结果，后续通过alipay.marketing.activity.message.modified消息接口异步发送修改活动成功事件消息。

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
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id1
            var alipayMarketingActivityOrdervoucherModifyModel = new AlipayMarketingActivityOrdervoucherModifyModel(); // AlipayMarketingActivityOrdervoucherModifyModel |  (optional) 

            try
            {
                // 修改商家券活动基本信息
                AlipayMarketingActivityOrdervoucherModifyResponseModel result = apiInstance.Modify(activityId, alipayMarketingActivityOrdervoucherModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Modify: " + e.Message );
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
 **activityId** | **string**| 活动id1 | 
 **alipayMarketingActivityOrdervoucherModifyModel** | **AlipayMarketingActivityOrdervoucherModifyModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherModifyResponseModel**

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
> AlipayMarketingActivityOrdervoucherQueryResponseModel Query (string activityId = null, string merchantAccessMode = null)

查询商家券活动

商户通过该接口查询商家券活动详情。

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
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id (optional) 
            var merchantAccessMode = AGENCY_MODE;  // string | 商户接入模式 (optional) 

            try
            {
                // 查询商家券活动
                AlipayMarketingActivityOrdervoucherQueryResponseModel result = apiInstance.Query(activityId, merchantAccessMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Query: " + e.Message );
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
 **activityId** | **string**| 活动id | [optional] 
 **merchantAccessMode** | **string**| 商户接入模式 | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherQueryResponseModel**

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

<a name="refund"></a>
# **Refund**
> AlipayMarketingActivityOrdervoucherRefundResponseModel Refund (string activityId, string voucherCode, AlipayMarketingActivityOrdervoucherRefundModel alipayMarketingActivityOrdervoucherRefundModel = null)

取消券核销状态

商户调用该接口进行优惠券退券处理。接口同步返回结果。 如果优惠券过期后，发起退券操作，该接口返回成功，优惠券退回后仍不可用。 如果优惠券在支付宝卡包已删除，发起退券操作，该接口返回成功，优惠券在支付宝卡包仍然是删除状态。

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
    public class RefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 优惠券活动id
            var voucherCode = ABE44;  // string | 已核销待退券的券码
            var alipayMarketingActivityOrdervoucherRefundModel = new AlipayMarketingActivityOrdervoucherRefundModel(); // AlipayMarketingActivityOrdervoucherRefundModel |  (optional) 

            try
            {
                // 取消券核销状态
                AlipayMarketingActivityOrdervoucherRefundResponseModel result = apiInstance.Refund(activityId, voucherCode, alipayMarketingActivityOrdervoucherRefundModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Refund: " + e.Message );
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
 **activityId** | **string**| 优惠券活动id | 
 **voucherCode** | **string**| 已核销待退券的券码 | 
 **alipayMarketingActivityOrdervoucherRefundModel** | **AlipayMarketingActivityOrdervoucherRefundModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherRefundResponseModel**

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
> Object Stop (string activityId, AlipayMarketingActivityOrdervoucherStopModel alipayMarketingActivityOrdervoucherStopModel = null)

停止商家券活动

商家调用该接口停止优惠券。 停止优惠券接口同步返回停止请求受理结果，后续通过alipay.marketing.activity.message.stopped消息接口异步发送停止活动成功事件。 如果成功消息长时间未送达，请联系相关技术人员。

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
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id
            var alipayMarketingActivityOrdervoucherStopModel = new AlipayMarketingActivityOrdervoucherStopModel(); // AlipayMarketingActivityOrdervoucherStopModel |  (optional) 

            try
            {
                // 停止商家券活动
                Object result = apiInstance.Stop(activityId, alipayMarketingActivityOrdervoucherStopModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Stop: " + e.Message );
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
 **activityId** | **string**| 活动id | 
 **alipayMarketingActivityOrdervoucherStopModel** | **AlipayMarketingActivityOrdervoucherStopModel**|  | [optional] 

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

<a name="use"></a>
# **Use**
> AlipayMarketingActivityOrdervoucherUseResponseModel Use (string activityId, string voucherCode, AlipayMarketingActivityOrdervoucherUseModel alipayMarketingActivityOrdervoucherUseModel = null)

同步券核销状态

商户调用该接口，通过券码进行优惠券核销，接口同步返回核销结果。

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
    public class UseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityOrdervoucherApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 优惠券活动id
            var voucherCode = ABE44;  // string | 待核销的券码。
            var alipayMarketingActivityOrdervoucherUseModel = new AlipayMarketingActivityOrdervoucherUseModel(); // AlipayMarketingActivityOrdervoucherUseModel |  (optional) 

            try
            {
                // 同步券核销状态
                AlipayMarketingActivityOrdervoucherUseResponseModel result = apiInstance.Use(activityId, voucherCode, alipayMarketingActivityOrdervoucherUseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityOrdervoucherApi.Use: " + e.Message );
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
 **activityId** | **string**| 优惠券活动id | 
 **voucherCode** | **string**| 待核销的券码。 | 
 **alipayMarketingActivityOrdervoucherUseModel** | **AlipayMarketingActivityOrdervoucherUseModel**|  | [optional] 

### Return type

**AlipayMarketingActivityOrdervoucherUseResponseModel**

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

