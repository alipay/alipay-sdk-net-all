# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountListApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayFundJointaccountListApi.md#query) | **GET** /v3/alipay/fund/jointaccount/list/query | 企业查询代付账户列表


<a name="query"></a>
# **Query**
> AlipayFundJointaccountListQueryResponseModel Query (string productCode = null, string bizScene = null, string operateRole = null, string agreementNo = null, string identity = null, string identityType = null)

企业查询代付账户列表

企业查询代付账户列表

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
            var apiInstance = new AlipayFundJointaccountListApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 产品码 (optional) 
            var bizScene = DEFAULT;  // string | 业务场景 (optional) 
            var operateRole = CREATOR;  // string | 角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional) 
            var agreementNo = 208890097674621512231;  // string | 授权协议号 (optional) 
            var identity = name@email.com;  // string | 员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional) 
            var identityType = ALIPAY_LOGON_ID;  // string | 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional) 

            try
            {
                // 企业查询代付账户列表
                AlipayFundJointaccountListQueryResponseModel result = apiInstance.Query(productCode, bizScene, operateRole, agreementNo, identity, identityType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountListApi.Query: " + e.Message );
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
 **productCode** | **string**| 产品码 | [optional] 
 **bizScene** | **string**| 业务场景 | [optional] 
 **operateRole** | **string**| 角色：创建方(CREATOR)、参与方(PARTICIPANT) | [optional] 
 **agreementNo** | **string**| 授权协议号 | [optional] 
 **identity** | **string**| 员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 | [optional] 
 **identityType** | **string**| 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 | [optional] 

### Return type

**AlipayFundJointaccountListQueryResponseModel**

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

