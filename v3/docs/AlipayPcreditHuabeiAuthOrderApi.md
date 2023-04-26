# AlipaySDKNet.OpenAPI.Api.AlipayPcreditHuabeiAuthOrderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayPcreditHuabeiAuthOrderApi.md#query) | **GET** /v3/alipay/pcredit/huabei/auth/order/query | 花呗先享订单查询接口
[**Unfreeze**](AlipayPcreditHuabeiAuthOrderApi.md#unfreeze) | **PUT** /v3/alipay/pcredit/huabei/auth/order/unfreeze | 花呗先享解冻或解约接口


<a name="query"></a>
# **Query**
> AlipayPcreditHuabeiAuthOrderQueryResponseModel Query (string authOptId = null, string alipayUserId = null, string openId = null, string outRequestNo = null)

花呗先享订单查询接口

查询花呗先享冻结、解冻订单内容及状态。有3种查询方式。推荐商户优先使用auth_opt_id查询；其次是按照(alipay_user_id,out_request_no)组合方式查询；最后是单独通过out_request_no方式查询。  注意：最后一种方式，仅支持2019年2月15日开始的订单。

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
            var apiInstance = new AlipayPcreditHuabeiAuthOrderApi(config);

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

            var authOptId = 2018081010020817070009689955;  // string | 支付宝侧花呗冻结、解冻操作单据id。在原先的冻结或者解冻接口调用中同步返回给商户，或者通过商户通知返回给商户。按订单号查询时，此字段不可为空。 (optional) 
            var alipayUserId = 2088101117955611;  // string | 买家在支付宝的用户id。通过userid+请求流水号组合查询时，此字段不可为空。 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 买家在支付宝的用户id (optional) 
            var outRequestNo = 8077735255938032;  // string | 商户原先调用冻结、解冻接口传入的请求流水号。按照流水号查询订单时，此字段不能为空。 (optional) 

            try
            {
                // 花呗先享订单查询接口
                AlipayPcreditHuabeiAuthOrderQueryResponseModel result = apiInstance.Query(authOptId, alipayUserId, openId, outRequestNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthOrderApi.Query: " + e.Message );
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
 **authOptId** | **string**| 支付宝侧花呗冻结、解冻操作单据id。在原先的冻结或者解冻接口调用中同步返回给商户，或者通过商户通知返回给商户。按订单号查询时，此字段不可为空。 | [optional] 
 **alipayUserId** | **string**| 买家在支付宝的用户id。通过userid+请求流水号组合查询时，此字段不可为空。 | [optional] 
 **openId** | **string**| 买家在支付宝的用户id | [optional] 
 **outRequestNo** | **string**| 商户原先调用冻结、解冻接口传入的请求流水号。按照流水号查询订单时，此字段不能为空。 | [optional] 

### Return type

**AlipayPcreditHuabeiAuthOrderQueryResponseModel**

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

<a name="unfreeze"></a>
# **Unfreeze**
> AlipayPcreditHuabeiAuthOrderUnfreezeResponseModel Unfreeze (AlipayPcreditHuabeiAuthOrderUnfreezeModel alipayPcreditHuabeiAuthOrderUnfreezeModel = null)

花呗先享解冻或解约接口

用户已经开通花呗先享协议后，商户通过此接口解冻用户资金池金额，也可以解冻并解约。  如果是解约操作，则要求传入的解冻金额必须等于用户资金池余额。  注意：商户在发起解约前，请务必保证已经结算过用户会员费，一旦解约后，无法发起结算用户会员费操作。

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
            var apiInstance = new AlipayPcreditHuabeiAuthOrderApi(config);

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

            var alipayPcreditHuabeiAuthOrderUnfreezeModel = new AlipayPcreditHuabeiAuthOrderUnfreezeModel(); // AlipayPcreditHuabeiAuthOrderUnfreezeModel |  (optional) 

            try
            {
                // 花呗先享解冻或解约接口
                AlipayPcreditHuabeiAuthOrderUnfreezeResponseModel result = apiInstance.Unfreeze(alipayPcreditHuabeiAuthOrderUnfreezeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthOrderApi.Unfreeze: " + e.Message );
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
 **alipayPcreditHuabeiAuthOrderUnfreezeModel** | **AlipayPcreditHuabeiAuthOrderUnfreezeModel**|  | [optional] 

### Return type

**AlipayPcreditHuabeiAuthOrderUnfreezeResponseModel**

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

