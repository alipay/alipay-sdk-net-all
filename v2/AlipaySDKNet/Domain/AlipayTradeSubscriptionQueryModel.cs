using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 枚举值： 未完成:INCOMPLETE 活跃:ACTIVE 未完成已过期:INCOMPLETE_EXPIRED 已取消:CANCELED
        /// </summary>
        [XmlElement("subscription_status")]
        public string SubscriptionStatus { get; set; }
    }
}
