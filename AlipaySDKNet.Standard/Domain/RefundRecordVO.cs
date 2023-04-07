using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRecordVO : AopObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部退款流水号
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 支付系统退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }
    }
}
