# AlipaySDKNet.OpenAPI.Api.AlipayEcoDoctemplateSettingurlApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEcoDoctemplateSettingurlApi.md#query) | **GET** /v3/alipay/eco/doctemplate/settingurl/query | 获取合同模板设置地址（E签宝）


<a name="query"></a>
# **Query**
> AlipayEcoDoctemplateSettingurlQueryResponseModel Query (string targetAppId = null, string templateId = null)

获取合同模板设置地址（E签宝）

通过创建合同模板接口返回的模板ID（templateId）获取合同模板的配置地址。在模板设置页面上进行模板输入组件、签署区设置后，即可基于模板发起合同签署。

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
            var apiInstance = new AlipayEcoDoctemplateSettingurlApi(config);

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

            var targetAppId = "targetAppId_example";  // string | 目标isv应用ID (optional) 
            var templateId = 0016801a4ec24e548a93b094856b735c;  // string | 合同模板id。通过<a href =\"https://opendocs.alipay.com/apis/api_50/alipay.eco.doc.template.create\">创建合同模版</a>（alipay.eco.doc.template.create）接口获取。 (optional) 

            try
            {
                // 获取合同模板设置地址（E签宝）
                AlipayEcoDoctemplateSettingurlQueryResponseModel result = apiInstance.Query(targetAppId, templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoDoctemplateSettingurlApi.Query: " + e.Message );
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
 **targetAppId** | **string**| 目标isv应用ID | [optional] 
 **templateId** | **string**| 合同模板id。通过&lt;a href &#x3D;\&quot;https://opendocs.alipay.com/apis/api_50/alipay.eco.doc.template.create\&quot;&gt;创建合同模版&lt;/a&gt;（alipay.eco.doc.template.create）接口获取。 | [optional] 

### Return type

**AlipayEcoDoctemplateSettingurlQueryResponseModel**

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

