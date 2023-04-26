# AlipaySDKNet.OpenAPI.Api.AntMerchantExpandShopPageApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AntMerchantExpandShopPageApi.md#query) | **GET** /v3/ant/merchant/shop/pagequery | 店铺分页查询接口


<a name="query"></a>
# **Query**
> AntMerchantExpandShopPageQueryResponseModel Query (string ipRoleId = null, int? pageNum = null, int? pageSize = null, string addressVersion = null)

店铺分页查询接口

用于服务商或商户查询其自己的店铺信息

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
            var apiInstance = new AntMerchantExpandShopPageApi(config);

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

            var ipRoleId = 2088301155943087;  // string | 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。特别说明：IoT设备三绑定场景统一填写商户pid (optional) 
            var pageNum = 1;  // int? | 查询页数 (optional) 
            var pageSize = 10;  // int? | 每页查询大小，限制100以内 (optional) 
            var addressVersion = 2022Q2;  // string | 行政区划版本，当前可传空值(取默认版本)、2022Q2、UPTODATE(取最新版本)，其中空值默认为：2020Q1版本(address_version=''或null)，想要查看版本是2022年2季度版本则传入:(address_version='2022Q2')，想要获取最新版本则传入:(address_version ='UPTODATE') (optional) 

            try
            {
                // 店铺分页查询接口
                AntMerchantExpandShopPageQueryResponseModel result = apiInstance.Query(ipRoleId, pageNum, pageSize, addressVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AntMerchantExpandShopPageApi.Query: " + e.Message );
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
 **ipRoleId** | **string**| 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。特别说明：IoT设备三绑定场景统一填写商户pid | [optional] 
 **pageNum** | **int?**| 查询页数 | [optional] 
 **pageSize** | **int?**| 每页查询大小，限制100以内 | [optional] 
 **addressVersion** | **string**| 行政区划版本，当前可传空值(取默认版本)、2022Q2、UPTODATE(取最新版本)，其中空值默认为：2020Q1版本(address_version&#x3D;&#39;&#39;或null)，想要查看版本是2022年2季度版本则传入:(address_version&#x3D;&#39;2022Q2&#39;)，想要获取最新版本则传入:(address_version &#x3D;&#39;UPTODATE&#39;) | [optional] 

### Return type

**AntMerchantExpandShopPageQueryResponseModel**

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

