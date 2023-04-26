# AlipaySDKNet.OpenAPI.Api.AntMerchantExpandOrderApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AntMerchantExpandOrderApi.md#query) | **GET** /v3/ant/merchant/order/{order_id} | 商户申请单查询


<a name="query"></a>
# **Query**
> AntMerchantExpandOrderQueryResponseModel Query (string orderId)

商户申请单查询

服务商根据申请单id，查询自己提交的商户进件、管理等申请单

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
            var apiInstance = new AntMerchantExpandOrderApi(config);

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

            var orderId = 2017112200502000000004754299;  // string | 申请单 id。 1.蚂蚁门店管理场景：通过 <a href=\"https://opendocs.alipay.com/apis/014tmc\">ant.merchant.expand.shop.create</a>(蚂蚁店铺创建)接口进件时返回的order_id。 2.直付通二级商户进件场景：通过<a href=\"https://opendocs.alipay.com/pre-apis/00a8e3\">ant.merchant.expand.indirect.zft.create</a>(直付通二级商户创建)接口进件时返回的order_id。

            try
            {
                // 商户申请单查询
                AntMerchantExpandOrderQueryResponseModel result = apiInstance.Query(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandOrderApi.Query: " + e.Message );
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
 **orderId** | **string**| 申请单 id。 1.蚂蚁门店管理场景：通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/014tmc\&quot;&gt;ant.merchant.expand.shop.create&lt;/a&gt;(蚂蚁店铺创建)接口进件时返回的order_id。 2.直付通二级商户进件场景：通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-apis/00a8e3\&quot;&gt;ant.merchant.expand.indirect.zft.create&lt;/a&gt;(直付通二级商户创建)接口进件时返回的order_id。 | 

### Return type

**AntMerchantExpandOrderQueryResponseModel**

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

