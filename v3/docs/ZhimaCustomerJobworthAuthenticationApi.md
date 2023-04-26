# AlipaySDKNet.OpenAPI.Api.ZhimaCustomerJobworthAuthenticationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](ZhimaCustomerJobworthAuthenticationApi.md#query) | **GET** /v3/zhima/customer/jobworth/authentication | 职得身份认证查询接口


<a name="query"></a>
# **Query**
> ZhimaCustomerJobworthAuthenticationQueryResponseModel Query (string connKey = null, string onceToken = null, string queryType = null, string identityType = null, string serviceId = null, string userId = null, string openId = null, string certNo = null, string certType = null)

职得身份认证查询接口

根据一次性token查询用户身份认证结果

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
            var apiInstance = new ZhimaCustomerJobworthAuthenticationApi(config);

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

            var connKey = uuid;  // string | 调用第一步创建接口的out_agreement_no，由外部传入 (optional) 
            var onceToken = uuid;  // string | 查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台 (optional) 
            var queryType = exact\dim;  // string | exact:精确查询,dim:模糊查询 (optional) 
            var identityType = 01，02，03;  // string | 01:医生，02:教师，具体参考文档 (optional) 
            var serviceId = 2019120400000000000004450100;  // string | 信用服务id，商家接入产品功能包时有运营同学分配 (optional) 
            var userId = 20881029102921;  // string | 蚂蚁统一会员ID 和身份证任选一个传入 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 蚂蚁统一会员ID 和身份证任选一个传入 (optional) 
            var certNo = 420192931233123123;  // string | 证件号 (optional) 
            var certType = 0;  // string | \"身份证 : 0\"，\"护照: 1\"，\"台湾往来通行证：4\",\"港澳往来通行证：3\", \"回乡证: 2\"；\"港澳证件：5\" (optional) 

            try
            {
                // 职得身份认证查询接口
                ZhimaCustomerJobworthAuthenticationQueryResponseModel result = apiInstance.Query(connKey, onceToken, queryType, identityType, serviceId, userId, openId, certNo, certType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaCustomerJobworthAuthenticationApi.Query: " + e.Message );
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
 **connKey** | **string**| 调用第一步创建接口的out_agreement_no，由外部传入 | [optional] 
 **onceToken** | **string**| 查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台 | [optional] 
 **queryType** | **string**| exact:精确查询,dim:模糊查询 | [optional] 
 **identityType** | **string**| 01:医生，02:教师，具体参考文档 | [optional] 
 **serviceId** | **string**| 信用服务id，商家接入产品功能包时有运营同学分配 | [optional] 
 **userId** | **string**| 蚂蚁统一会员ID 和身份证任选一个传入 | [optional] 
 **openId** | **string**| 蚂蚁统一会员ID 和身份证任选一个传入 | [optional] 
 **certNo** | **string**| 证件号 | [optional] 
 **certType** | **string**| \&quot;身份证 : 0\&quot;，\&quot;护照: 1\&quot;，\&quot;台湾往来通行证：4\&quot;,\&quot;港澳往来通行证：3\&quot;, \&quot;回乡证: 2\&quot;；\&quot;港澳证件：5\&quot; | [optional] 

### Return type

**ZhimaCustomerJobworthAuthenticationQueryResponseModel**

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

