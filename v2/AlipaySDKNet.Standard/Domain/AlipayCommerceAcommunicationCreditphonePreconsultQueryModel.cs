using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePreconsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphonePreconsultQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝开放平台ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 预鉴权请求流水号（全局唯一）
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
