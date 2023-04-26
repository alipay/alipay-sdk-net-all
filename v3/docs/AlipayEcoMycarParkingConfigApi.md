# AlipaySDKNet.OpenAPI.Api.AlipayEcoMycarParkingConfigApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](AlipayEcoMycarParkingConfigApi.md#query) | **GET** /v3/alipay/eco/mycar/parking/config/query | ISV系统配置查询接口
[**Set**](AlipayEcoMycarParkingConfigApi.md#set) | **POST** /v3/alipay/eco/mycar/parking/config/set | 停车ISV系统配置接口


<a name="query"></a>
# **Query**
> AlipayEcoMycarParkingConfigQueryResponseModel Query (string interfaceName = null, string interfaceType = null)

ISV系统配置查询接口

ISV通过该接口，查询ISV已注册到车主平台停车业务系统配置信息。

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
            var apiInstance = new AlipayEcoMycarParkingConfigApi(config);

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

            var interfaceName = alipay.eco.mycar.parking.userpage.query;  // string | 接口名称。H5传入参数固定值：alipay.eco.mycar.parking.userpage.query； 小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage； 协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify。 (optional) 
            var interfaceType = interface_page;  // string | 接口类型。H5、小程序传入参数固定值：interface_page； 通知接口传入参数固定值：interface_service。 (optional) 

            try
            {
                // ISV系统配置查询接口
                AlipayEcoMycarParkingConfigQueryResponseModel result = apiInstance.Query(interfaceName, interfaceType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingConfigApi.Query: " + e.Message );
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
 **interfaceName** | **string**| 接口名称。H5传入参数固定值：alipay.eco.mycar.parking.userpage.query； 小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage； 协议状态变更通知传入参数固定值： alipay.eco.mycar.parking.agreement.notify。 | [optional] 
 **interfaceType** | **string**| 接口类型。H5、小程序传入参数固定值：interface_page； 通知接口传入参数固定值：interface_service。 | [optional] 

### Return type

**AlipayEcoMycarParkingConfigQueryResponseModel**

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

<a name="set"></a>
# **Set**
> Object Set (AlipayEcoMycarParkingConfigSetModel alipayEcoMycarParkingConfigSetModel = null)

停车ISV系统配置接口

ISV通过该接口，配置车主平台各业务所需要的ISV的系统配置信息。如果接口配置存在则覆盖原有的接口信息。通过该接口设置的配置信息是立刻生效的，在调用该接口修改配置信息时请先评估对线上业务的影响，并做好处理方案。

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
    public class SetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEcoMycarParkingConfigApi(config);

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

            var alipayEcoMycarParkingConfigSetModel = new AlipayEcoMycarParkingConfigSetModel(); // AlipayEcoMycarParkingConfigSetModel |  (optional) 

            try
            {
                // 停车ISV系统配置接口
                Object result = apiInstance.Set(alipayEcoMycarParkingConfigSetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEcoMycarParkingConfigApi.Set: " + e.Message );
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
 **alipayEcoMycarParkingConfigSetModel** | **AlipayEcoMycarParkingConfigSetModel**|  | [optional] 

### Return type

**Object**

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

