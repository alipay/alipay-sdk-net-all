using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcSettlementRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcSettlementRefundModel : AopObject
    {
        /// <summary>
        /// ETC平台协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 行程单id（需要在商户侧唯一）
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次需要退款的金额： 1、单位为元； 2、该金额不能大于行程扣款的金额； 3、支持两位小数；
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因描述：退费
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }
    }
}
