using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionQueryPendingItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionQueryPendingItem : AopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 订阅项id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 订阅项周期截止时间
        /// </summary>
        [XmlElement("period_end")]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// 订阅项周期开始时间
        /// </summary>
        [XmlElement("period_start")]
        public string PeriodStart { get; set; }

        /// <summary>
        /// 商品价格模型
        /// </summary>
        [XmlElement("price")]
        public NexusPayPrice Price { get; set; }

        /// <summary>
        /// 订阅价格项目数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 订阅项状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
