# AlipaySDKNet.OpenAPI.Api.AlipayEcoSignflowsUrlApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEcoSignflowsUrlApi.md#query) | **GET** /v3/alipay/eco/signflows/url/query | 获取签署地址


<a name="query"></a>
# **Query**
> AlipayEcoSignflowsUrlQueryResponseModel Query (string targetAppId = null, string flowId = null, string thirdPartyUserId = null, string orgThirdPartyUserId = null)

获取签署地址

创建流程后，获取指定签署人的签署链接地址，可在应用内集成H5签署页，或者通过短信发送签署链接。 传入个人唯一标识，则获取的签署任务链接仅包含个人人的签署任务；如同时传入企业唯一标识，则获取的签署任务链接包含企业与个人的签署任务。 预览链接：支持签署人先查看合同原文，后进行登录并完成签署。适用于应用内集成场景。 签署链接：签署人需要登录后查看合同原文并签署。适用用短信发送场景。

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
            var apiInstance = new AlipayEcoSignflowsUrlApi(config);

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
            var flowId = 429b1d3038854cabbcdac0a63d7e4c0d;  // string | 流程id，通过 <a href =\"https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\">创建电子合同签署流程</a>(alipay.eco.contract.signflows.create)接口获取。 (optional) 
            var thirdPartyUserId = 2088102924502823;  // string | 创建流程时指定个人唯一标识 (optional) 
            var orgThirdPartyUserId = 913301087458306077;  // string | 创建流程时指定企业唯一标识 (optional) 

            try
            {
                // 获取签署地址
                AlipayEcoSignflowsUrlQueryResponseModel result = apiInstance.Query(targetAppId, flowId, thirdPartyUserId, orgThirdPartyUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoSignflowsUrlApi.Query: " + e.Message );
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
 **flowId** | **string**| 流程id，通过 &lt;a href &#x3D;\&quot;https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\&quot;&gt;创建电子合同签署流程&lt;/a&gt;(alipay.eco.contract.signflows.create)接口获取。 | [optional] 
 **thirdPartyUserId** | **string**| 创建流程时指定个人唯一标识 | [optional] 
 **orgThirdPartyUserId** | **string**| 创建流程时指定企业唯一标识 | [optional] 

### Return type

**AlipayEcoSignflowsUrlQueryResponseModel**

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

