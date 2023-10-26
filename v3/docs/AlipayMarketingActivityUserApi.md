# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityUserApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchqueryvoucher**](AlipayMarketingActivityUserApi.md#batchqueryvoucher) | **GET** /v3/alipay/marketing/activity/ordervoucher/user/batchqueryvoucher | 条件查询用户券
[**Queryvoucher**](AlipayMarketingActivityUserApi.md#queryvoucher) | **GET** /v3/alipay/marketing/activity/ordervoucher/user/voucher | 查询用户券详情


<a name="batchqueryvoucher"></a>
# **Batchqueryvoucher**
> AlipayMarketingActivityUserBatchqueryvoucherResponseModel Batchqueryvoucher (string authToken = null, string userId = null, string openId = null, string activityId = null, string belongMerchantId = null, string senderMerchantId = null, string voucherStatus = null, int? pageNum = null, string merchantAccessMode = null, int? pageSize = null)

条件查询用户券

可通过该接口查询用户在某商户可用的全部券，可用于商户的小程序/H5中，用户\"我的优惠券\"或\"提交订单页\"展示优惠信息。只能查询商户配的券，无法查询平台优惠券。

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
    public class BatchqueryvoucherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityUserApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var userId = 2088512417841101;  // string | 支付宝用户 id (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 支付宝用户openId (optional) 
            var activityId = 2016042700826004508401111111;  // string | 活动 id (optional) 
            var belongMerchantId = 2088202967380463;  // string | 券归属商户 (optional) 
            var senderMerchantId = 2088102161342862;  // string | 券发放商户 (optional) 
            var voucherStatus = SENDED;  // string | 券状态，其中已过期状态可查询6个月内的数据 (optional) 
            var pageNum = 1;  // int? | 分页查询页码 (optional) 
            var merchantAccessMode = AGENCY_MODE;  // string | 商户接入模式 (optional) 
            var pageSize = 20;  // int? | 分页查询单页数据条数 (optional) 

            try
            {
                // 条件查询用户券
                AlipayMarketingActivityUserBatchqueryvoucherResponseModel result = apiInstance.Batchqueryvoucher(authToken, userId, openId, activityId, belongMerchantId, senderMerchantId, voucherStatus, pageNum, merchantAccessMode, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityUserApi.Batchqueryvoucher: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **userId** | **string**| 支付宝用户 id | [optional] 
 **openId** | **string**| 支付宝用户openId | [optional] 
 **activityId** | **string**| 活动 id | [optional] 
 **belongMerchantId** | **string**| 券归属商户 | [optional] 
 **senderMerchantId** | **string**| 券发放商户 | [optional] 
 **voucherStatus** | **string**| 券状态，其中已过期状态可查询6个月内的数据 | [optional] 
 **pageNum** | **int?**| 分页查询页码 | [optional] 
 **merchantAccessMode** | **string**| 商户接入模式 | [optional] 
 **pageSize** | **int?**| 分页查询单页数据条数 | [optional] 

### Return type

**AlipayMarketingActivityUserBatchqueryvoucherResponseModel**

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

<a name="queryvoucher"></a>
# **Queryvoucher**
> AlipayMarketingActivityUserQueryvoucherResponseModel Queryvoucher (string merchantId = null, string userId = null, string openId = null, string activityId = null, string voucherId = null, string voucherCode = null, string merchantAccessMode = null)

查询用户券详情

通过此接口可以查询用户券信息，包括用户券的基础信息、状态。

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
    public class QueryvoucherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityUserApi(config);

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

            var merchantId = 2088202967380463;  // string | 商户 PID，默认为当前接口调用商户。 (optional) 
            var userId = 2088512417841101;  // string | 支付宝user_id账号 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 领券的支付宝用户openId (optional) 
            var activityId = 2016042700826004508401111111;  // string | 活动id (optional) 
            var voucherId = 2021072900073002214009F8QHR3;  // string | 用户券 id。支付宝为用户优惠券唯一分配的 id。 (optional) 
            var voucherCode = ABE44;  // string | 用户领取的商家券券码。 (optional) 
            var merchantAccessMode = AGENCY_MODE;  // string | 商户接入模式。 (optional) 

            try
            {
                // 查询用户券详情
                AlipayMarketingActivityUserQueryvoucherResponseModel result = apiInstance.Queryvoucher(merchantId, userId, openId, activityId, voucherId, voucherCode, merchantAccessMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityUserApi.Queryvoucher: " + e.Message );
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
 **merchantId** | **string**| 商户 PID，默认为当前接口调用商户。 | [optional] 
 **userId** | **string**| 支付宝user_id账号 | [optional] 
 **openId** | **string**| 领券的支付宝用户openId | [optional] 
 **activityId** | **string**| 活动id | [optional] 
 **voucherId** | **string**| 用户券 id。支付宝为用户优惠券唯一分配的 id。 | [optional] 
 **voucherCode** | **string**| 用户领取的商家券券码。 | [optional] 
 **merchantAccessMode** | **string**| 商户接入模式。 | [optional] 

### Return type

**AlipayMarketingActivityUserQueryvoucherResponseModel**

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

