# AlipaySDKNet.OpenAPI.Api.AlipayEcoMycarParkingParkinglotinfoApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AlipayEcoMycarParkingParkinglotinfoApi.md#create) | **POST** /v3/alipay/eco/mycar/parking/parkinglotinfo/create | 录入停车场信息
[**Query**](AlipayEcoMycarParkingParkinglotinfoApi.md#query) | **GET** /v3/alipay/eco/mycar/parking/parkinglotinfo/query | 停车场信息查询
[**Update**](AlipayEcoMycarParkingParkinglotinfoApi.md#update) | **POST** /v3/alipay/eco/mycar/parking/parkinglotinfo/update | 修改停车场信息


<a name="create"></a>
# **Create**
> AlipayEcoMycarParkingParkinglotinfoCreateResponseModel Create (AlipayEcoMycarParkingParkinglotinfoCreateModel alipayEcoMycarParkingParkinglotinfoCreateModel = null)

录入停车场信息

录入停车场信息，内容信息通过该接口提交到支付宝，支付宝会生成支付宝这边停车场ID反馈给开发者，用户后续更新和上送车辆信息。

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
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoMycarParkingParkinglotinfoApi(config);

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

            var alipayEcoMycarParkingParkinglotinfoCreateModel = new AlipayEcoMycarParkingParkinglotinfoCreateModel(); // AlipayEcoMycarParkingParkinglotinfoCreateModel |  (optional) 

            try
            {
                // 录入停车场信息
                AlipayEcoMycarParkingParkinglotinfoCreateResponseModel result = apiInstance.Create(alipayEcoMycarParkingParkinglotinfoCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingParkinglotinfoApi.Create: " + e.Message );
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
 **alipayEcoMycarParkingParkinglotinfoCreateModel** | **AlipayEcoMycarParkingParkinglotinfoCreateModel**|  | [optional] 

### Return type

**AlipayEcoMycarParkingParkinglotinfoCreateResponseModel**

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

<a name="query"></a>
# **Query**
> AlipayEcoMycarParkingParkinglotinfoQueryResponseModel Query (string parkingId = null, string outParkingId = null)

停车场信息查询

停车场信息查询，通过停车场id或者ISV停车场ID查询停车场信息。只能查询正在调用接口商户自己创建的停车场，限制在归属PID层面上。

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
            var apiInstance = new AlipayEcoMycarParkingParkinglotinfoApi(config);

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

            var parkingId = PI1535687028031821446;  // string | 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个ISV或商户范围内唯一。通过 <a href=\"https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口获取。 注意：parking_id和out_parking_id不能同时为空。 (optional) 
            var outParkingId = 10000110001;  // string | ISV停车场ID，由ISV定义的停车场标识，同一个ISV或商户范围内唯一。需与 <a href=\"https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口传入值一致。 注意：parking_id和out_parking_id不能同时为空。 (optional) 

            try
            {
                // 停车场信息查询
                AlipayEcoMycarParkingParkinglotinfoQueryResponseModel result = apiInstance.Query(parkingId, outParkingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingParkinglotinfoApi.Query: " + e.Message );
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
 **parkingId** | **string**| 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个ISV或商户范围内唯一。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\&quot;&gt;alipay.eco.mycar.parking.parkinglotinfo.create&lt;/a&gt;(录入停车场信息)接口获取。 注意：parking_id和out_parking_id不能同时为空。 | [optional] 
 **outParkingId** | **string**| ISV停车场ID，由ISV定义的停车场标识，同一个ISV或商户范围内唯一。需与 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\&quot;&gt;alipay.eco.mycar.parking.parkinglotinfo.create&lt;/a&gt;(录入停车场信息)接口传入值一致。 注意：parking_id和out_parking_id不能同时为空。 | [optional] 

### Return type

**AlipayEcoMycarParkingParkinglotinfoQueryResponseModel**

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

<a name="update"></a>
# **Update**
> AlipayEcoMycarParkingParkinglotinfoUpdateResponseModel Update (AlipayEcoMycarParkingParkinglotinfoUpdateModel alipayEcoMycarParkingParkinglotinfoUpdateModel = null)

修改停车场信息

录入停车场信息，内容信息通过该接口提交到支付宝，支付宝会生成支付宝这边停车场ID反馈给开发者，用于后续更新和上送车辆信息，停车场名称不允许修改。

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
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoMycarParkingParkinglotinfoApi(config);

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

            var alipayEcoMycarParkingParkinglotinfoUpdateModel = new AlipayEcoMycarParkingParkinglotinfoUpdateModel(); // AlipayEcoMycarParkingParkinglotinfoUpdateModel |  (optional) 

            try
            {
                // 修改停车场信息
                AlipayEcoMycarParkingParkinglotinfoUpdateResponseModel result = apiInstance.Update(alipayEcoMycarParkingParkinglotinfoUpdateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingParkinglotinfoApi.Update: " + e.Message );
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
 **alipayEcoMycarParkingParkinglotinfoUpdateModel** | **AlipayEcoMycarParkingParkinglotinfoUpdateModel**|  | [optional] 

### Return type

**AlipayEcoMycarParkingParkinglotinfoUpdateResponseModel**

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

