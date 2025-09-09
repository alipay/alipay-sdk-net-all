using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthIsvQueryResponse.
    /// </summary>
    public class AlipayOpenAuthIsvQueryResponse : AopResponse
    {
        /// <summary>
        /// 脱敏后的授权商户的支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 授权商户应用的应用id
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 授权商户应用的应用名称
        /// </summary>
        [XmlElement("merchant_app_name")]
        public string MerchantAppName { get; set; }

        /// <summary>
        /// 脱敏后的授权商户的名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
    }
}
