using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeRefundModel : AopObject
    {
        /// <summary>
        /// 和trade_no不能同时为空，如果都传以trade_no优先
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次请求自费退款金额，单位是元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 同一笔交易多次请求退款需保证唯一
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 蚂蚁逸康平台交易号和out_trade_no不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
