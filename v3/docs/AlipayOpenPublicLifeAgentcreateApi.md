# AlipaySDKNet.OpenAPI.Api.AlipayOpenPublicLifeAgentcreateApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayOpenPublicLifeAgentcreateApi.md#query) | **GET** /v3/alipay/open/public/life/agentcreate/query | isv代创建生活号申请状态查询接口


<a name="query"></a>
# **Query**
> AlipayOpenPublicLifeAgentcreateQueryResponseModel Query (string outBizNo = null)

isv代创建生活号申请状态查询接口

isv可调用此接口查询代商户创建的生活号审核状态

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
            var apiInstance = new AlipayOpenPublicLifeAgentcreateApi(config);

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

            var outBizNo = 2016070788301823878;  // string | 由开发者创建的外部入驻申请单据号，需与<a href=\"https://opendocs.alipay.com/apis/api_6/alipay.open.public.life.agent.create\">alipay.open.public.life.agent.create</a>(isv代创建生活号接口)的out_biz_no一致。 (optional) 

            try
            {
                // isv代创建生活号申请状态查询接口
                AlipayOpenPublicLifeAgentcreateQueryResponseModel result = apiInstance.Query(outBizNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayOpenPublicLifeAgentcreateApi.Query: " + e.Message );
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
 **outBizNo** | **string**| 由开发者创建的外部入驻申请单据号，需与&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.life.agent.create\&quot;&gt;alipay.open.public.life.agent.create&lt;/a&gt;(isv代创建生活号接口)的out_biz_no一致。 | [optional] 

### Return type

**AlipayOpenPublicLifeAgentcreateQueryResponseModel**

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

