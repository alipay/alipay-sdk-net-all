# AlipaySDKNet.OpenAPI.Api.AlipayEbppPdeductSignApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](AlipayEbppPdeductSignApi.md#add) | **POST** /v3/alipay/ebpp/pdeduct/sign/add | 缴费直连代扣签约
[**Cancel**](AlipayEbppPdeductSignApi.md#cancel) | **POST** /v3/alipay/ebpp/pdeduct/sign/cancel | 缴费直连代扣取消签约
[**Query**](AlipayEbppPdeductSignApi.md#query) | **GET** /v3/alipay/ebpp/pdeduct/sign/query | 直连代扣协议查询接口
[**Validate**](AlipayEbppPdeductSignApi.md#validate) | **POST** /v3/alipay/ebpp/pdeduct/sign/validate | 缴费直连代扣签约前置校验


<a name="add"></a>
# **Add**
> AlipayEbppPdeductSignAddResponseModel Add (AlipayEbppPdeductSignAddModel alipayEbppPdeductSignAddModel = null)

缴费直连代扣签约

缴费直连代扣签约

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
    public class AddExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppPdeductSignApi(config);

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

            var alipayEbppPdeductSignAddModel = new AlipayEbppPdeductSignAddModel(); // AlipayEbppPdeductSignAddModel |  (optional) 

            try
            {
                // 缴费直连代扣签约
                AlipayEbppPdeductSignAddResponseModel result = apiInstance.Add(alipayEbppPdeductSignAddModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppPdeductSignApi.Add: " + e.Message );
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
 **alipayEbppPdeductSignAddModel** | **AlipayEbppPdeductSignAddModel**|  | [optional] 

### Return type

**AlipayEbppPdeductSignAddResponseModel**

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

<a name="cancel"></a>
# **Cancel**
> AlipayEbppPdeductSignCancelResponseModel Cancel (AlipayEbppPdeductSignCancelModel alipayEbppPdeductSignCancelModel = null)

缴费直连代扣取消签约

缴费直连代扣，用户取消签约接口

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
    public class CancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppPdeductSignApi(config);

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

            var alipayEbppPdeductSignCancelModel = new AlipayEbppPdeductSignCancelModel(); // AlipayEbppPdeductSignCancelModel |  (optional) 

            try
            {
                // 缴费直连代扣取消签约
                AlipayEbppPdeductSignCancelResponseModel result = apiInstance.Cancel(alipayEbppPdeductSignCancelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppPdeductSignApi.Cancel: " + e.Message );
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
 **alipayEbppPdeductSignCancelModel** | **AlipayEbppPdeductSignCancelModel**|  | [optional] 

### Return type

**AlipayEbppPdeductSignCancelResponseModel**

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
> AlipayEbppPdeductSignQueryResponseModel Query (string userId = null, string openId = null, string agreementId = null, string bizType = null, string subBizType = null, string chargeInst = null, string billKey = null)

直连代扣协议查询接口

提供给朗新查询代扣协议状态的接口，用于进行双边对账，解决单边协议问题

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
            var apiInstance = new AlipayEbppPdeductSignApi(config);

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

            var userId = 2088302186230962;  // string | 用户ID (optional) 
            var openId = 074a1CcTG1LelxKe4xQC0zgNdId0nxi95b5lsNpazWYoCo5;  // string | 用户UserId在应用AppId下的唯一用户标识 (optional) 
            var agreementId = 1234557890;  // string | 支付宝代扣协议Id。若协议id不传递，则需要保证业务类型、子业务类型、出账机构、户号必传 (optional) 
            var bizType = JF;  // string | 业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值 (optional) 
            var subBizType = ELECTRIC;  // string | 业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值 (optional) 
            var chargeInst = CQCENTERELECTRIC;  // string | 支付宝缴费系统中的出账机构ID (optional) 
            var billKey = 02659981;  // string | 户号，机构针对于每户的水、电都会有唯一的标识户号 (optional) 

            try
            {
                // 直连代扣协议查询接口
                AlipayEbppPdeductSignQueryResponseModel result = apiInstance.Query(userId, openId, agreementId, bizType, subBizType, chargeInst, billKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppPdeductSignApi.Query: " + e.Message );
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
 **userId** | **string**| 用户ID | [optional] 
 **openId** | **string**| 用户UserId在应用AppId下的唯一用户标识 | [optional] 
 **agreementId** | **string**| 支付宝代扣协议Id。若协议id不传递，则需要保证业务类型、子业务类型、出账机构、户号必传 | [optional] 
 **bizType** | **string**| 业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值 | [optional] 
 **subBizType** | **string**| 业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值 | [optional] 
 **chargeInst** | **string**| 支付宝缴费系统中的出账机构ID | [optional] 
 **billKey** | **string**| 户号，机构针对于每户的水、电都会有唯一的标识户号 | [optional] 

### Return type

**AlipayEbppPdeductSignQueryResponseModel**

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

<a name="validate"></a>
# **Validate**
> Object Validate (AlipayEbppPdeductSignValidateModel alipayEbppPdeductSignValidateModel = null)

缴费直连代扣签约前置校验

服务窗代扣签约的前置校验接口，签约前，可以先调用该接口进行校验是否可以签约

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
    public class ValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayEbppPdeductSignApi(config);

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

            var alipayEbppPdeductSignValidateModel = new AlipayEbppPdeductSignValidateModel(); // AlipayEbppPdeductSignValidateModel |  (optional) 

            try
            {
                // 缴费直连代扣签约前置校验
                Object result = apiInstance.Validate(alipayEbppPdeductSignValidateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppPdeductSignApi.Validate: " + e.Message );
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
 **alipayEbppPdeductSignValidateModel** | **AlipayEbppPdeductSignValidateModel**|  | [optional] 

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

