using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionApplyCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionApplyCloseModel : AopObject
    {
        /// <summary>
        /// 订阅创建时返回的订单ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订阅ID
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
