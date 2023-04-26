# AlipaySDKNet.OpenAPI.Api.AlipayFundEnterprisepayGroupApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](AlipayFundEnterprisepayGroupApi.md#add) | **POST** /v3/alipay/fund/enterprisepay/group/add | 因公付新增账户下群组
[**Delete**](AlipayFundEnterprisepayGroupApi.md#delete) | **DELETE** /v3/alipay/fund/enterprisepay/group/delete | 因公付删除账户下群组
[**Modify**](AlipayFundEnterprisepayGroupApi.md#modify) | **POST** /v3/alipay/fund/enterprisepay/group/modify | 因公付更新账户下群组
[**Query**](AlipayFundEnterprisepayGroupApi.md#query) | **GET** /v3/alipay/fund/enterprisepay/group/query | 因公付查询账户下群组


<a name="add"></a>
# **Add**
> AlipayFundEnterprisepayGroupAddResponseModel Add (AlipayFundEnterprisepayGroupAddModel alipayFundEnterprisepayGroupAddModel = null)

因公付新增账户下群组

创建因公付群组，包含群组信息和出资信息

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
    public class AddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundEnterprisepayGroupApi(config);

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

            var alipayFundEnterprisepayGroupAddModel = new AlipayFundEnterprisepayGroupAddModel(); // AlipayFundEnterprisepayGroupAddModel |  (optional) 

            try
            {
                // 因公付新增账户下群组
                AlipayFundEnterprisepayGroupAddResponseModel result = apiInstance.Add(alipayFundEnterprisepayGroupAddModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundEnterprisepayGroupApi.Add: " + e.Message );
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
 **alipayFundEnterprisepayGroupAddModel** | **AlipayFundEnterprisepayGroupAddModel**|  | [optional] 

### Return type

**AlipayFundEnterprisepayGroupAddResponseModel**

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

<a name="delete"></a>
# **Delete**
> Object Delete (string productCode = null, string bizScene = null, string accountId = null, string agreementNo = null, string outBizNo = null)

因公付删除账户下群组

因公付删除账户下群组

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
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayFundEnterprisepayGroupApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 产品码，默认值 ENTERPRISE_PAY (optional) 
            var bizScene = ANT_GROUP;  // string | 场景码，联系支付宝分配 (optional) 
            var accountId = 2088888888;  // string | 企业签约账户ID (optional) 
            var agreementNo = 1231231321323;  // string | 平台和企业的三方授权协议号 (optional) 
            var outBizNo = 12123123;  // string | 外部业务号 (optional) 

            try
            {
                // 因公付删除账户下群组
                Object result = apiInstance.Delete(productCode, bizScene, accountId, agreementNo, outBizNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundEnterprisepayGroupApi.Delete: " + e.Message );
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
 **productCode** | **string**| 产品码，默认值 ENTERPRISE_PAY | [optional] 
 **bizScene** | **string**| 场景码，联系支付宝分配 | [optional] 
 **accountId** | **string**| 企业签约账户ID | [optional] 
 **agreementNo** | **string**| 平台和企业的三方授权协议号 | [optional] 
 **outBizNo** | **string**| 外部业务号 | [optional] 

### Return type

**Object**

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

<a name="modify"></a>
# **Modify**
> Object Modify (AlipayFundEnterprisepayGroupModifyModel alipayFundEnterprisepayGroupModifyModel = null)

因公付更新账户下群组

因公付更新账户下群组

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
            var apiInstance = new AlipayFundEnterprisepayGroupApi(config);

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

            var alipayFundEnterprisepayGroupModifyModel = new AlipayFundEnterprisepayGroupModifyModel(); // AlipayFundEnterprisepayGroupModifyModel |  (optional) 

            try
            {
                // 因公付更新账户下群组
                Object result = apiInstance.Modify(alipayFundEnterprisepayGroupModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundEnterprisepayGroupApi.Modify: " + e.Message );
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
 **alipayFundEnterprisepayGroupModifyModel** | **AlipayFundEnterprisepayGroupModifyModel**|  | [optional] 

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

<a name="query"></a>
# **Query**
> AlipayFundEnterprisepayGroupQueryResponseModel Query (string productCode = null, string bizScene = null, string accountId = null, string agreementNo = null, string outBizNo = null)

因公付查询账户下群组

查询因公付群组，包含群组信息和对应的出资主体

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
            var apiInstance = new AlipayFundEnterprisepayGroupApi(config);

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

            var productCode = ENTERPRISE_PAY;  // string | 产品码，默认值 ENTERPRISE_PAY (optional) 
            var bizScene = ANT_GROUP;  // string | 场景码，联系支付宝分配 (optional) 
            var accountId = 2088888888;  // string | 企业签约账户ID (optional) 
            var agreementNo = 1231231321323;  // string | 平台和企业的三方授权协议号 (optional) 
            var outBizNo = 12312313;  // string | 外部业务号，外部群组号 (optional) 

            try
            {
                // 因公付查询账户下群组
                AlipayFundEnterprisepayGroupQueryResponseModel result = apiInstance.Query(productCode, bizScene, accountId, agreementNo, outBizNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayFundEnterprisepayGroupApi.Query: " + e.Message );
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
 **productCode** | **string**| 产品码，默认值 ENTERPRISE_PAY | [optional] 
 **bizScene** | **string**| 场景码，联系支付宝分配 | [optional] 
 **accountId** | **string**| 企业签约账户ID | [optional] 
 **agreementNo** | **string**| 平台和企业的三方授权协议号 | [optional] 
 **outBizNo** | **string**| 外部业务号，外部群组号 | [optional] 

### Return type

**AlipayFundEnterprisepayGroupQueryResponseModel**

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

