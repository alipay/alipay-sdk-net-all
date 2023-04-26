# AlipaySDKNet.OpenAPI.Api.AlipayCommerceCityfacilitatorVoucherApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayCommerceCityfacilitatorVoucherApi.md#batchquery) | **POST** /v3/alipay/commerce/cityfacilitator/voucher/batchquery | 地铁购票订单批量查询
[**Generate**](AlipayCommerceCityfacilitatorVoucherApi.md#generate) | **POST** /v3/alipay/commerce/cityfacilitator/voucher/generate | 地铁购票核销码发码
[**Refund**](AlipayCommerceCityfacilitatorVoucherApi.md#refund) | **POST** /v3/alipay/commerce/cityfacilitator/voucher/refund | 地铁购票发码退款


<a name="batchquery"></a>
# **Batchquery**
> AlipayCommerceCityfacilitatorVoucherBatchqueryResponseModel Batchquery (AlipayCommerceCityfacilitatorVoucherBatchqueryModel alipayCommerceCityfacilitatorVoucherBatchqueryModel = null)

地铁购票订单批量查询

商户APP调该接口批量查询订单状态

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
            var apiInstance = new AlipayCommerceCityfacilitatorVoucherApi(config);

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

            var alipayCommerceCityfacilitatorVoucherBatchqueryModel = new AlipayCommerceCityfacilitatorVoucherBatchqueryModel(); // AlipayCommerceCityfacilitatorVoucherBatchqueryModel |  (optional) 

            try
            {
                // 地铁购票订单批量查询
                AlipayCommerceCityfacilitatorVoucherBatchqueryResponseModel result = apiInstance.Batchquery(alipayCommerceCityfacilitatorVoucherBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceCityfacilitatorVoucherApi.Batchquery: " + e.Message );
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
 **alipayCommerceCityfacilitatorVoucherBatchqueryModel** | **AlipayCommerceCityfacilitatorVoucherBatchqueryModel**|  | [optional] 

### Return type

**AlipayCommerceCityfacilitatorVoucherBatchqueryResponseModel**

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

<a name="generate"></a>
# **Generate**
> AlipayCommerceCityfacilitatorVoucherGenerateResponseModel Generate (AlipayCommerceCityfacilitatorVoucherGenerateModel alipayCommerceCityfacilitatorVoucherGenerateModel = null)

地铁购票核销码发码

商户APP调快捷支付付款后，获取地铁购票的核销码

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
    public class GenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceCityfacilitatorVoucherApi(config);

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

            var alipayCommerceCityfacilitatorVoucherGenerateModel = new AlipayCommerceCityfacilitatorVoucherGenerateModel(); // AlipayCommerceCityfacilitatorVoucherGenerateModel |  (optional) 

            try
            {
                // 地铁购票核销码发码
                AlipayCommerceCityfacilitatorVoucherGenerateResponseModel result = apiInstance.Generate(alipayCommerceCityfacilitatorVoucherGenerateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceCityfacilitatorVoucherApi.Generate: " + e.Message );
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
 **alipayCommerceCityfacilitatorVoucherGenerateModel** | **AlipayCommerceCityfacilitatorVoucherGenerateModel**|  | [optional] 

### Return type

**AlipayCommerceCityfacilitatorVoucherGenerateResponseModel**

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

<a name="refund"></a>
# **Refund**
> Object Refund (AlipayCommerceCityfacilitatorVoucherRefundModel alipayCommerceCityfacilitatorVoucherRefundModel = null)

地铁购票发码退款

地铁购票，商户发码后，调该接口从中间户退款

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
            var apiInstance = new AlipayCommerceCityfacilitatorVoucherApi(config);

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

            var alipayCommerceCityfacilitatorVoucherRefundModel = new AlipayCommerceCityfacilitatorVoucherRefundModel(); // AlipayCommerceCityfacilitatorVoucherRefundModel |  (optional) 

            try
            {
                // 地铁购票发码退款
                Object result = apiInstance.Refund(alipayCommerceCityfacilitatorVoucherRefundModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceCityfacilitatorVoucherApi.Refund: " + e.Message );
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
 **alipayCommerceCityfacilitatorVoucherRefundModel** | **AlipayCommerceCityfacilitatorVoucherRefundModel**|  | [optional] 

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

