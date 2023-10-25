# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPayafteruseCreditbizorderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Finish**](ZhimaCreditPayafteruseCreditbizorderApi.md#finish) | **POST** /v3/zhima/credit/payafteruse/creditbizorder/finish | 结束信用服务订单
[**Order**](ZhimaCreditPayafteruseCreditbizorderApi.md#order) | **POST** /v3/zhima/credit/payafteruse/creditbizorder/order | 芝麻信用服务下单（免用户确认场景）
[**Query**](ZhimaCreditPayafteruseCreditbizorderApi.md#query) | **GET** /v3/zhima/credit/payafteruse/creditbizorder/query | 信用服务订单查询


<a name="finish"></a>
# **Finish**
> ZhimaCreditPayafteruseCreditbizorderFinishResponseModel Finish (ZhimaCreditPayafteruseCreditbizorderFinishModel zhimaCreditPayafteruseCreditbizorderFinishModel = null)

结束信用服务订单

结束信用服务订单

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
    public class FinishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaCreditPayafteruseCreditbizorderApi(config);

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

            var zhimaCreditPayafteruseCreditbizorderFinishModel = new ZhimaCreditPayafteruseCreditbizorderFinishModel(); // ZhimaCreditPayafteruseCreditbizorderFinishModel |  (optional) 

            try
            {
                // 结束信用服务订单
                ZhimaCreditPayafteruseCreditbizorderFinishResponseModel result = apiInstance.Finish(zhimaCreditPayafteruseCreditbizorderFinishModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPayafteruseCreditbizorderApi.Finish: " + e.Message );
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
 **zhimaCreditPayafteruseCreditbizorderFinishModel** | **ZhimaCreditPayafteruseCreditbizorderFinishModel**|  | [optional] 

### Return type

**ZhimaCreditPayafteruseCreditbizorderFinishResponseModel**

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

<a name="order"></a>
# **Order**
> ZhimaCreditPayafteruseCreditbizorderOrderResponseModel Order (ZhimaCreditPayafteruseCreditbizorderOrderModel zhimaCreditPayafteruseCreditbizorderOrderModel = null)

芝麻信用服务下单（免用户确认场景）

芝麻信用产品免密下单，不需要唤起支付宝APP，通过服务端调用完成下单。 涉及芝麻信用服务产品、芝麻风险评估产品

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
    public class OrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaCreditPayafteruseCreditbizorderApi(config);

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

            var zhimaCreditPayafteruseCreditbizorderOrderModel = new ZhimaCreditPayafteruseCreditbizorderOrderModel(); // ZhimaCreditPayafteruseCreditbizorderOrderModel |  (optional) 

            try
            {
                // 芝麻信用服务下单（免用户确认场景）
                ZhimaCreditPayafteruseCreditbizorderOrderResponseModel result = apiInstance.Order(zhimaCreditPayafteruseCreditbizorderOrderModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPayafteruseCreditbizorderApi.Order: " + e.Message );
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
 **zhimaCreditPayafteruseCreditbizorderOrderModel** | **ZhimaCreditPayafteruseCreditbizorderOrderModel**|  | [optional] 

### Return type

**ZhimaCreditPayafteruseCreditbizorderOrderResponseModel**

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
> ZhimaCreditPayafteruseCreditbizorderQueryResponseModel Query (string creditBizOrderId = null, string outOrderNo = null)

信用服务订单查询

信用服务订单查询

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
            var apiInstance = new ZhimaCreditPayafteruseCreditbizorderApi(config);

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

            var creditBizOrderId = ZMCB20201021200102012;  // string | 信用服务订单号，out_order_no与credit_biz_order_id至少传一个 (optional) 
            var outOrderNo = 20202010212001384;  // string | 商户外部单号，out_order_no与credit_biz_order_id至少传一个 (optional) 

            try
            {
                // 信用服务订单查询
                ZhimaCreditPayafteruseCreditbizorderQueryResponseModel result = apiInstance.Query(creditBizOrderId, outOrderNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPayafteruseCreditbizorderApi.Query: " + e.Message );
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
 **creditBizOrderId** | **string**| 信用服务订单号，out_order_no与credit_biz_order_id至少传一个 | [optional] 
 **outOrderNo** | **string**| 商户外部单号，out_order_no与credit_biz_order_id至少传一个 | [optional] 

### Return type

**ZhimaCreditPayafteruseCreditbizorderQueryResponseModel**

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

