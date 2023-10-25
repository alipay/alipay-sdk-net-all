# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCardApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Delete**](AlipayMarketingCardApi.md#delete) | **DELETE** /v3/alipay/marketing/card/delete | 会员卡删卡
[**Open**](AlipayMarketingCardApi.md#open) | **POST** /v3/alipay/marketing/card/open | 会员卡开卡
[**Query**](AlipayMarketingCardApi.md#query) | **POST** /v3/alipay/marketing/card/query | 会员卡查询
[**Update**](AlipayMarketingCardApi.md#update) | **POST** /v3/alipay/marketing/card/update | 会员卡更新


<a name="delete"></a>
# **Delete**
> AlipayMarketingCardDeleteResponseModel Delete (string outSerialNo = null, string targetCardNo = null, string targetCardNoType = null, string reasonCode = null, string extInfo = null)

会员卡删卡

通过 API 接口删除商家会员卡。

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
            var apiInstance = new AlipayMarketingCardApi(config);

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

            var outSerialNo = 2016062700001;  // string | 商户端删卡业务流水号，商户自定义且需确保流水号唯一性。 (optional) 
            var targetCardNo = 0000001;  // string | 支付宝业务卡号。即开卡接口返回结果中的card_info.biz_card_no。 (optional) 
            var targetCardNoType = BIZ_CARD;  // string | 卡号ID类型 (optional) 
            var reasonCode = USER_UNBUND;  // string | 删卡原因  USER_UNBUND：用户解绑（可以重新绑定）  CANCEL：销户（完成销户后，就不能再重新绑定）  PRESENT：转赠（可以重新绑定） (optional) 
            var extInfo = {"new_card_no":"12345"," donee_user_id":"2088102130652460"};  // string | 删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  new_card_no：新卡号  donee_user_id：受赠人userId (optional) 

            try
            {
                // 会员卡删卡
                AlipayMarketingCardDeleteResponseModel result = apiInstance.Delete(outSerialNo, targetCardNo, targetCardNoType, reasonCode, extInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardApi.Delete: " + e.Message );
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
 **outSerialNo** | **string**| 商户端删卡业务流水号，商户自定义且需确保流水号唯一性。 | [optional] 
 **targetCardNo** | **string**| 支付宝业务卡号。即开卡接口返回结果中的card_info.biz_card_no。 | [optional] 
 **targetCardNoType** | **string**| 卡号ID类型 | [optional] 
 **reasonCode** | **string**| 删卡原因  USER_UNBUND：用户解绑（可以重新绑定）  CANCEL：销户（完成销户后，就不能再重新绑定）  PRESENT：转赠（可以重新绑定） | [optional] 
 **extInfo** | **string**| 删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  new_card_no：新卡号  donee_user_id：受赠人userId | [optional] 

### Return type

**AlipayMarketingCardDeleteResponseModel**

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

<a name="open"></a>
# **Open**
> AlipayMarketingCardOpenResponseModel Open (string authToken = null, AlipayMarketingCardOpenModel alipayMarketingCardOpenModel = null)

会员卡开卡

商户通过API接口，进行会员卡开卡。

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
    public class OpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingCardApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var alipayMarketingCardOpenModel = new AlipayMarketingCardOpenModel(); // AlipayMarketingCardOpenModel |  (optional) 

            try
            {
                // 会员卡开卡
                AlipayMarketingCardOpenResponseModel result = apiInstance.Open(authToken, alipayMarketingCardOpenModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardApi.Open: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **alipayMarketingCardOpenModel** | **AlipayMarketingCardOpenModel**|  | [optional] 

### Return type

**AlipayMarketingCardOpenResponseModel**

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
> AlipayMarketingCardQueryResponseModel Query (AlipayMarketingCardQueryModel alipayMarketingCardQueryModel = null)

会员卡查询

根据卡号或者持卡人信息查询会员卡信息

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
            var apiInstance = new AlipayMarketingCardApi(config);

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

            var alipayMarketingCardQueryModel = new AlipayMarketingCardQueryModel(); // AlipayMarketingCardQueryModel |  (optional) 

            try
            {
                // 会员卡查询
                AlipayMarketingCardQueryResponseModel result = apiInstance.Query(alipayMarketingCardQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardApi.Query: " + e.Message );
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
 **alipayMarketingCardQueryModel** | **AlipayMarketingCardQueryModel**|  | [optional] 

### Return type

**AlipayMarketingCardQueryResponseModel**

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

<a name="update"></a>
# **Update**
> AlipayMarketingCardUpdateResponseModel Update (AlipayMarketingCardUpdateModel alipayMarketingCardUpdateModel = null)

会员卡更新

会员卡更新

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
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingCardApi(config);

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

            var alipayMarketingCardUpdateModel = new AlipayMarketingCardUpdateModel(); // AlipayMarketingCardUpdateModel |  (optional) 

            try
            {
                // 会员卡更新
                AlipayMarketingCardUpdateResponseModel result = apiInstance.Update(alipayMarketingCardUpdateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardApi.Update: " + e.Message );
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
 **alipayMarketingCardUpdateModel** | **AlipayMarketingCardUpdateModel**|  | [optional] 

### Return type

**AlipayMarketingCardUpdateResponseModel**

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

