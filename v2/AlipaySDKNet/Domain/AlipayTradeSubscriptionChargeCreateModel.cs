using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionChargeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionChargeCreateModel : AopObject
    {
        /// <summary>
        /// 收费类型
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 订阅项id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
