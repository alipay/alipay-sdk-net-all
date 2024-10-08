# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcEmployeeInviteApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceEcEmployeeInviteApi.md#query) | **GET** /v3/alipay/commerce/ec/employee/invite | 获取员工签约激活链接


<a name="query"></a>
# **Query**
> AlipayCommerceEcEmployeeInviteQueryResponseModel Query (string enterpriseId = null, string employeeId = null, string pageContentCode = null, string withholdingSignStr = null, string createShareCode = null)

获取员工签约激活链接

获取员工签约激活链接

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
            var apiInstance = new AlipayCommerceEcEmployeeInviteApi(config);

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

            var enterpriseId = 2088985758939;  // string | 企业id (optional) 
            var employeeId = 2288099887700000;  // string | 企业码员工ID，签约适用对象为指定员工时填写 (optional) 
            var pageContentCode = PCC_STANDARD;  // string | 用于展示不同的页面文案，使用标准页面文案是无需传值 (optional) 
            var withholdingSignStr = biz_content=%7B%22access_params%22%3A%7B%22personal_product_code%22%3A%22GENERAL_WITHHOLDING_P%22%2C%22sign_scene%22%3A%22INDUSTRY%7CMULTI_MEDIA%22%7D&sign=111&app_id=2017090501336035&method=alipay.user.agreement.page.sign&version=1.0;  // string | 代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。 (optional) 
            var createShareCode = Y;  // string | 是否生成签约吱口令，不传默认为N (optional) 

            try
            {
                // 获取员工签约激活链接
                AlipayCommerceEcEmployeeInviteQueryResponseModel result = apiInstance.Query(enterpriseId, employeeId, pageContentCode, withholdingSignStr, createShareCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEmployeeInviteApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id | [optional] 
 **employeeId** | **string**| 企业码员工ID，签约适用对象为指定员工时填写 | [optional] 
 **pageContentCode** | **string**| 用于展示不同的页面文案，使用标准页面文案是无需传值 | [optional] 
 **withholdingSignStr** | **string**| 代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。 | [optional] 
 **createShareCode** | **string**| 是否生成签约吱口令，不传默认为N | [optional] 

### Return type

**AlipayCommerceEcEmployeeInviteQueryResponseModel**

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

