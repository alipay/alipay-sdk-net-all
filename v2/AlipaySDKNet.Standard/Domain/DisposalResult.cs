using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DisposalResult Data Structure.
    /// </summary>
    [Serializable]
    public class DisposalResult : AopObject
    {
        /// <summary>
        /// 流程结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 主体ID
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 流程开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 处置状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 策略code
        /// </summary>
        [XmlElement("strategy_code")]
        public string StrategyCode { get; set; }

        /// <summary>
        /// 处置系统唯一标识
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }
    }
}
