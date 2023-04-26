# AlipaySDKNet.OpenAPI.Api.ZhimaCreditPeZmgoAgreementApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](ZhimaCreditPeZmgoAgreementApi.md#query) | **GET** /v3/zhima/credit/pe/zmgo/agreement/query | 芝麻Go协议查询接口
[**Unsign**](ZhimaCreditPeZmgoAgreementApi.md#unsign) | **POST** /v3/zhima/credit/pe/zmgo/agreement/unsign | 芝麻GO协议解约


<a name="query"></a>
# **Query**
> ZhimaCreditPeZmgoAgreementQueryResponseModel Query (string agreementId = null, string alipayUserId = null, string openId = null)

芝麻Go协议查询接口

用户已经开通芝麻GO后，通过此接口查询协议。

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
            var apiInstance = new ZhimaCreditPeZmgoAgreementApi(config);

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

            var agreementId = 20185513447859192007;  // string | 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional) 
            var alipayUserId = 2088101117955611;  // string | 买家在支付宝的用户id (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 买家在支付宝的用户id (optional) 

            try
            {
                // 芝麻Go协议查询接口
                ZhimaCreditPeZmgoAgreementQueryResponseModel result = apiInstance.Query(agreementId, alipayUserId, openId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoAgreementApi.Query: " + e.Message );
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
 **agreementId** | **string**| 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 | [optional] 
 **alipayUserId** | **string**| 买家在支付宝的用户id | [optional] 
 **openId** | **string**| 买家在支付宝的用户id | [optional] 

### Return type

**ZhimaCreditPeZmgoAgreementQueryResponseModel**

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

<a name="unsign"></a>
# **Unsign**
> ZhimaCreditPeZmgoAgreementUnsignResponseModel Unsign (ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = null)

芝麻GO协议解约

芝麻GO协议解约

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
    public class UnsignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaCreditPeZmgoAgreementApi(config);

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

            var zhimaCreditPeZmgoAgreementUnsignModel = new ZhimaCreditPeZmgoAgreementUnsignModel(); // ZhimaCreditPeZmgoAgreementUnsignModel |  (optional) 

            try
            {
                // 芝麻GO协议解约
                ZhimaCreditPeZmgoAgreementUnsignResponseModel result = apiInstance.Unsign(zhimaCreditPeZmgoAgreementUnsignModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCreditPeZmgoAgreementApi.Unsign: " + e.Message );
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
 **zhimaCreditPeZmgoAgreementUnsignModel** | **ZhimaCreditPeZmgoAgreementUnsignModel**|  | [optional] 

### Return type

**ZhimaCreditPeZmgoAgreementUnsignResponseModel**

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

