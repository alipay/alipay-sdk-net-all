# AlipaySDKNet.OpenAPI.Api.AlipayMerchantIotDeviceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Bind**](AlipayMerchantIotDeviceApi.md#bind) | **POST** /v3/alipay/merchant/iot/device/bind | IoT设备绑定门店
[**Query**](AlipayMerchantIotDeviceApi.md#query) | **GET** /v3/alipay/merchant/iot/device/query | IoT设备绑定关系查询
[**Verify**](AlipayMerchantIotDeviceApi.md#verify) | **POST** /v3/alipay/merchant/iot/device/verify | IoT设备绑定校验


<a name="bind"></a>
# **Bind**
> Object Bind (AlipayMerchantIotDeviceBindModel alipayMerchantIotDeviceBindModel = null)

IoT设备绑定门店

同步IoT设备、商户和门店的绑定关系

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
    public class BindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMerchantIotDeviceApi(config);

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

            var alipayMerchantIotDeviceBindModel = new AlipayMerchantIotDeviceBindModel(); // AlipayMerchantIotDeviceBindModel |  (optional) 

            try
            {
                // IoT设备绑定门店
                Object result = apiInstance.Bind(alipayMerchantIotDeviceBindModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantIotDeviceApi.Bind: " + e.Message );
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
 **alipayMerchantIotDeviceBindModel** | **AlipayMerchantIotDeviceBindModel**|  | [optional] 

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

<a name="query"></a>
# **Query**
> AlipayMerchantIotDeviceQueryResponseModel Query (string deviceIdType = null, string bizTid = null, string supplierId = null, string deviceSn = null)

IoT设备绑定关系查询

通过设备唯一标识查询设备绑定关系

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
            var apiInstance = new AlipayMerchantIotDeviceApi(config);

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

            var deviceIdType = SN;  // string | 可选方式 [ID,SN]。ID-使用biztid作为设备唯一识别标识；SN-使用supplier_id、device_sn联合作为设备唯一识别标识。由于不同机型的supplier_id不同，推荐使用 ID 。 (optional) 
            var bizTid = 01017gV1CZ1XxASNbqkTJqchletNyVXtsKy1PAs4FKZ6tjRMqyMG2Zk;  // string | 设备 ID ，device_id_type 为 ID 时填写。 (optional) 
            var supplierId = 201812271300540049;  // string | 设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。 (optional) 
            var deviceSn = QCF420190316000107;  // string | 设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。 (optional) 

            try
            {
                // IoT设备绑定关系查询
                AlipayMerchantIotDeviceQueryResponseModel result = apiInstance.Query(deviceIdType, bizTid, supplierId, deviceSn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantIotDeviceApi.Query: " + e.Message );
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
 **deviceIdType** | **string**| 可选方式 [ID,SN]。ID-使用biztid作为设备唯一识别标识；SN-使用supplier_id、device_sn联合作为设备唯一识别标识。由于不同机型的supplier_id不同，推荐使用 ID 。 | [optional] 
 **bizTid** | **string**| 设备 ID ，device_id_type 为 ID 时填写。 | [optional] 
 **supplierId** | **string**| 设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。 | [optional] 
 **deviceSn** | **string**| 设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。 | [optional] 

### Return type

**AlipayMerchantIotDeviceQueryResponseModel**

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

<a name="verify"></a>
# **Verify**
> Object Verify (AlipayMerchantIotDeviceVerifyModel alipayMerchantIotDeviceVerifyModel = null)

IoT设备绑定校验

校验IoT设备和商户收单账号的对应关系

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
    public class VerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayMerchantIotDeviceApi(config);

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

            var alipayMerchantIotDeviceVerifyModel = new AlipayMerchantIotDeviceVerifyModel(); // AlipayMerchantIotDeviceVerifyModel |  (optional) 

            try
            {
                // IoT设备绑定校验
                Object result = apiInstance.Verify(alipayMerchantIotDeviceVerifyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayMerchantIotDeviceApi.Verify: " + e.Message );
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
 **alipayMerchantIotDeviceVerifyModel** | **AlipayMerchantIotDeviceVerifyModel**|  | [optional] 

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

