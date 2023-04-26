# AlipaySDKNet.OpenAPI.Api.AlipayEbppPdeductApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Pay**](AlipayEbppPdeductApi.md#pay) | **POST** /v3/alipay/ebpp/pdeduct/pay | 公共事业缴费直连代扣扣款支付接口


<a name="pay"></a>
# **Pay**
> AlipayEbppPdeductPayResponseModel Pay (AlipayEbppPdeductPayModel alipayEbppPdeductPayModel = null)

公共事业缴费直连代扣扣款支付接口

直连代扣机构根据用户个人签约协议，按期按账单请求从用户账户扣款的接口。

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
    public class PayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppPdeductApi(config);

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

            var alipayEbppPdeductPayModel = new AlipayEbppPdeductPayModel(); // AlipayEbppPdeductPayModel |  (optional) 

            try
            {
                // 公共事业缴费直连代扣扣款支付接口
                AlipayEbppPdeductPayResponseModel result = apiInstance.Pay(alipayEbppPdeductPayModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppPdeductApi.Pay: " + e.Message );
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
 **alipayEbppPdeductPayModel** | **AlipayEbppPdeductPayModel**|  | [optional] 

### Return type

**AlipayEbppPdeductPayResponseModel**

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

