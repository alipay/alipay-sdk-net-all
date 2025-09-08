# AlipaySDKNet.OpenAPI.Api.AlipayFundAccountbookApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayFundAccountbookApi.md#create) | **POST** /v3/alipay/fund/accountbook/create | 资金记账本开通
[**Query**](AlipayFundAccountbookApi.md#query) | **GET** /v3/alipay/fund/accountbook/query | 资金记账本的信息查询


<a name="create"></a>
# **Create**
> AlipayFundAccountbookCreateResponseModel Create (AlipayFundAccountbookCreateModel alipayFundAccountbookCreateModel = null)

资金记账本开通

资金记账本开通

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
            var apiInstance = new AlipayFundAccountbookApi(config);

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

            var alipayFundAccountbookCreateModel = new AlipayFundAccountbookCreateModel(); // AlipayFundAccountbookCreateModel |  (optional) 

            try
            {
                // 资金记账本开通
                AlipayFundAccountbookCreateResponseModel result = apiInstance.Create(alipayFundAccountbookCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAccountbookApi.Create: " + e.Message );
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
 **alipayFundAccountbookCreateModel** | **AlipayFundAccountbookCreateModel**|  | [optional] 

### Return type

**AlipayFundAccountbookCreateResponseModel**

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
> AlipayFundAccountbookQueryResponseModel Query (string accountBookId = null, string merchantUserId = null, string sceneCode = null, string extInfo = null)

资金记账本的信息查询

资金记账本的信息查询

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
            var apiInstance = new AlipayFundAccountbookApi(config);

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

            var accountBookId = 2088001409188095;  // string | 记账账簿id (optional) 
            var merchantUserId = 243893499;  // string | 商户会员的唯一标识，如果传入account_book_id此字段必传并比对一致性。 (optional) 
            var sceneCode = SATF_FUND_BOOK;  // string | 资金记账本的开通场景码 (optional) 
            var extInfo = {"agreement_no":"2019000000000"};  // string | 传递业务扩展参数。 注意：ext_info字段本质上是String类型，所以传递 的是转义后的json字符串。 (optional) 

            try
            {
                // 资金记账本的信息查询
                AlipayFundAccountbookQueryResponseModel result = apiInstance.Query(accountBookId, merchantUserId, sceneCode, extInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAccountbookApi.Query: " + e.Message );
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
 **accountBookId** | **string**| 记账账簿id | [optional] 
 **merchantUserId** | **string**| 商户会员的唯一标识，如果传入account_book_id此字段必传并比对一致性。 | [optional] 
 **sceneCode** | **string**| 资金记账本的开通场景码 | [optional] 
 **extInfo** | **string**| 传递业务扩展参数。 注意：ext_info字段本质上是String类型，所以传递 的是转义后的json字符串。 | [optional] 

### Return type

**AlipayFundAccountbookQueryResponseModel**

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

