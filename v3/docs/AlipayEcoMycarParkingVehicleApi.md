# AlipaySDKNet.OpenAPI.Api.AlipayEcoMycarParkingVehicleApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEcoMycarParkingVehicleApi.md#query) | **GET** /v3/alipay/eco/mycar/parking/vehicle/query | 车牌查询接口


<a name="query"></a>
# **Query**
> AlipayEcoMycarParkingVehicleQueryResponseModel Query (string authToken = null, string carId = null)

车牌查询接口

商户通过接口调用，获取用户车牌信息

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
            var apiInstance = new AlipayEcoMycarParkingVehicleApi(config);

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

            var authToken = "authToken_example";  // string | 用户授权令牌 (optional) 
            var carId = 201605061278654;  // string | 支付宝用户车辆ID，系统唯一。（该参数会在停车平台用户点击查询缴费，跳转到ISV停车缴费查询页面时，从请求中传递） (optional) 

            try
            {
                // 车牌查询接口
                AlipayEcoMycarParkingVehicleQueryResponseModel result = apiInstance.Query(authToken, carId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingVehicleApi.Query: " + e.Message );
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
 **authToken** | **string**| 用户授权令牌 | [optional] 
 **carId** | **string**| 支付宝用户车辆ID，系统唯一。（该参数会在停车平台用户点击查询缴费，跳转到ISV停车缴费查询页面时，从请求中传递） | [optional] 

### Return type

**AlipayEcoMycarParkingVehicleQueryResponseModel**

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

