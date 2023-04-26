# AlipaySDKNet.OpenAPI.Api.AlipayEcoEduKtBillingApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayEcoEduKtBillingApi.md#modify) | **POST** /v3/alipay/eco/edu/kt/billing/modify | 教育缴费账单状态同步接口
[**Query**](AlipayEcoEduKtBillingApi.md#query) | **GET** /v3/alipay/eco/edu/kt/billing/query | 缴费账单查询
[**Send**](AlipayEcoEduKtBillingApi.md#send) | **POST** /v3/alipay/eco/edu/kt/billing/send | 教育缴费账单发送接口


<a name="modify"></a>
# **Modify**
> AlipayEcoEduKtBillingModifyResponseModel Modify (AlipayEcoEduKtBillingModifyModel alipayEcoEduKtBillingModifyModel = null)

教育缴费账单状态同步接口

isv向支付宝－中小学－教育缴费发送教育缴费账单后，家长在支付宝－中小学－教育缴费中对账单完成支付操作且支付成功，ISV在自有系统内容对账，完成后通过此接口同步对账后的账单状态。状态分为：缴费成功、缴费失败。

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
            var apiInstance = new AlipayEcoEduKtBillingApi(config);

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

            var alipayEcoEduKtBillingModifyModel = new AlipayEcoEduKtBillingModifyModel(); // AlipayEcoEduKtBillingModifyModel |  (optional) 

            try
            {
                // 教育缴费账单状态同步接口
                AlipayEcoEduKtBillingModifyResponseModel result = apiInstance.Modify(alipayEcoEduKtBillingModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoEduKtBillingApi.Modify: " + e.Message );
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
 **alipayEcoEduKtBillingModifyModel** | **AlipayEcoEduKtBillingModifyModel**|  | [optional] 

### Return type

**AlipayEcoEduKtBillingModifyResponseModel**

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
> AlipayEcoEduKtBillingQueryResponseModel Query (string isvPid = null, string schoolPid = null, string outTradeNo = null)

缴费账单查询

缴费账单查询

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
            var apiInstance = new AlipayEcoEduKtBillingApi(config);

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

            var isvPid = 2088121212121212;  // string | Isv pid (optional) 
            var schoolPid = 2088101117955611;  // string | 学校支付宝pid，直付通填写smid (optional) 
            var outTradeNo = 58de07de7bb90a437553e464;  // string | ISV调用发送账单接口，返回给商户的order_no (optional) 

            try
            {
                // 缴费账单查询
                AlipayEcoEduKtBillingQueryResponseModel result = apiInstance.Query(isvPid, schoolPid, outTradeNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoEduKtBillingApi.Query: " + e.Message );
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
 **isvPid** | **string**| Isv pid | [optional] 
 **schoolPid** | **string**| 学校支付宝pid，直付通填写smid | [optional] 
 **outTradeNo** | **string**| ISV调用发送账单接口，返回给商户的order_no | [optional] 

### Return type

**AlipayEcoEduKtBillingQueryResponseModel**

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
> AlipayEcoEduKtBillingSendResponseModel Send (AlipayEcoEduKtBillingSendModel alipayEcoEduKtBillingSendModel = null)

教育缴费账单发送接口

商家发送教育缴费账单给孩子，家长在支付宝可以查看自己绑定的孩子的缴费账单。

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
            var apiInstance = new AlipayEcoEduKtBillingApi(config);

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

            var alipayEcoEduKtBillingSendModel = new AlipayEcoEduKtBillingSendModel(); // AlipayEcoEduKtBillingSendModel |  (optional) 

            try
            {
                // 教育缴费账单发送接口
                AlipayEcoEduKtBillingSendResponseModel result = apiInstance.Send(alipayEcoEduKtBillingSendModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoEduKtBillingApi.Send: " + e.Message );
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
 **alipayEcoEduKtBillingSendModel** | **AlipayEcoEduKtBillingSendModel**|  | [optional] 

### Return type

**AlipayEcoEduKtBillingSendResponseModel**

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

