using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionItem : AopObject
    {
        /// <summary>
        /// 订阅场景下项目id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 订阅场景下支付宝侧的项目id
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }
    }
}
