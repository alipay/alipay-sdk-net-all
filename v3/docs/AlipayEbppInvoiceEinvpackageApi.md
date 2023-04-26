# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceEinvpackageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEbppInvoiceEinvpackageApi.md#query) | **GET** /v3/alipay/ebpp/invoice/einvpackage/query | 查询用户发票包的明细信息


<a name="query"></a>
# **Query**
> AlipayEbppInvoiceEinvpackageQueryResponseModel Query (string encryptedUid = null, string packageId = null)

查询用户发票包的明细信息

第三方报销软件根据支付宝提供的用户的发票包id，查询对应的发票包的电子发票，ocr纸票和消费记录明细信息

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
            var apiInstance = new AlipayEbppInvoiceEinvpackageApi(config);

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

            var encryptedUid = Zhm4AKUE8ShJK6FYfKmk;  // string | 加密过的uid。获取详情参见 <a href=\"https://opendocs.alipay.com/open/017fwh\">\"推\"模式发票报销</a>。 (optional) 
            var packageId = 202004150000000000000000000;  // string | 发票包id。获取详情参见 <a href=\"https://opendocs.alipay.com/open/017fwh\">\"推\"模式发票报销</a>。 (optional) 

            try
            {
                // 查询用户发票包的明细信息
                AlipayEbppInvoiceEinvpackageQueryResponseModel result = apiInstance.Query(encryptedUid, packageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceEinvpackageApi.Query: " + e.Message );
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
 **encryptedUid** | **string**| 加密过的uid。获取详情参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/017fwh\&quot;&gt;\&quot;推\&quot;模式发票报销&lt;/a&gt;。 | [optional] 
 **packageId** | **string**| 发票包id。获取详情参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/017fwh\&quot;&gt;\&quot;推\&quot;模式发票报销&lt;/a&gt;。 | [optional] 

### Return type

**AlipayEbppInvoiceEinvpackageQueryResponseModel**

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

