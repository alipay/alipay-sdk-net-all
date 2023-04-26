# AlipaySDKNet.OpenAPI.Api.AlipayCommerceCityfacilitatorStationApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayCommerceCityfacilitatorStationApi.md#query) | **GET** /v3/alipay/commerce/cityfacilitator/station/query | 地铁购票站点数据查询


<a name="query"></a>
# **Query**
> AlipayCommerceCityfacilitatorStationQueryResponseModel Query (string cityCode = null)

地铁购票站点数据查询

商户App获取地铁购票开放购票的站点和禁止到达的站点

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
            var apiInstance = new AlipayCommerceCityfacilitatorStationApi(config);

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

            var cityCode = 440300;  // string | 城市编码请参考查询 <a href=\"http://www.mca.gov.cn/article/sj/xzqh/\">中华人民共和国行政区划代码</a>。 已支持城市：广州 440100，深圳 440300，杭州330100。 (optional) 

            try
            {
                // 地铁购票站点数据查询
                AlipayCommerceCityfacilitatorStationQueryResponseModel result = apiInstance.Query(cityCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayCommerceCityfacilitatorStationApi.Query: " + e.Message );
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
 **cityCode** | **string**| 城市编码请参考查询 &lt;a href&#x3D;\&quot;http://www.mca.gov.cn/article/sj/xzqh/\&quot;&gt;中华人民共和国行政区划代码&lt;/a&gt;。 已支持城市：广州 440100，深圳 440300，杭州330100。 | [optional] 

### Return type

**AlipayCommerceCityfacilitatorStationQueryResponseModel**

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

