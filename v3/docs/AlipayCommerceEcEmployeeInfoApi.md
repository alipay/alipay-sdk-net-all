# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcEmployeeInfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Modify**](AlipayCommerceEcEmployeeInfoApi.md#modify) | **PUT** /v3/alipay/commerce/ec/employee/info | 修改员工基础信息
[**Query**](AlipayCommerceEcEmployeeInfoApi.md#query) | **GET** /v3/alipay/commerce/ec/employee/info/query | 查询员工详情


<a name="modify"></a>
# **Modify**
> AlipayCommerceEcEmployeeInfoModifyResponseModel Modify (AlipayCommerceEcEmployeeInfoModifyModel alipayCommerceEcEmployeeInfoModifyModel = null)

修改员工基础信息

修改员工基础信息

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
    public class ModifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayCommerceEcEmployeeInfoApi(config);

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

            var alipayCommerceEcEmployeeInfoModifyModel = new AlipayCommerceEcEmployeeInfoModifyModel(); // AlipayCommerceEcEmployeeInfoModifyModel |  (optional) 

            try
            {
                // 修改员工基础信息
                AlipayCommerceEcEmployeeInfoModifyResponseModel result = apiInstance.Modify(alipayCommerceEcEmployeeInfoModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEmployeeInfoApi.Modify: " + e.Message );
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
 **alipayCommerceEcEmployeeInfoModifyModel** | **AlipayCommerceEcEmployeeInfoModifyModel**|  | [optional] 

### Return type

**AlipayCommerceEcEmployeeInfoModifyResponseModel**

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
> AlipayCommerceEcEmployeeInfoQueryResponseModel Query (string enterpriseId = null, string openId = null, string userId = null, string employeeId = null, string mobile = null, string alipayLogonId = null, string employeeCertType = null, string employeeCertNo = null, string employeeEmail = null)

查询员工详情

根据员工id或员工uid查询企业下某个员工的详细信息

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
            var apiInstance = new AlipayCommerceEcEmployeeInfoApi(config);

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

            var enterpriseId = 2088441363102941;  // string | 企业id (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 蚂蚁统一会员ID (optional) 
            var userId = 2088501304519332;  // string | 支付宝用户ID (optional) 
            var employeeId = 2284200000000000;  // string | 员工id (optional) 
            var mobile = 134XXXX2526;  // string | 员工手机号码 (optional) 
            var alipayLogonId = 134xxxx2526;  // string | 支付宝登录号（手机号或邮箱） (optional) 
            var employeeCertType = IDENTITY_CARD;  // string | 员工证件类型 (optional) 
            var employeeCertNo = 220000000000000000;  // string | 员工证件号码 (optional) 
            var employeeEmail = 123@xxx.com;  // string | 员工邮箱 (optional) 

            try
            {
                // 查询员工详情
                AlipayCommerceEcEmployeeInfoQueryResponseModel result = apiInstance.Query(enterpriseId, openId, userId, employeeId, mobile, alipayLogonId, employeeCertType, employeeCertNo, employeeEmail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEmployeeInfoApi.Query: " + e.Message );
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
 **openId** | **string**| 蚂蚁统一会员ID | [optional] 
 **userId** | **string**| 支付宝用户ID | [optional] 
 **employeeId** | **string**| 员工id | [optional] 
 **mobile** | **string**| 员工手机号码 | [optional] 
 **alipayLogonId** | **string**| 支付宝登录号（手机号或邮箱） | [optional] 
 **employeeCertType** | **string**| 员工证件类型 | [optional] 
 **employeeCertNo** | **string**| 员工证件号码 | [optional] 
 **employeeEmail** | **string**| 员工邮箱 | [optional] 

### Return type

**AlipayCommerceEcEmployeeInfoQueryResponseModel**

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

