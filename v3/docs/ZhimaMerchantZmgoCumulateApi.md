# AlipaySDKNet.OpenAPI.Api.ZhimaMerchantZmgoCumulateApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](ZhimaMerchantZmgoCumulateApi.md#query) | **GET** /v3/zhima/merchant/zmgo/cumulate/query | 商家芝麻GO累计数据查询接口
[**Sync**](ZhimaMerchantZmgoCumulateApi.md#sync) | **POST** /v3/zhima/merchant/zmgo/cumulate/sync | 商家芝麻GO累计数据回传接口


<a name="query"></a>
# **Query**
> ZhimaMerchantZmgoCumulateQueryResponseModel Query (string agreementId = null, string userId = null, string openId = null, string providerPid = null, bool? needDetail = null, int? pageNo = null, int? pageSize = null)

商家芝麻GO累计数据查询接口

芝麻GO数据累计查询接口，包含汇总和明细信息

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
            var apiInstance = new ZhimaMerchantZmgoCumulateApi(config);

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

            var agreementId = 20195108518085620000;  // string | 芝麻go协议号，唯一标识一个芝麻go协议。 (optional) 
            var userId = 2088602002015001;  // string | 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional) 
            var providerPid = 2088621805983504;  // string | 数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional) 
            var needDetail = false;  // bool? | 是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。 (optional) 
            var pageNo = 1;  // int? | 分页参数，当need_detail=true时需要，代表当前页数，从1开始。 (optional) 
            var pageSize = 20;  // int? | 分页参数，当need_detail=true时需要，代表每页大小，不能大于20。 (optional) 

            try
            {
                // 商家芝麻GO累计数据查询接口
                ZhimaMerchantZmgoCumulateQueryResponseModel result = apiInstance.Query(agreementId, userId, openId, providerPid, needDetail, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaMerchantZmgoCumulateApi.Query: " + e.Message );
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
 **agreementId** | **string**| 芝麻go协议号，唯一标识一个芝麻go协议。 | [optional] 
 **userId** | **string**| 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 | [optional] 
 **openId** | **string**| 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 | [optional] 
 **providerPid** | **string**| 数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 | [optional] 
 **needDetail** | **bool?**| 是否需要回传明细。枚举支持： * true：需要回传明细。 * false：不需要回传明细。 | [optional] 
 **pageNo** | **int?**| 分页参数，当need_detail&#x3D;true时需要，代表当前页数，从1开始。 | [optional] 
 **pageSize** | **int?**| 分页参数，当need_detail&#x3D;true时需要，代表每页大小，不能大于20。 | [optional] 

### Return type

**ZhimaMerchantZmgoCumulateQueryResponseModel**

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

<a name="sync"></a>
# **Sync**
> ZhimaMerchantZmgoCumulateSyncResponseModel Sync (ZhimaMerchantZmgoCumulateSyncModel zhimaMerchantZmgoCumulateSyncModel = null)

商家芝麻GO累计数据回传接口

外部商家接入芝麻GO场景下，回传用户行为履约数据给芝麻。

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
    public class SyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new ZhimaMerchantZmgoCumulateApi(config);

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

            var zhimaMerchantZmgoCumulateSyncModel = new ZhimaMerchantZmgoCumulateSyncModel(); // ZhimaMerchantZmgoCumulateSyncModel |  (optional) 

            try
            {
                // 商家芝麻GO累计数据回传接口
                ZhimaMerchantZmgoCumulateSyncResponseModel result = apiInstance.Sync(zhimaMerchantZmgoCumulateSyncModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZhimaMerchantZmgoCumulateApi.Sync: " + e.Message );
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
 **zhimaMerchantZmgoCumulateSyncModel** | **ZhimaMerchantZmgoCumulateSyncModel**|  | [optional] 

### Return type

**ZhimaMerchantZmgoCumulateSyncResponseModel**

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

