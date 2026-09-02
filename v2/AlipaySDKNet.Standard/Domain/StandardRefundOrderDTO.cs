using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardRefundOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StandardRefundOrderDTO : AopObject
    {
        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 退款单状态，无具体枚举，和响应类型保持一致
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public MultiCurrencyMoneyDTO RefundAmount { get; set; }

        /// <summary>
        /// 退款订单id
        /// </summary>
        [XmlElement("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// 退款请求id
        /// </summary>
        [XmlElement("refund_request_id")]
        public string RefundRequestId { get; set; }
    }
}
