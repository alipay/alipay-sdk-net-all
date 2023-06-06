# AlipaySDKNet.OpenAPI.Api.AlipayTradeSettleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Confirm**](AlipayTradeSettleApi.md#confirm) | **POST** /v3/alipay/trade/settle/confirm | 统一收单确认结算接口


<a name="confirm"></a>
# **Confirm**
> AlipayTradeSettleConfirmResponseModel Confirm (AlipayTradeSettleConfirmModel alipayTradeSettleConfirmModel = null)

统一收单确认结算接口

用户付款后，平台上的卖家发货，用户收到商品确认收货后，平台通过确认结算接口，将交易款结算给指定的卖家账户。 单笔结算到卖家余额的场景支持分账冻结。在确认结算时，传入冻结标识 royalty_freeze=true，资金结算到卖家支付宝余额后，会先冻结在不可用余额中，后续分账将自动从冻结余额划出，平台商可调用分账完结释放冻结资金，系统默认在冻结30天后自动解冻。解冻后，仍可以发起分账。为保证分账成功率，请尽可能在分账冻结期内分账。

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
    public class ConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayTradeSettleApi(config);

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

            var alipayTradeSettleConfirmModel = new AlipayTradeSettleConfirmModel(); // AlipayTradeSettleConfirmModel |  (optional) 

            try
            {
                // 统一收单确认结算接口
                AlipayTradeSettleConfirmResponseModel result = apiInstance.Confirm(alipayTradeSettleConfirmModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeSettleApi.Confirm: " + e.Message );
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
 **alipayTradeSettleConfirmModel** | **AlipayTradeSettleConfirmModel**|  | [optional] 

### Return type

**AlipayTradeSettleConfirmResponseModel**

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

