# AlipaySDKNet.OpenAPI.Api.AlipayUserCertdocCertverifyApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Consult**](AlipayUserCertdocCertverifyApi.md#consult) | **GET** /v3/alipay/user/certdoc/certverify/consult | 实名证件信息比对验证咨询
[**Preconsult**](AlipayUserCertdocCertverifyApi.md#preconsult) | **POST** /v3/alipay/user/certdoc/certverify/preconsult | 实名证件信息比对验证预咨询


<a name="consult"></a>
# **Consult**
> AlipayUserCertdocCertverifyConsultResponseModel Consult (string authToken = null, string verifyId = null)

实名证件信息比对验证咨询

商户在预咨询接口（接口1）预先录入某用户的实名证件信息（例如姓名、身份证号等），获得用户授权后调用本咨询接口（接口2），将对比该用户的支付宝实名信息与（接口1）传入的信息是否一致。

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
    public class ConsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayUserCertdocCertverifyApi(config);

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
            var verifyId = 671ffcda5447bc87e9ed2f669eb143d4;  // string | 信息校验验证ID。通过<a href=\"https://opendocs.alipay.com/apis/api_2/alipay.user.certdoc.certverify.preconsult\">alipay.user.certdoc.certverify.preconsult</a>(实名证件信息比对验证预咨询)接口获取。 (optional) 

            try
            {
                // 实名证件信息比对验证咨询
                AlipayUserCertdocCertverifyConsultResponseModel result = apiInstance.Consult(authToken, verifyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserCertdocCertverifyApi.Consult: " + e.Message );
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
 **verifyId** | **string**| 信息校验验证ID。通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_2/alipay.user.certdoc.certverify.preconsult\&quot;&gt;alipay.user.certdoc.certverify.preconsult&lt;/a&gt;(实名证件信息比对验证预咨询)接口获取。 | [optional] 

### Return type

**AlipayUserCertdocCertverifyConsultResponseModel**

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

<a name="preconsult"></a>
# **Preconsult**
> AlipayUserCertdocCertverifyPreconsultResponseModel Preconsult (AlipayUserCertdocCertverifyPreconsultModel alipayUserCertdocCertverifyPreconsultModel = null)

实名证件信息比对验证预咨询

商户在该接口（接口1）预先录入某用户的实名证件信息（例如姓名、身份证号等），获得用户授权后调用咨询接口（接口2），将对比该用户的支付宝实名信息与该（接口1）传入的信息是否一致。

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
    public class PreconsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayUserCertdocCertverifyApi(config);

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

            var alipayUserCertdocCertverifyPreconsultModel = new AlipayUserCertdocCertverifyPreconsultModel(); // AlipayUserCertdocCertverifyPreconsultModel |  (optional) 

            try
            {
                // 实名证件信息比对验证预咨询
                AlipayUserCertdocCertverifyPreconsultResponseModel result = apiInstance.Preconsult(alipayUserCertdocCertverifyPreconsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayUserCertdocCertverifyApi.Preconsult: " + e.Message );
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
 **alipayUserCertdocCertverifyPreconsultModel** | **AlipayUserCertdocCertverifyPreconsultModel**|  | [optional] 

### Return type

**AlipayUserCertdocCertverifyPreconsultResponseModel**

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

