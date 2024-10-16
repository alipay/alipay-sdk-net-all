using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionRefundOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionRefundOrderInfo : AopObject
    {
        /// <summary>
        /// 业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 退款面额，单位：分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款现金价值，单位：分
        /// </summary>
        [XmlElement("refund_cash")]
        public long RefundCash { get; set; }

        /// <summary>
        /// 退款单id
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
