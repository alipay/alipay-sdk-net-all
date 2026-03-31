using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionModifyModel : AopObject
    {
        /// <summary>
        /// 周期结束失效标识，用于取消订阅，升级等场景不用填
        /// </summary>
        [XmlElement("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 更新描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

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

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
