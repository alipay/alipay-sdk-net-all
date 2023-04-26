# AlipaySDKNet.OpenAPI.Api.AlipayPcreditHuabeiAuthSettleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayPcreditHuabeiAuthSettleApi.md#apply) | **PUT** /v3/alipay/pcredit/huabei/auth/settle/apply | 花芝轻会员结算申请


<a name="apply"></a>
# **Apply**
> AlipayPcreditHuabeiAuthSettleApplyResponseModel Apply (AlipayPcreditHuabeiAuthSettleApplyModel alipayPcreditHuabeiAuthSettleApplyModel = null)

花芝轻会员结算申请

用户已经开通花芝轻会员协议后，商户通过此接口解冻转支付用户冻结金额。传入金额必须小于等于冻结金额

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
            var apiInstance = new AlipayPcreditHuabeiAuthSettleApi(config);

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

            var alipayPcreditHuabeiAuthSettleApplyModel = new AlipayPcreditHuabeiAuthSettleApplyModel(); // AlipayPcreditHuabeiAuthSettleApplyModel |  (optional) 

            try
            {
                // 花芝轻会员结算申请
                AlipayPcreditHuabeiAuthSettleApplyResponseModel result = apiInstance.Apply(alipayPcreditHuabeiAuthSettleApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthSettleApi.Apply: " + e.Message );
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
 **alipayPcreditHuabeiAuthSettleApplyModel** | **AlipayPcreditHuabeiAuthSettleApplyModel**|  | [optional] 

### Return type

**AlipayPcreditHuabeiAuthSettleApplyResponseModel**

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

