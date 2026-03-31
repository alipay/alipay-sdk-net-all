using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Subscription Data Structure.
    /// </summary>
    [Serializable]
    public class Subscription : AopObject
    {
        /// <summary>
        /// true - 周期结束状态生效 false - 周期结束依旧生效
        /// </summary>
        [XmlElement("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 订阅取消时间
        /// </summary>
        [XmlElement("canceled_date")]
        public string CanceledDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 当前周期结束时间
        /// </summary>
        [XmlElement("current_period_end")]
        public string CurrentPeriodEnd { get; set; }

        /// <summary>
        /// 当前周期开始时间
        /// </summary>
        [XmlElement("current_period_start")]
        public string CurrentPeriodStart { get; set; }

        /// <summary>
        /// 支付宝客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 订阅项目信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("subscription_query_item")]
        public List<SubscriptionQueryItem> Items { get; set; }

        /// <summary>
        /// 订阅开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 订阅标题
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 订阅状态，例如INCOMPLETE（未完成），ACTIVE（活跃），INCOMPLETE_EXPIRED（未完成已过期），CANCELED（已取消）等
        /// </summary>
        [XmlElement("subscription_status")]
        public string SubscriptionStatus { get; set; }
    }
}
