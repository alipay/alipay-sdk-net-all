using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommerceRefundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceRefundDetail : AopObject
    {
        /// <summary>
        /// 原支付流水号
        /// </summary>
        [XmlElement("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 该笔交易退款金额，单位：元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 该笔交易对应的退款流水号
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 该笔交易退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
