# AlipaySDKNet.OpenAPI.Api.AlipayFundAccountbookNotifyApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundAccountbookNotifyApi.md#query) | **GET** /v3/alipay/fund/accountbook/notify/query | 记账本通知订阅关系查询接口
[**Subscribe**](AlipayFundAccountbookNotifyApi.md#subscribe) | **POST** /v3/alipay/fund/accountbook/notify/subscribe | 记账本通知订阅接口
[**Unsubscribe**](AlipayFundAccountbookNotifyApi.md#unsubscribe) | **POST** /v3/alipay/fund/accountbook/notify/unsubscribe | 记账本通知取消订阅接口


<a name="query"></a>
# **Query**
> AlipayFundAccountbookNotifyQueryResponseModel Query (string productCode = null, string bizScene = null, string accountBookId = null, string agreementNo = null)

记账本通知订阅关系查询接口

ISV通过此接口查询指定记账本的入金和出金通知的订阅关系

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
            var apiInstance = new AlipayFundAccountbookNotifyApi(config);

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

            var productCode = SATF_FUND_BOOK;  // string | 产品码。固定为SATF_FUND_BOOK (optional) 
            var bizScene = DEFAULT;  // string | 场景码。固定为DEFAULT (optional) 
            var accountBookId = 2088000147677710;  // string | 记账本ID (optional) 
            var agreementNo = 20205724001102186227;  // string | 协议号。 若是基于协议的记账本，则agreement_no必传； 若是自创建的记账本，则agreement_no不传； (optional) 

            try
            {
                // 记账本通知订阅关系查询接口
                AlipayFundAccountbookNotifyQueryResponseModel result = apiInstance.Query(productCode, bizScene, accountBookId, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAccountbookNotifyApi.Query: " + e.Message );
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
 **productCode** | **string**| 产品码。固定为SATF_FUND_BOOK | [optional] 
 **bizScene** | **string**| 场景码。固定为DEFAULT | [optional] 
 **accountBookId** | **string**| 记账本ID | [optional] 
 **agreementNo** | **string**| 协议号。 若是基于协议的记账本，则agreement_no必传； 若是自创建的记账本，则agreement_no不传； | [optional] 

### Return type

**AlipayFundAccountbookNotifyQueryResponseModel**

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

<a name="subscribe"></a>
# **Subscribe**
> AlipayFundAccountbookNotifySubscribeResponseModel Subscribe (AlipayFundAccountbookNotifySubscribeModel alipayFundAccountbookNotifySubscribeModel = null)

记账本通知订阅接口

ISV通过此接口订阅指定记账本的入金和出金通知。目前只有非OpenAPI方式的充值通知（比如大额来账、贷款入金）

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
    public class SubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundAccountbookNotifyApi(config);

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

            var alipayFundAccountbookNotifySubscribeModel = new AlipayFundAccountbookNotifySubscribeModel(); // AlipayFundAccountbookNotifySubscribeModel |  (optional) 

            try
            {
                // 记账本通知订阅接口
                AlipayFundAccountbookNotifySubscribeResponseModel result = apiInstance.Subscribe(alipayFundAccountbookNotifySubscribeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAccountbookNotifyApi.Subscribe: " + e.Message );
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
 **alipayFundAccountbookNotifySubscribeModel** | **AlipayFundAccountbookNotifySubscribeModel**|  | [optional] 

### Return type

**AlipayFundAccountbookNotifySubscribeResponseModel**

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

<a name="unsubscribe"></a>
# **Unsubscribe**
> AlipayFundAccountbookNotifyUnsubscribeResponseModel Unsubscribe (AlipayFundAccountbookNotifyUnsubscribeModel alipayFundAccountbookNotifyUnsubscribeModel = null)

记账本通知取消订阅接口

ISV通过此接口取消订阅指定记账本的入金和出金通知

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
    public class UnsubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundAccountbookNotifyApi(config);

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

            var alipayFundAccountbookNotifyUnsubscribeModel = new AlipayFundAccountbookNotifyUnsubscribeModel(); // AlipayFundAccountbookNotifyUnsubscribeModel |  (optional) 

            try
            {
                // 记账本通知取消订阅接口
                AlipayFundAccountbookNotifyUnsubscribeResponseModel result = apiInstance.Unsubscribe(alipayFundAccountbookNotifyUnsubscribeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAccountbookNotifyApi.Unsubscribe: " + e.Message );
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
 **alipayFundAccountbookNotifyUnsubscribeModel** | **AlipayFundAccountbookNotifyUnsubscribeModel**|  | [optional] 

### Return type

**AlipayFundAccountbookNotifyUnsubscribeResponseModel**

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

