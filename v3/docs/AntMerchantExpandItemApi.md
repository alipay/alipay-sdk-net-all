# AlipaySDKNet.OpenAPI.Api.AntMerchantExpandItemApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AntMerchantExpandItemApi.md#create) | **POST** /v3/ant/merchant/expand/item/create | 商品创建接口
[**Delete**](AntMerchantExpandItemApi.md#delete) | **DELETE** /v3/ant/merchant/expand/item/delete | 商品删除接口
[**Modify**](AntMerchantExpandItemApi.md#modify) | **POST** /v3/ant/merchant/expand/item/modify | 商品修改接口
[**Query**](AntMerchantExpandItemApi.md#query) | **GET** /v3/ant/merchant/expand/item/query | 商品查询接口


<a name="create"></a>
# **Create**
> AntMerchantExpandItemCreateResponseModel Create (AntMerchantExpandItemCreateModel antMerchantExpandItemCreateModel = null)

商品创建接口

用于服务商或商户创建商品

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AntMerchantExpandItemApi(config);

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

            var antMerchantExpandItemCreateModel = new AntMerchantExpandItemCreateModel(); // AntMerchantExpandItemCreateModel |  (optional) 

            try
            {
                // 商品创建接口
                AntMerchantExpandItemCreateResponseModel result = apiInstance.Create(antMerchantExpandItemCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandItemApi.Create: " + e.Message );
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
 **antMerchantExpandItemCreateModel** | **AntMerchantExpandItemCreateModel**|  | [optional] 

### Return type

**AntMerchantExpandItemCreateResponseModel**

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
> AntMerchantExpandItemDeleteResponseModel Delete (string itemId = null, string externalItemId = null)

商品删除接口

用于服务商或商户删除商品

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
            var apiInstance = new AntMerchantExpandItemApi(config);

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

            var itemId = 2018091300502200002600104169;  // string | 商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional) 
            var externalItemId = 20190916123124123123123;  // string | 外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional) 

            try
            {
                // 商品删除接口
                AntMerchantExpandItemDeleteResponseModel result = apiInstance.Delete(itemId, externalItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandItemApi.Delete: " + e.Message );
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
 **itemId** | **string**| 商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） | [optional] 
 **externalItemId** | **string**| 外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） | [optional] 

### Return type

**AntMerchantExpandItemDeleteResponseModel**

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
> AntMerchantExpandItemModifyResponseModel Modify (AntMerchantExpandItemModifyModel antMerchantExpandItemModifyModel = null)

商品修改接口

用于服务商或商户修改商品

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
            var apiInstance = new AntMerchantExpandItemApi(config);

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

            var antMerchantExpandItemModifyModel = new AntMerchantExpandItemModifyModel(); // AntMerchantExpandItemModifyModel |  (optional) 

            try
            {
                // 商品修改接口
                AntMerchantExpandItemModifyResponseModel result = apiInstance.Modify(antMerchantExpandItemModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandItemApi.Modify: " + e.Message );
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
 **antMerchantExpandItemModifyModel** | **AntMerchantExpandItemModifyModel**|  | [optional] 

### Return type

**AntMerchantExpandItemModifyResponseModel**

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
> AntMerchantExpandItemQueryResponseModel Query (string targetType = null, string targetId = null, bool? undefinedCategory = null, string frontCategoryId = null, string status = null)

商品查询接口

用于服务商或商户查询其商品信息

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
            var apiInstance = new AntMerchantExpandItemApi(config);

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

            var targetType = 5;  // string | 商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人 (optional) 
            var targetId = 2018090600502000000022501261;  // string | 商品归属主体id (optional) 
            var undefinedCategory = false;  // bool? | 未分类类目: true 的时候 front_category_id 必须不填（null） (optional) 
            var frontCategoryId = 2018091300502200002600105884;  // string | 商品前台类目id: null 表示所有分类 (optional) 
            var status = EFFECT;  // string | 商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品 (optional) 

            try
            {
                // 商品查询接口
                AntMerchantExpandItemQueryResponseModel result = apiInstance.Query(targetType, targetId, undefinedCategory, frontCategoryId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandItemApi.Query: " + e.Message );
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
 **targetType** | **string**| 商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人 | [optional] 
 **targetId** | **string**| 商品归属主体id | [optional] 
 **undefinedCategory** | **bool?**| 未分类类目: true 的时候 front_category_id 必须不填（null） | [optional] 
 **frontCategoryId** | **string**| 商品前台类目id: null 表示所有分类 | [optional] 
 **status** | **string**| 商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品 | [optional] 

### Return type

**AntMerchantExpandItemQueryResponseModel**

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

