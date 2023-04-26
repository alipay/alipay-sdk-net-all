# AlipaySDKNet.OpenAPI.Api.AlipayEbppInvoiceExpensecontrolIssuebatchApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Cancel**](AlipayEbppInvoiceExpensecontrolIssuebatchApi.md#cancel) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/issuebatch/cancel | 作废额度发放
[**Create**](AlipayEbppInvoiceExpensecontrolIssuebatchApi.md#create) | **POST** /v3/alipay/ebpp/invoice/expensecontrol/issuebatch/create | 手动发放额度接口


<a name="cancel"></a>
# **Cancel**
> AlipayEbppInvoiceExpensecontrolIssuebatchCancelResponseModel Cancel (AlipayEbppInvoiceExpensecontrolIssuebatchCancelModel alipayEbppInvoiceExpensecontrolIssuebatchCancelModel = null)

作废额度发放

通过发放批次id，作废当前批次下发放的额度

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolIssuebatchApi(config);

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

            var alipayEbppInvoiceExpensecontrolIssuebatchCancelModel = new AlipayEbppInvoiceExpensecontrolIssuebatchCancelModel(); // AlipayEbppInvoiceExpensecontrolIssuebatchCancelModel |  (optional) 

            try
            {
                // 作废额度发放
                AlipayEbppInvoiceExpensecontrolIssuebatchCancelResponseModel result = apiInstance.Cancel(alipayEbppInvoiceExpensecontrolIssuebatchCancelModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolIssuebatchApi.Cancel: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolIssuebatchCancelModel** | **AlipayEbppInvoiceExpensecontrolIssuebatchCancelModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolIssuebatchCancelResponseModel**

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

<a name="create"></a>
# **Create**
> AlipayEbppInvoiceExpensecontrolIssuebatchCreateResponseModel Create (AlipayEbppInvoiceExpensecontrolIssuebatchCreateModel alipayEbppInvoiceExpensecontrolIssuebatchCreateModel = null)

手动发放额度接口

通过该接口对企业下的员工进行批量的额度发放。

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
            var apiInstance = new AlipayEbppInvoiceExpensecontrolIssuebatchApi(config);

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

            var alipayEbppInvoiceExpensecontrolIssuebatchCreateModel = new AlipayEbppInvoiceExpensecontrolIssuebatchCreateModel(); // AlipayEbppInvoiceExpensecontrolIssuebatchCreateModel |  (optional) 

            try
            {
                // 手动发放额度接口
                AlipayEbppInvoiceExpensecontrolIssuebatchCreateResponseModel result = apiInstance.Create(alipayEbppInvoiceExpensecontrolIssuebatchCreateModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayEbppInvoiceExpensecontrolIssuebatchApi.Create: " + e.Message );
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
 **alipayEbppInvoiceExpensecontrolIssuebatchCreateModel** | **AlipayEbppInvoiceExpensecontrolIssuebatchCreateModel**|  | [optional] 

### Return type

**AlipayEbppInvoiceExpensecontrolIssuebatchCreateResponseModel**

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

