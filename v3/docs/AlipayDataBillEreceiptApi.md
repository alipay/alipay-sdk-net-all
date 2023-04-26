# AlipaySDKNet.OpenAPI.Api.AlipayDataBillEreceiptApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Apply**](AlipayDataBillEreceiptApi.md#apply) | **POST** /v3/alipay/data/bill/ereceipt/apply | 申请电子回单(incubating)
[**Query**](AlipayDataBillEreceiptApi.md#query) | **GET** /v3/alipay/data/bill/ereceipt/query | 查询电子回单状态(incubating)


<a name="apply"></a>
# **Apply**
> AlipayDataBillEreceiptApplyResponseModel Apply (AlipayDataBillEreceiptApplyModel alipayDataBillEreceiptApplyModel = null)

申请电子回单(incubating)

支持商家下载多种类型支付宝资金凭证。包括：余额收支证明、余额收支流水证明、转入转出收支证明、收支汇总证明（日汇总）以及收支汇总证明（月汇总）。  账单凭证申请分两个步骤：  1、使用alipay.data.bill.ereceipt.apply创建申请，并获取file_id信息。  2、使用file_id查询alipay.data.bill.ereceipt.query获取回单信息，回单生成完毕将会返回对应的下载链接，下载链接时效为30秒，过期将无法下载，需重新调用alipay.data.bill.ereceipt.query获取新的下载链接。

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
    public class ApplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayDataBillEreceiptApi(config);

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

            var alipayDataBillEreceiptApplyModel = new AlipayDataBillEreceiptApplyModel(); // AlipayDataBillEreceiptApplyModel |  (optional) 

            try
            {
                // 申请电子回单(incubating)
                AlipayDataBillEreceiptApplyResponseModel result = apiInstance.Apply(alipayDataBillEreceiptApplyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillEreceiptApi.Apply: " + e.Message );
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
 **alipayDataBillEreceiptApplyModel** | **AlipayDataBillEreceiptApplyModel**|  | [optional] 

### Return type

**AlipayDataBillEreceiptApplyResponseModel**

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
> AlipayDataBillEreceiptQueryResponseModel Query (string fileId = null)

查询电子回单状态(incubating)

电子签章申请分两个步骤：  1、使用alipay.data.bill.ereceipt.apply创建申请，并获取file_id信息。 2、等待一段时间后，使用file_id查询alipay.data.bill.ereceipt.query申请信息。  单个申请建议每5分钟查询一次状态。批量回单建议20分钟查询一次。汇总回单建议30分钟查询一次

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
            var apiInstance = new AlipayDataBillEreceiptApi(config);

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

            var fileId = 12345;  // string | 根据申请id查询状态。通过 <a href=\"https://opendocs.alipay.com/apis/api_15/alipay.data.bill.ereceipt.apply\">alipay.data.bill.ereceipt.apply(申请电子回单(incubating))</a> 接口同步响应获取。 (optional) 

            try
            {
                // 查询电子回单状态(incubating)
                AlipayDataBillEreceiptQueryResponseModel result = apiInstance.Query(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayDataBillEreceiptApi.Query: " + e.Message );
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
 **fileId** | **string**| 根据申请id查询状态。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_15/alipay.data.bill.ereceipt.apply\&quot;&gt;alipay.data.bill.ereceipt.apply(申请电子回单(incubating))&lt;/a&gt; 接口同步响应获取。 | [optional] 

### Return type

**AlipayDataBillEreceiptQueryResponseModel**

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

