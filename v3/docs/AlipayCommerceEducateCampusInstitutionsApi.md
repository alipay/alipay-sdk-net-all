# AlipaySDKNet.OpenAPI.Api.AlipayCommerceEducateCampusInstitutionsApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](AlipayCommerceEducateCampusInstitutionsApi.md#add) | **POST** /v3/alipay/commerce/educate/campus/institutions/add | 入驻学校信息
[**Query**](AlipayCommerceEducateCampusInstitutionsApi.md#query) | **GET** /v3/alipay/commerce/educate/campus/institutions/query | 查询学校信息


<a name="add"></a>
# **Add**
> AlipayCommerceEducateCampusInstitutionsAddResponseModel Add (AlipayCommerceEducateCampusInstitutionsAddModel alipayCommerceEducateCampusInstitutionsAddModel = null)

入驻学校信息

学校信息入驻

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
            var apiInstance = new AlipayCommerceEducateCampusInstitutionsApi(config);

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

            var alipayCommerceEducateCampusInstitutionsAddModel = new AlipayCommerceEducateCampusInstitutionsAddModel(); // AlipayCommerceEducateCampusInstitutionsAddModel |  (optional) 

            try
            {
                // 入驻学校信息
                AlipayCommerceEducateCampusInstitutionsAddResponseModel result = apiInstance.Add(alipayCommerceEducateCampusInstitutionsAddModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEducateCampusInstitutionsApi.Add: " + e.Message );
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
 **alipayCommerceEducateCampusInstitutionsAddModel** | **AlipayCommerceEducateCampusInstitutionsAddModel**|  | [optional] 

### Return type

**AlipayCommerceEducateCampusInstitutionsAddResponseModel**

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
> AlipayCommerceEducateCampusInstitutionsQueryResponseModel Query (string instName = null, string provinceCode = null, string cityCode = null, string instId = null, string instStdCode = null, string likeProperty = null)

查询学校信息

可以通过学校库产品查询支付宝系统中是否已存在对应的学校，避免重复入驻，以及通过该接口查询入驻的进度：入驻成功则会返回学校信息，失败则不会返回

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
            var apiInstance = new AlipayCommerceEducateCampusInstitutionsApi(config);

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

            var instName = 复旦大学;  // string | 学校名称 (optional) 
            var provinceCode = 370000;  // string | 省份编码，编码标准为中华人民共和国行政区划代码，参见 2020年12月中华人民共和国县以上行政区划代码。 (optional) 
            var cityCode = 370900;  // string | 城市编码，编码标准为中华人民共和国行政区划代码，参见 2020年12月中华人民共和国县以上行政区划代码。 (optional) 
            var instId = 2088000139662311;  // string | 学校内标：支付宝内部学校唯一编号。使用内标查询时，默认使用内标进行精确匹配。 (optional) 
            var instStdCode = 202008016104;  // string | 学校外标：统一社会信用编码或教育部提供的学校标识码。使用学校外标查询时，默认使用外标进行精确匹配。 (optional) 
            var likeProperty = 1;  // string | 是否使用学校名称模糊匹配进行查询，默认精确匹配。 枚举值如下： 1：精确匹配； 0：模糊匹配 (optional) 

            try
            {
                // 查询学校信息
                AlipayCommerceEducateCampusInstitutionsQueryResponseModel result = apiInstance.Query(instName, provinceCode, cityCode, instId, instStdCode, likeProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceEducateCampusInstitutionsApi.Query: " + e.Message );
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
 **instName** | **string**| 学校名称 | [optional] 
 **provinceCode** | **string**| 省份编码，编码标准为中华人民共和国行政区划代码，参见 2020年12月中华人民共和国县以上行政区划代码。 | [optional] 
 **cityCode** | **string**| 城市编码，编码标准为中华人民共和国行政区划代码，参见 2020年12月中华人民共和国县以上行政区划代码。 | [optional] 
 **instId** | **string**| 学校内标：支付宝内部学校唯一编号。使用内标查询时，默认使用内标进行精确匹配。 | [optional] 
 **instStdCode** | **string**| 学校外标：统一社会信用编码或教育部提供的学校标识码。使用学校外标查询时，默认使用外标进行精确匹配。 | [optional] 
 **likeProperty** | **string**| 是否使用学校名称模糊匹配进行查询，默认精确匹配。 枚举值如下： 1：精确匹配； 0：模糊匹配 | [optional] 

### Return type

**AlipayCommerceEducateCampusInstitutionsQueryResponseModel**

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

