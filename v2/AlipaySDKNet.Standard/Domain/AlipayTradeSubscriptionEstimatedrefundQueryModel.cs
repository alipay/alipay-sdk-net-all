using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionEstimatedrefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionEstimatedrefundQueryModel : AopObject
    {
        /// <summary>
        /// 订阅客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
