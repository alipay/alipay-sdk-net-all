# AlipaySDKNet.OpenAPI.Api.AlipayTradeCustomsApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Declare**](AlipayTradeCustomsApi.md#declare) | **POST** /v3/alipay/trade/customs/declare | 统一收单报关接口
[**Query**](AlipayTradeCustomsApi.md#query) | **GET** /v3/alipay/trade/customs/query | 查询报关详细信息


<a name="declare"></a>
# **Declare**
> AlipayTradeCustomsDeclareResponseModel Declare (AlipayTradeCustomsDeclareModel alipayTradeCustomsDeclareModel = null)

统一收单报关接口

境外商户的商品进口到国内时需要向海关中心报送支付、物流等信息，由海关审核，如果交易是由支付宝支付的话，需要商户可以调用此报关接口来请求支付宝将其指定交易报送支付单给海关。

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
    public class DeclareExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayTradeCustomsApi(config);

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

            var alipayTradeCustomsDeclareModel = new AlipayTradeCustomsDeclareModel(); // AlipayTradeCustomsDeclareModel |  (optional) 

            try
            {
                // 统一收单报关接口
                AlipayTradeCustomsDeclareResponseModel result = apiInstance.Declare(alipayTradeCustomsDeclareModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeCustomsApi.Declare: " + e.Message );
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
 **alipayTradeCustomsDeclareModel** | **AlipayTradeCustomsDeclareModel**|  | [optional] 

### Return type

**AlipayTradeCustomsDeclareResponseModel**

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
> AlipayTradeCustomsQueryResponseModel Query (string outRequestNos = null)

查询报关详细信息

境外商户的商品进口到国内时需要向海关中心报送支付、物流等信息，由海关审核，如果交易是由支付宝支付的话，需要商户调用支付宝报关接口来请求支付宝将其指定交易报送支付单给海关。商户可以通过该接口主动查询报关状态，了解报关详情以及进度。

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
            var apiInstance = new AlipayTradeCustomsApi(config);

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

            var outRequestNos = 201506010001,201506010002,201506010003;  // string | 报关请求号。需要查询的商户端报关请求号，支持批量查询，  多个值用英文半角逗号分隔，单次请求最多10个; (optional) 

            try
            {
                // 查询报关详细信息
                AlipayTradeCustomsQueryResponseModel result = apiInstance.Query(outRequestNos);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeCustomsApi.Query: " + e.Message );
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
 **outRequestNos** | **string**| 报关请求号。需要查询的商户端报关请求号，支持批量查询，  多个值用英文半角逗号分隔，单次请求最多10个; | [optional] 

### Return type

**AlipayTradeCustomsQueryResponseModel**

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

