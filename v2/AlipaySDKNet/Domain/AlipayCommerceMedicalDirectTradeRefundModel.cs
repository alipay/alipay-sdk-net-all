using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDirectTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDirectTradeRefundModel : AopObject
    {
        /// <summary>
        /// 与trade_no不能都为空，都有值时优先取trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额，单元是元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 用户退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 同一笔交易多次请求退款需保证唯一
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 与out_trade_no不能都为空，都有值时优先取trade_no
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
