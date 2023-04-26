# AlipaySDKNet.OpenAPI.Api.AlipayOpenInviteOrderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenInviteOrderApi.md#query) | **GET** /v3/alipay/open/invite/order/query | 查询签约申请单状态


<a name="query"></a>
# **Query**
> AlipayOpenInviteOrderQueryResponseModel Query (string isvBizId = null, string alipayLogonId = null)

查询签约申请单状态

创建签约授权流程后，查询对应产品签约申请单的状态

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
            var apiInstance = new AlipayOpenInviteOrderApi(config);

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

            var isvBizId = 2017110616474516400082883;  // string | isv业务系统单据编号 (optional) 
            var alipayLogonId = fykevbdz6766@alitest.com;  // string | 商家的支付宝账号，如果调用alipay.open.invite.order.create接口时有传入支付宝账号，则这里查询签约状态时必须要传 (optional) 

            try
            {
                // 查询签约申请单状态
                AlipayOpenInviteOrderQueryResponseModel result = apiInstance.Query(isvBizId, alipayLogonId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenInviteOrderApi.Query: " + e.Message );
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
 **isvBizId** | **string**| isv业务系统单据编号 | [optional] 
 **alipayLogonId** | **string**| 商家的支付宝账号，如果调用alipay.open.invite.order.create接口时有传入支付宝账号，则这里查询签约状态时必须要传 | [optional] 

### Return type

**AlipayOpenInviteOrderQueryResponseModel**

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

