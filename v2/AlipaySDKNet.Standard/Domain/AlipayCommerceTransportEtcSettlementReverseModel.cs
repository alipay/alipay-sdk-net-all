using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcSettlementReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcSettlementReverseModel : AopObject
    {
        /// <summary>
        /// ETC平台协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 商户行程单id（需要在商户侧唯一）
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 行程支付撤销原因
        /// </summary>
        [XmlElement("reverse_reason")]
        public string ReverseReason { get; set; }
    }
}
