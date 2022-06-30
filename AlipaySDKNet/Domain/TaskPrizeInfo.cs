using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskPrizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskPrizeInfo : AopObject
    {
        /// <summary>
        /// 奖品实例id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品模版id
        /// </summary>
        [XmlElement("prize_template_id")]
        public string PrizeTemplateId { get; set; }

        /// <summary>
        /// 奖品类型（VOUCHER-支付券）
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 任务事件id，任务事件类型是TRADE_SOURCE时，为支付宝交易号
        /// </summary>
        [XmlElement("task_event_id")]
        public string TaskEventId { get; set; }

        /// <summary>
        /// 任务事件类型（TRADE_SOURCE-交易事件）
        /// </summary>
        [XmlElement("task_event_type")]
        public string TaskEventType { get; set; }
    }
}
