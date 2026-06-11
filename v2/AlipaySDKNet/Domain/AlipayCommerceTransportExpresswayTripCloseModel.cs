using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportExpresswayTripCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝车牌付代扣协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 路网侧扣款行程单号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 行程支付撤销原因
        /// </summary>
        [XmlElement("reverse_reason")]
        public string ReverseReason { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
