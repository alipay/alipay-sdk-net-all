# AlipaySDKNet.OpenAPI.Api.AlipayTradeAdvanceApi

All URIs are relative to *https://openapi.alipay.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Consult**](AlipayTradeAdvanceApi.md#consult) | **GET** /v3/alipay/trade/advance/consult | 订单咨询服务


<a name="consult"></a>
# **Consult**
> AlipayTradeAdvanceConsultResponseModel Consult (string alipayUserId = null, string consultScene = null, string industryProductCode = null, string subMerchantId = null, string subMerchantType = null, string agreementNo = null, string estimatedOrderAmount = null, string outTradeNo = null, string needUserRiskPrediction = null, string tradeDigest = null, string userOutBindingPhone = null)

订单咨询服务

商户通过此接口咨询，当前用户是否满足垫资服务条件 或者 针对单笔订单的风险评估进行预咨询服务。

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
    public class ConsultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://openapi.alipay.com";
            var apiInstance = new AlipayTradeAdvanceApi(config);

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

            var alipayUserId = 2088302483540171;  // string | 支付宝用户 id，2088开头的16为数字。 除单笔订单风险预评估场景(即consult_scene指定ORDER_RISK_EVALUATION)外，其他场景必选。 (optional) 
            var consultScene = ORDER_RISK_EVALUATION;  // string | 订单咨询类型，用以选择咨询的服务。不传时默认为垫资咨询，其他的场景需要按照对接的服务传入指定的值。 ORDER_RISK_EVALUATION：表示单笔订单风险预评估。 (optional) 
            var industryProductCode = CAR_OWNERS_PARKINGPAY;  // string | 行业产品信息，咨询时会从该产品对应的销售方案中获取相关垫资规则配置。 (optional) 
            var subMerchantId = 2088102122458832;  // string | 子商户id (optional) 
            var subMerchantType = PARTNER;  // string | 子商户类型 (optional) 
            var agreementNo = 20170322450983769228;  // string | 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ） ，在进行单笔订单风险评估预咨询时必传。 (optional) 
            var estimatedOrderAmount = 9.00;  // string | 预估订单总金额，单位为元，精确到小数点后两位，单笔订单风险预评估时使用，取值范围[0.01,100000000]。 (optional) 
            var outTradeNo = test20191100000001;  // string | 商户请求时的外部订单号，在花芝场景下非空。 (optional) 
            var needUserRiskPrediction = true;  // string | 是否需要进行用户风险预测 (optional) 
            var tradeDigest = {{"parking_city":"太原市","vehicle_number":"辽7666666"}};  // string | 交易信息摘要，需要进行用户风险预测时可传，用于结合场景的更加精细的预测。具体信息结构服务接入前咨询约定。 (optional) 
            var userOutBindingPhone = 1868888888888;  // string | 用户在外部域账号系统绑定的手机号，需要进行用户风险预测时必传，用于预测用户是否面临被二次放号的场景。使用时需要对请求加密，加密后请求在公网传输时为加密文本。详见：https://opendocs.alipay.com/open/common/104567；https://opendocs.alipay.com/isv/grefvl/getaes (optional) 

            try
            {
                // 订单咨询服务
                AlipayTradeAdvanceConsultResponseModel result = apiInstance.Consult(alipayUserId, consultScene, industryProductCode, subMerchantId, subMerchantType, agreementNo, estimatedOrderAmount, outTradeNo, needUserRiskPrediction, tradeDigest, userOutBindingPhone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayTradeAdvanceApi.Consult: " + e.Message );
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
 **alipayUserId** | **string**| 支付宝用户 id，2088开头的16为数字。 除单笔订单风险预评估场景(即consult_scene指定ORDER_RISK_EVALUATION)外，其他场景必选。 | [optional] 
 **consultScene** | **string**| 订单咨询类型，用以选择咨询的服务。不传时默认为垫资咨询，其他的场景需要按照对接的服务传入指定的值。 ORDER_RISK_EVALUATION：表示单笔订单风险预评估。 | [optional] 
 **industryProductCode** | **string**| 行业产品信息，咨询时会从该产品对应的销售方案中获取相关垫资规则配置。 | [optional] 
 **subMerchantId** | **string**| 子商户id | [optional] 
 **subMerchantType** | **string**| 子商户类型 | [optional] 
 **agreementNo** | **string**| 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ） ，在进行单笔订单风险评估预咨询时必传。 | [optional] 
 **estimatedOrderAmount** | **string**| 预估订单总金额，单位为元，精确到小数点后两位，单笔订单风险预评估时使用，取值范围[0.01,100000000]。 | [optional] 
 **outTradeNo** | **string**| 商户请求时的外部订单号，在花芝场景下非空。 | [optional] 
 **needUserRiskPrediction** | **string**| 是否需要进行用户风险预测 | [optional] 
 **tradeDigest** | **string**| 交易信息摘要，需要进行用户风险预测时可传，用于结合场景的更加精细的预测。具体信息结构服务接入前咨询约定。 | [optional] 
 **userOutBindingPhone** | **string**| 用户在外部域账号系统绑定的手机号，需要进行用户风险预测时必传，用于预测用户是否面临被二次放号的场景。使用时需要对请求加密，加密后请求在公网传输时为加密文本。详见：https://opendocs.alipay.com/open/common/104567；https://opendocs.alipay.com/isv/grefvl/getaes | [optional] 

### Return type

**AlipayTradeAdvanceConsultResponseModel**

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

