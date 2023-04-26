# AlipaySDKNet.OpenAPI.Api.AlipayPcreditHuabeiAuthRefundApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayPcreditHuabeiAuthRefundApi.md#apply) | **PUT** /v3/alipay/pcredit/huabei/auth/refund/apply | 花芝结算扣款费用逆向退款申请


<a name="apply"></a>
# **Apply**
> AlipayPcreditHuabeiAuthRefundApplyResponseModel Apply (AlipayPcreditHuabeiAuthRefundApplyModel alipayPcreditHuabeiAuthRefundApplyModel = null)

花芝结算扣款费用逆向退款申请

用于1)芝麻GO会员费扣款逆向退款操作2）周期扣款每期扣款逆向退款操作

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
    public class ApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayPcreditHuabeiAuthRefundApi(config);

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

            var alipayPcreditHuabeiAuthRefundApplyModel = new AlipayPcreditHuabeiAuthRefundApplyModel(); // AlipayPcreditHuabeiAuthRefundApplyModel |  (optional) 

            try
            {
                // 花芝结算扣款费用逆向退款申请
                AlipayPcreditHuabeiAuthRefundApplyResponseModel result = apiInstance.Apply(alipayPcreditHuabeiAuthRefundApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthRefundApi.Apply: " + e.Message );
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
 **alipayPcreditHuabeiAuthRefundApplyModel** | **AlipayPcreditHuabeiAuthRefundApplyModel**|  | [optional] 

### Return type

**AlipayPcreditHuabeiAuthRefundApplyResponseModel**

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

