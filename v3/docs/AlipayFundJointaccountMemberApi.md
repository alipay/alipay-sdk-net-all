# AlipaySDKNet.OpenAPI.Api.AlipayFundJointaccountMemberApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayFundJointaccountMemberApi.md#batchquery) | **POST** /v3/alipay/fund/jointaccount/member/batchquery | 企业批量查询员工信息（分页）
[**Bind**](AlipayFundJointaccountMemberApi.md#bind) | **POST** /v3/alipay/fund/jointaccount/member/bind | 因公付邀请员工
[**Consult**](AlipayFundJointaccountMemberApi.md#consult) | **POST** /v3/alipay/fund/jointaccount/member/consult | 员企关系咨询
[**Query**](AlipayFundJointaccountMemberApi.md#query) | **GET** /v3/alipay/fund/jointaccount/member/query | 企业查询员工列表
[**Unbind**](AlipayFundJointaccountMemberApi.md#unbind) | **POST** /v3/alipay/fund/jointaccount/member/unbind | 企业删除员工


<a name="batchquery"></a>
# **Batchquery**
> AlipayFundJointaccountMemberBatchqueryResponseModel Batchquery (AlipayFundJointaccountMemberBatchqueryModel alipayFundJointaccountMemberBatchqueryModel = null)

企业批量查询员工信息（分页）

企业查询员工列表，支持分页，支持按登录号精确查询，支持按会员号精确查询

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundJointaccountMemberApi(config);

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

            var alipayFundJointaccountMemberBatchqueryModel = new AlipayFundJointaccountMemberBatchqueryModel(); // AlipayFundJointaccountMemberBatchqueryModel |  (optional) 

            try
            {
                // 企业批量查询员工信息（分页）
                AlipayFundJointaccountMemberBatchqueryResponseModel result = apiInstance.Batchquery(alipayFundJointaccountMemberBatchqueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountMemberApi.Batchquery: " + e.Message );
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
 **alipayFundJointaccountMemberBatchqueryModel** | **AlipayFundJointaccountMemberBatchqueryModel**|  | [optional] 

### Return type

**AlipayFundJointaccountMemberBatchqueryResponseModel**

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

<a name="bind"></a>
# **Bind**
> AlipayFundJointaccountMemberBindResponseModel Bind (AlipayFundJointaccountMemberBindModel alipayFundJointaccountMemberBindModel = null)

因公付邀请员工

因公付邀请员工

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
    public class BindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundJointaccountMemberApi(config);

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

            var alipayFundJointaccountMemberBindModel = new AlipayFundJointaccountMemberBindModel(); // AlipayFundJointaccountMemberBindModel |  (optional) 

            try
            {
                // 因公付邀请员工
                AlipayFundJointaccountMemberBindResponseModel result = apiInstance.Bind(alipayFundJointaccountMemberBindModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountMemberApi.Bind: " + e.Message );
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
 **alipayFundJointaccountMemberBindModel** | **AlipayFundJointaccountMemberBindModel**|  | [optional] 

### Return type

**AlipayFundJointaccountMemberBindResponseModel**

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

<a name="consult"></a>
# **Consult**
> AlipayFundJointaccountMemberConsultResponseModel Consult (AlipayFundJointaccountMemberConsultModel alipayFundJointaccountMemberConsultModel = null)

员企关系咨询

返回输入的员工列表是否在指定企业组织中

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
            var apiInstance = new AlipayFundJointaccountMemberApi(config);

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

            var alipayFundJointaccountMemberConsultModel = new AlipayFundJointaccountMemberConsultModel(); // AlipayFundJointaccountMemberConsultModel |  (optional) 

            try
            {
                // 员企关系咨询
                AlipayFundJointaccountMemberConsultResponseModel result = apiInstance.Consult(alipayFundJointaccountMemberConsultModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountMemberApi.Consult: " + e.Message );
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
 **alipayFundJointaccountMemberConsultModel** | **AlipayFundJointaccountMemberConsultModel**|  | [optional] 

### Return type

**AlipayFundJointaccountMemberConsultResponseModel**

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
> AlipayFundJointaccountMemberQueryResponseModel Query (string productCode = null, string bizScene = null, string accountId = null, string pageNum = null, string pageSize = null, string userId = null, string openId = null, string agreementNo = null)

企业查询员工列表

企业查询员工列表

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
            var apiInstance = new AlipayFundJointaccountMemberApi(config);

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
            var accountId = 2088900976746215;  // string | 账户ID (optional) 
            var pageNum = 1;  // string | 采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据。 (optional) 
            var pageSize = 1;  // string | 每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 (optional) 
            var userId = 2088900976746215;  // string | 员工id (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 员工的openId (optional) 
            var agreementNo = 20889009767462151111111;  // string | 授权协议号 (optional) 

            try
            {
                // 企业查询员工列表
                AlipayFundJointaccountMemberQueryResponseModel result = apiInstance.Query(productCode, bizScene, accountId, pageNum, pageSize, userId, openId, agreementNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountMemberApi.Query: " + e.Message );
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
 **accountId** | **string**| 账户ID | [optional] 
 **pageNum** | **string**| 采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据。 | [optional] 
 **pageSize** | **string**| 每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 | [optional] 
 **userId** | **string**| 员工id | [optional] 
 **openId** | **string**| 员工的openId | [optional] 
 **agreementNo** | **string**| 授权协议号 | [optional] 

### Return type

**AlipayFundJointaccountMemberQueryResponseModel**

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

<a name="unbind"></a>
# **Unbind**
> Object Unbind (AlipayFundJointaccountMemberUnbindModel alipayFundJointaccountMemberUnbindModel = null)

企业删除员工

企业删除员工

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
    public class UnbindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundJointaccountMemberApi(config);

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

            var alipayFundJointaccountMemberUnbindModel = new AlipayFundJointaccountMemberUnbindModel(); // AlipayFundJointaccountMemberUnbindModel |  (optional) 

            try
            {
                // 企业删除员工
                Object result = apiInstance.Unbind(alipayFundJointaccountMemberUnbindModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundJointaccountMemberApi.Unbind: " + e.Message );
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
 **alipayFundJointaccountMemberUnbindModel** | **AlipayFundJointaccountMemberUnbindModel**|  | [optional] 

### Return type

**Object**

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

