using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("subscription_item")]
        public List<SubscriptionItem> Items { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }
    }
}
