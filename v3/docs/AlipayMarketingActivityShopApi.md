# AlipaySDKNet.OpenAPI.Api.AlipayMarketingActivityShopApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Batchquery**](AlipayMarketingActivityShopApi.md#batchquery) | **GET** /v3/alipay/marketing/activity/{activity_id}/shop/batchquery | 查询活动可用门店


<a name="batchquery"></a>
# **Batchquery**
> AlipayMarketingActivityShopBatchqueryResponseModel Batchquery (string activityId, string merchantId = null, int? pageNum = null, int? pageSize = null, string productVersion = null, string merchantAccessMode = null)

查询活动可用门店

通过此接口可查询活动的可用门店，判断券是否在某门店可用，来决定是否展示。

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
    public class BatchqueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMarketingActivityShopApi(config);

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

            var activityId = 2016042700826004508401111111;  // string | 活动id
            var merchantId = 2088202967380463;  // string | 商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional) 
            var pageNum = 1;  // int? | 分页查询页码。  限制:  必须为大于0的整数 (optional) 
            var pageSize = 20;  // int? | 分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional) 
            var productVersion = 2.0.0;  // string | 版本号  枚举值: 2.0.0 (optional) 
            var merchantAccessMode = AGENCY_MODE;  // string | 商户接入模式 (optional) 

            try
            {
                // 查询活动可用门店
                AlipayMarketingActivityShopBatchqueryResponseModel result = apiInstance.Batchquery(activityId, merchantId, pageNum, pageSize, productVersion, merchantAccessMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMarketingActivityShopApi.Batchquery: " + e.Message );
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
 **activityId** | **string**| 活动id | 
 **merchantId** | **string**| 商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 | [optional] 
 **pageNum** | **int?**| 分页查询页码。  限制:  必须为大于0的整数 | [optional] 
 **pageSize** | **int?**| 分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 | [optional] 
 **productVersion** | **string**| 版本号  枚举值: 2.0.0 | [optional] 
 **merchantAccessMode** | **string**| 商户接入模式 | [optional] 

### Return type

**AlipayMarketingActivityShopBatchqueryResponseModel**

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

