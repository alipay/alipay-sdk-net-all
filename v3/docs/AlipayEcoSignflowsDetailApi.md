# AlipaySDKNet.OpenAPI.Api.AlipayEcoSignflowsDetailApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEcoSignflowsDetailApi.md#query) | **GET** /v3/alipay/eco/signflows/detail/query | 获取签署流程合同与附件的下载地址（E签宝）


<a name="query"></a>
# **Query**
> AlipayEcoSignflowsDetailQueryResponseModel Query (string targetAppId = null, string flowId = null)

获取签署流程合同与附件的下载地址（E签宝）

获取签署流程合同与附件的下载地址（E签宝）

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
            var apiInstance = new AlipayEcoSignflowsDetailApi(config);

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

            try
            {
                // 获取签署流程合同与附件的下载地址（E签宝）
                AlipayEcoSignflowsDetailQueryResponseModel result = apiInstance.Query(targetAppId, flowId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoSignflowsDetailApi.Query: " + e.Message );
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

### Return type

**AlipayEcoSignflowsDetailQueryResponseModel**

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

