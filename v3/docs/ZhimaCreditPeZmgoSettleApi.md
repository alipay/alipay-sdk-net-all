# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPeZmgoSettleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](ZhimaCreditPeZmgoSettleApi.md#apply) | **POST** /v3/zhima/credit/pe/zmgo/settle/apply | 芝麻GO结算申请
[**Refund**](ZhimaCreditPeZmgoSettleApi.md#refund) | **POST** /v3/zhima/credit/pe/zmgo/settle/refund | 芝麻GO结算退款接口
[**Unfreeze**](ZhimaCreditPeZmgoSettleApi.md#unfreeze) | **PUT** /v3/zhima/credit/pe/zmgo/settle/unfreeze | 芝麻GO解冻接口


<a name="apply"></a>
# **Apply**
> ZhimaCreditPeZmgoSettleApplyResponseModel Apply (ZhimaCreditPeZmgoSettleApplyModel zhimaCreditPeZmgoSettleApplyModel = null)

芝麻GO结算申请

用户已经开通芝麻GO后，商户通过此接口解冻转支付用户冻结金额。传入金额必须小于等于冻结金额

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
            var apiInstance = new ZhimaCreditPeZmgoSettleApi(config);

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

            var zhimaCreditPeZmgoSettleApplyModel = new ZhimaCreditPeZmgoSettleApplyModel(); // ZhimaCreditPeZmgoSettleApplyModel |  (optional) 

            try
            {
                // 芝麻GO结算申请
                ZhimaCreditPeZmgoSettleApplyResponseModel result = apiInstance.Apply(zhimaCreditPeZmgoSettleApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoSettleApi.Apply: " + e.Message );
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
 **zhimaCreditPeZmgoSettleApplyModel** | **ZhimaCreditPeZmgoSettleApplyModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoSettleApplyResponseModel**

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
> ZhimaCreditPeZmgoSettleRefundResponseModel Refund (ZhimaCreditPeZmgoSettleRefundModel zhimaCreditPeZmgoSettleRefundModel = null)

芝麻GO结算退款接口

芝麻GO结算金额逆向退款接口: 对zhima.credit.pe.zmgo.settle.apply(芝麻GO结算申请接口) 产生的结算交易发起退款操作

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
            var apiInstance = new ZhimaCreditPeZmgoSettleApi(config);

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

            var zhimaCreditPeZmgoSettleRefundModel = new ZhimaCreditPeZmgoSettleRefundModel(); // ZhimaCreditPeZmgoSettleRefundModel |  (optional) 

            try
            {
                // 芝麻GO结算退款接口
                ZhimaCreditPeZmgoSettleRefundResponseModel result = apiInstance.Refund(zhimaCreditPeZmgoSettleRefundModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoSettleApi.Refund: " + e.Message );
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
 **zhimaCreditPeZmgoSettleRefundModel** | **ZhimaCreditPeZmgoSettleRefundModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoSettleRefundResponseModel**

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
> ZhimaCreditPeZmgoSettleUnfreezeResponseModel Unfreeze (ZhimaCreditPeZmgoSettleUnfreezeModel zhimaCreditPeZmgoSettleUnfreezeModel = null)

芝麻GO解冻接口

用户已经开通芝麻GO后，商户通过此接口解冻转支付用户冻结金额。传入金额必须小于等于冻结金额

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
            var apiInstance = new ZhimaCreditPeZmgoSettleApi(config);

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

            var zhimaCreditPeZmgoSettleUnfreezeModel = new ZhimaCreditPeZmgoSettleUnfreezeModel(); // ZhimaCreditPeZmgoSettleUnfreezeModel |  (optional) 

            try
            {
                // 芝麻GO解冻接口
                ZhimaCreditPeZmgoSettleUnfreezeResponseModel result = apiInstance.Unfreeze(zhimaCreditPeZmgoSettleUnfreezeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoSettleApi.Unfreeze: " + e.Message );
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
 **zhimaCreditPeZmgoSettleUnfreezeModel** | **ZhimaCreditPeZmgoSettleUnfreezeModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoSettleUnfreezeResponseModel**

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

