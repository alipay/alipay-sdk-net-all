using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateCertificationBatchqueryModel : AopObject
    {
        /// <summary>
        /// 凭证ID列表
        /// </summary>
        [XmlArray("certificate_id_list")]
        [XmlArrayItem("string")]
        public List<string> CertificateIdList { get; set; }

        /// <summary>
        /// 三方码列表。取值为支付宝调用三方凭证发放spi时商户返回的三方码 当前字段已废弃(统一平台码与三方码字段，后续使用凭证id)
        /// </summary>
        [XmlArray("code_list")]
        [XmlArrayItem("string")]
        public List<string> CodeList { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 购买商品的订单id，可以通过下单接口获取订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 凭证归属的支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
