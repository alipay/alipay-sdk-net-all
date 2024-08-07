using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarRefundItem Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarRefundItem : AopObject
    {
        /// <summary>
        /// 当前退款请求在此支付流水中退款的金额，单位分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 当前退款请求在此支付流水中退款的结果
        /// </summary>
        [XmlElement("refund_result")]
        public string RefundResult { get; set; }

        /// <summary>
        /// 支付流水的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
