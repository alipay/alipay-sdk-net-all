# AlipaySDKNet.OpenAPI.Api.AlipayFundAuthOrderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Freeze**](AlipayFundAuthOrderApi.md#freeze) | **POST** /v3/alipay/fund/auth/order/freeze | 资金授权冻结接口
[**Unfreeze**](AlipayFundAuthOrderApi.md#unfreeze) | **POST** /v3/alipay/fund/auth/order/unfreeze | 资金授权解冻接口


<a name="freeze"></a>
# **Freeze**
> AlipayFundAuthOrderFreezeResponseModel Freeze (AlipayFundAuthOrderFreezeModel alipayFundAuthOrderFreezeModel = null)

资金授权冻结接口

收银员使用扫码设备读取用户支付宝钱包“付款码”后，将条码信息和订单信息通过本接口上送至支付宝发起资金冻结。

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
    public class FreezeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundAuthOrderApi(config);

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

            var alipayFundAuthOrderFreezeModel = new AlipayFundAuthOrderFreezeModel(); // AlipayFundAuthOrderFreezeModel |  (optional) 

            try
            {
                // 资金授权冻结接口
                AlipayFundAuthOrderFreezeResponseModel result = apiInstance.Freeze(alipayFundAuthOrderFreezeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAuthOrderApi.Freeze: " + e.Message );
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
 **alipayFundAuthOrderFreezeModel** | **AlipayFundAuthOrderFreezeModel**|  | [optional] 

### Return type

**AlipayFundAuthOrderFreezeResponseModel**

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

<a name="unfreeze"></a>
# **Unfreeze**
> AlipayFundAuthOrderUnfreezeResponseModel Unfreeze (AlipayFundAuthOrderUnfreezeModel alipayFundAuthOrderUnfreezeModel = null)

资金授权解冻接口

当资金授权发生之后一段时间内，由于买家或者商家等其他原因需要要解冻资金，商家可通过资金授权解冻接口将授权资金进行解冻，支付宝将在收到解冻请求并验证成功后，按解冻规则将冻结资金按原路进行解冻

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
    public class UnfreezeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundAuthOrderApi(config);

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

            var alipayFundAuthOrderUnfreezeModel = new AlipayFundAuthOrderUnfreezeModel(); // AlipayFundAuthOrderUnfreezeModel |  (optional) 

            try
            {
                // 资金授权解冻接口
                AlipayFundAuthOrderUnfreezeResponseModel result = apiInstance.Unfreeze(alipayFundAuthOrderUnfreezeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundAuthOrderApi.Unfreeze: " + e.Message );
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
 **alipayFundAuthOrderUnfreezeModel** | **AlipayFundAuthOrderUnfreezeModel**|  | [optional] 

### Return type

**AlipayFundAuthOrderUnfreezeResponseModel**

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

