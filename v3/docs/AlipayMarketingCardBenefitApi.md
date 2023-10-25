# AlipaySDKNet.OpenAPI.Api.AlipayMarketingCardBenefitApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayMarketingCardBenefitApi.md#create) | **POST** /v3/alipay/marketing/card/benefit/create | 会员卡模板外部权益创建
[**Delete**](AlipayMarketingCardBenefitApi.md#delete) | **DELETE** /v3/alipay/marketing/card/benefit/delete | 会员卡模板外部权益删除
[**Modify**](AlipayMarketingCardBenefitApi.md#modify) | **POST** /v3/alipay/marketing/card/benefit/modify | 会员卡模板外部权益修改
[**Query**](AlipayMarketingCardBenefitApi.md#query) | **GET** /v3/alipay/marketing/card/benefit/query | 会员卡模板外部权益查询


<a name="create"></a>
# **Create**
> AlipayMarketingCardBenefitCreateResponseModel Create (AlipayMarketingCardBenefitCreateModel alipayMarketingCardBenefitCreateModel = null)

会员卡模板外部权益创建

会员卡模板外部权益创建，创建的权益内容信息将展示在卡包中卡详情页中部区域。

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
            var apiInstance = new AlipayMarketingCardBenefitApi(config);

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

            var alipayMarketingCardBenefitCreateModel = new AlipayMarketingCardBenefitCreateModel(); // AlipayMarketingCardBenefitCreateModel |  (optional) 

            try
            {
                // 会员卡模板外部权益创建
                AlipayMarketingCardBenefitCreateResponseModel result = apiInstance.Create(alipayMarketingCardBenefitCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardBenefitApi.Create: " + e.Message );
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
 **alipayMarketingCardBenefitCreateModel** | **AlipayMarketingCardBenefitCreateModel**|  | [optional] 

### Return type

**AlipayMarketingCardBenefitCreateResponseModel**

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
> AlipayMarketingCardBenefitDeleteResponseModel Delete (string templateId = null, string benefitId = null)

会员卡模板外部权益删除

会员卡模板外部权益删除

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
            var apiInstance = new AlipayMarketingCardBenefitApi(config);

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

            var templateId = 20170322000000000068101000300041;  // string | 会员卡模板ID，通过 <a  href=\"https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.template.create\">alipay.marketing.card.template.create</a>（会员卡模板创建)接口创建会员卡模板获取。 (optional) 
            var benefitId = 20170322000000000068101000300041;  // string | 权益ID，通过 <a  href=\"https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\">alipay.marketing.card.benefit.create</a>(会员卡模板外部权益创建)接口创建获取。 (optional) 

            try
            {
                // 会员卡模板外部权益删除
                AlipayMarketingCardBenefitDeleteResponseModel result = apiInstance.Delete(templateId, benefitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardBenefitApi.Delete: " + e.Message );
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
 **templateId** | **string**| 会员卡模板ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.template.create\&quot;&gt;alipay.marketing.card.template.create&lt;/a&gt;（会员卡模板创建)接口创建会员卡模板获取。 | [optional] 
 **benefitId** | **string**| 权益ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\&quot;&gt;alipay.marketing.card.benefit.create&lt;/a&gt;(会员卡模板外部权益创建)接口创建获取。 | [optional] 

### Return type

**AlipayMarketingCardBenefitDeleteResponseModel**

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
> AlipayMarketingCardBenefitModifyResponseModel Modify (AlipayMarketingCardBenefitModifyModel alipayMarketingCardBenefitModifyModel = null)

会员卡模板外部权益修改

会员卡模板外部权益修改

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
            var apiInstance = new AlipayMarketingCardBenefitApi(config);

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

            var alipayMarketingCardBenefitModifyModel = new AlipayMarketingCardBenefitModifyModel(); // AlipayMarketingCardBenefitModifyModel |  (optional) 

            try
            {
                // 会员卡模板外部权益修改
                AlipayMarketingCardBenefitModifyResponseModel result = apiInstance.Modify(alipayMarketingCardBenefitModifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardBenefitApi.Modify: " + e.Message );
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
 **alipayMarketingCardBenefitModifyModel** | **AlipayMarketingCardBenefitModifyModel**|  | [optional] 

### Return type

**AlipayMarketingCardBenefitModifyResponseModel**

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
> AlipayMarketingCardBenefitQueryResponseModel Query (string templateId = null, string benefitId = null)

会员卡模板外部权益查询

会员卡模板外部权益查询

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
            var apiInstance = new AlipayMarketingCardBenefitApi(config);

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

            var templateId = 20170322000000000068101000300041;  // string | 会员卡模板ID，通过 <a  href=\"https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.template.create\">alipay.marketing.card.template.create</a>（会员卡模板创建)接口创建会员卡模板获取。 (optional) 
            var benefitId = 20170322000000000068101000300041;  // string | 权益ID，通过 <a  href=\"https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\">alipay.marketing.card.benefit.create</a>(会员卡模板外部权益创建)接口创建获取。 (optional) 

            try
            {
                // 会员卡模板外部权益查询
                AlipayMarketingCardBenefitQueryResponseModel result = apiInstance.Query(templateId, benefitId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingCardBenefitApi.Query: " + e.Message );
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
 **templateId** | **string**| 会员卡模板ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.template.create\&quot;&gt;alipay.marketing.card.template.create&lt;/a&gt;（会员卡模板创建)接口创建会员卡模板获取。 | [optional] 
 **benefitId** | **string**| 权益ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\&quot;&gt;alipay.marketing.card.benefit.create&lt;/a&gt;(会员卡模板外部权益创建)接口创建获取。 | [optional] 

### Return type

**AlipayMarketingCardBenefitQueryResponseModel**

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

