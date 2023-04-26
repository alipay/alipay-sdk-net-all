# AlipaySDKNet.OpenAPI.Api.AlipayCommerceLogisticsInvoiceIstdwaybillApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayCommerceLogisticsInvoiceIstdwaybillApi.md#create) | **POST** /v3/alipay/commerce/logistics/invoice/istdwaybill/create | 开即时配送订单发票
[**Query**](AlipayCommerceLogisticsInvoiceIstdwaybillApi.md#query) | **GET** /v3/alipay/commerce/logistics/invoice/istdwaybill/query | 查询即时配送订单的开票结果


<a name="create"></a>
# **Create**
> AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel Create (AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = null)

开即时配送订单发票

开即时配送订单发票

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
            var apiInstance = new AlipayCommerceLogisticsInvoiceIstdwaybillApi(config);

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

            var alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = new AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel(); // AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel |  (optional) 

            try
            {
                // 开即时配送订单发票
                AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel result = apiInstance.Create(alipayCommerceLogisticsInvoiceIstdwaybillCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsInvoiceIstdwaybillApi.Create: " + e.Message );
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
 **alipayCommerceLogisticsInvoiceIstdwaybillCreateModel** | **AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel**|  | [optional] 

### Return type

**AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel**

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
> AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel Query (string logisticsCode = null, string outInvoiceRequestNo = null)

查询即时配送订单的开票结果

查询即时配送订单的开票结果

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
            var apiInstance = new AlipayCommerceLogisticsInvoiceIstdwaybillApi(config);

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

            var logisticsCode = FENGNIAO;  // string | 即时配送公司编码 (optional) 
            var outInvoiceRequestNo = out_invoice_no_00001;  // string | 开票请求流水号 (optional) 

            try
            {
                // 查询即时配送订单的开票结果
                AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel result = apiInstance.Query(logisticsCode, outInvoiceRequestNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceLogisticsInvoiceIstdwaybillApi.Query: " + e.Message );
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
 **logisticsCode** | **string**| 即时配送公司编码 | [optional] 
 **outInvoiceRequestNo** | **string**| 开票请求流水号 | [optional] 

### Return type

**AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel**

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

