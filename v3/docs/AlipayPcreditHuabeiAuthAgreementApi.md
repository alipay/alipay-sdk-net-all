# AlipaySDKNet.OpenAPI.Api.AlipayPcreditHuabeiAuthAgreementApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Close**](AlipayPcreditHuabeiAuthAgreementApi.md#close) | **PUT** /v3/alipay/pcredit/huabei/auth/agreement/close | 花芝协议关闭接口
[**Query**](AlipayPcreditHuabeiAuthAgreementApi.md#query) | **GET** /v3/alipay/pcredit/huabei/auth/agreement/query | 花芝轻会员协议查询接口


<a name="close"></a>
# **Close**
> AlipayPcreditHuabeiAuthAgreementCloseResponseModel Close (AlipayPcreditHuabeiAuthAgreementCloseModel alipayPcreditHuabeiAuthAgreementCloseModel = null)

花芝协议关闭接口

用户已经开通花芝先享后，商户可通过此接口提前关闭协议。

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
    public class CloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayPcreditHuabeiAuthAgreementApi(config);

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

            var alipayPcreditHuabeiAuthAgreementCloseModel = new AlipayPcreditHuabeiAuthAgreementCloseModel(); // AlipayPcreditHuabeiAuthAgreementCloseModel |  (optional) 

            try
            {
                // 花芝协议关闭接口
                AlipayPcreditHuabeiAuthAgreementCloseResponseModel result = apiInstance.Close(alipayPcreditHuabeiAuthAgreementCloseModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthAgreementApi.Close: " + e.Message );
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
 **alipayPcreditHuabeiAuthAgreementCloseModel** | **AlipayPcreditHuabeiAuthAgreementCloseModel**|  | [optional] 

### Return type

**AlipayPcreditHuabeiAuthAgreementCloseResponseModel**

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
> AlipayPcreditHuabeiAuthAgreementQueryResponseModel Query (string agreementNo = null, string alipayUserId = null, string openId = null, string outSignNo = null, string authScene = null)

花芝轻会员协议查询接口

花芝轻会员协议查询，返回协议的状态。如果协议处于签约状态，同时返回最新的资金池余额。 有两种方式查询。优先使用agreement_no查询；其次是使用(out_sign_no, auth_scene)查询。 如果商户不能保证out_sign_no的唯一性，慎用(out_sign_no, auth_scene)的查询方式，它优先返回仍处于签约状态的协议。

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
            var apiInstance = new AlipayPcreditHuabeiAuthAgreementApi(config);

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

            var agreementNo = 20185513447859192007;  // string | 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional) 
            var alipayUserId = 2088101117955611;  // string | 买家在支付宝的用户id (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 买家在支付宝的用户id (optional) 
            var outSignNo = 2018053100073208416400000002;  // string | 外部签约号，由商户提供，花芝轻会员协议中标识用户的唯一签约号（确保在商户系统中唯一）。 (optional) 
            var authScene = EXTERNAL_PCARD;  // string | 花芝轻会员签约场景，商户和支付宝签约时确定。该值需要与系统/页面签约接口调用时传入的值保持一致。 (optional) 

            try
            {
                // 花芝轻会员协议查询接口
                AlipayPcreditHuabeiAuthAgreementQueryResponseModel result = apiInstance.Query(agreementNo, alipayUserId, openId, outSignNo, authScene);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayPcreditHuabeiAuthAgreementApi.Query: " + e.Message );
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
 **agreementNo** | **string**| 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 | [optional] 
 **alipayUserId** | **string**| 买家在支付宝的用户id | [optional] 
 **openId** | **string**| 买家在支付宝的用户id | [optional] 
 **outSignNo** | **string**| 外部签约号，由商户提供，花芝轻会员协议中标识用户的唯一签约号（确保在商户系统中唯一）。 | [optional] 
 **authScene** | **string**| 花芝轻会员签约场景，商户和支付宝签约时确定。该值需要与系统/页面签约接口调用时传入的值保持一致。 | [optional] 

### Return type

**AlipayPcreditHuabeiAuthAgreementQueryResponseModel**

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

