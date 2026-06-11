using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionEstimatedrefundQueryResponse.
    /// </summary>
    public class AlipayTradeSubscriptionEstimatedrefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 预计退款金额，仅当可退款时返回，其他状态不返回
        /// </summary>
        [XmlElement("estimated_refund_amount")]
        public long EstimatedRefundAmount { get; set; }

        /// <summary>
        /// true - 可以退款； false - 不可退款
        /// </summary>
        [XmlElement("refundable")]
        public bool Refundable { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 订阅zhua
        /// </summary>
        [XmlElement("subscription_status")]
        public string SubscriptionStatus { get; set; }
    }
}
