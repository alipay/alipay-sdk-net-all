# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEcEnterpriseAddressApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](AlipayCommerceEcEnterpriseAddressApi.md#add) | **POST** /v3/alipay/commerce/ec/enterprise/address | 企业地址添加
[**Modify**](AlipayCommerceEcEnterpriseAddressApi.md#modify) | **PUT** /v3/alipay/commerce/ec/enterprise/address | 企业地址修改
[**Query**](AlipayCommerceEcEnterpriseAddressApi.md#query) | **GET** /v3/alipay/commerce/ec/enterprise/address | 企业地址查询


<a name="add"></a>
# **Add**
> AlipayCommerceEcEnterpriseAddressAddResponseModel Add (AlipayCommerceEcEnterpriseAddressAddModel alipayCommerceEcEnterpriseAddressAddModel = null)

企业地址添加

企业地址添加

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
            var apiInstance = new AlipayCommerceEcEnterpriseAddressApi(config);

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

            var alipayCommerceEcEnterpriseAddressAddModel = new AlipayCommerceEcEnterpriseAddressAddModel(); // AlipayCommerceEcEnterpriseAddressAddModel |  (optional) 

            try
            {
                // 企业地址添加
                AlipayCommerceEcEnterpriseAddressAddResponseModel result = apiInstance.Add(alipayCommerceEcEnterpriseAddressAddModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseAddressApi.Add: " + e.Message );
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
 **alipayCommerceEcEnterpriseAddressAddModel** | **AlipayCommerceEcEnterpriseAddressAddModel**|  | [optional] 

### Return type

**AlipayCommerceEcEnterpriseAddressAddResponseModel**

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

<a name="modify"></a>
# **Modify**
> AlipayCommerceEcEnterpriseAddressModifyResponseModel Modify (AlipayCommerceEcEnterpriseAddressModifyModel alipayCommerceEcEnterpriseAddressModifyModel = null)

企业地址修改

企业地址修改

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
            var apiInstance = new AlipayCommerceEcEnterpriseAddressApi(config);

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

            var alipayCommerceEcEnterpriseAddressModifyModel = new AlipayCommerceEcEnterpriseAddressModifyModel(); // AlipayCommerceEcEnterpriseAddressModifyModel |  (optional) 

            try
            {
                // 企业地址修改
                AlipayCommerceEcEnterpriseAddressModifyResponseModel result = apiInstance.Modify(alipayCommerceEcEnterpriseAddressModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseAddressApi.Modify: " + e.Message );
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
 **alipayCommerceEcEnterpriseAddressModifyModel** | **AlipayCommerceEcEnterpriseAddressModifyModel**|  | [optional] 

### Return type

**AlipayCommerceEcEnterpriseAddressModifyResponseModel**

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
> AlipayCommerceEcEnterpriseAddressQueryResponseModel Query (string enterpriseId = null, string accountId = null, string agreementNo = null, string addressId = null, string cityCode = null, int? pageNum = null, int? pageSize = null)

企业地址查询

查询企业地址信息

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
            var apiInstance = new AlipayCommerceEcEnterpriseAddressApi(config);

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

            var enterpriseId = 208890399440;  // string | 企业id和account_id二选一 (optional) 
            var accountId = 2088483784949;  // string | 共同账户id和enterprise_id二选一 (optional) 
            var agreementNo = 23893293203;  // string | 协议号，如果填共同账户id，则该字段必填 (optional) 
            var addressId = 190309300303;  // string | 地址id (optional) 
            var cityCode = 310023;  // string | 市 (optional) 
            var pageNum = 1;  // int? | 页码从1开始 (optional) 
            var pageSize = 20;  // int? | 每页数据 (optional) 

            try
            {
                // 企业地址查询
                AlipayCommerceEcEnterpriseAddressQueryResponseModel result = apiInstance.Query(enterpriseId, accountId, agreementNo, addressId, cityCode, pageNum, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEcEnterpriseAddressApi.Query: " + e.Message );
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
 **enterpriseId** | **string**| 企业id和account_id二选一 | [optional] 
 **accountId** | **string**| 共同账户id和enterprise_id二选一 | [optional] 
 **agreementNo** | **string**| 协议号，如果填共同账户id，则该字段必填 | [optional] 
 **addressId** | **string**| 地址id | [optional] 
 **cityCode** | **string**| 市 | [optional] 
 **pageNum** | **int?**| 页码从1开始 | [optional] 
 **pageSize** | **int?**| 每页数据 | [optional] 

### Return type

**AlipayCommerceEcEnterpriseAddressQueryResponseModel**

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

