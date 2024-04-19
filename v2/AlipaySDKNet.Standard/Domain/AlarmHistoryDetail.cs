using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmHistoryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmHistoryDetail : AopObject
    {
        /// <summary>
        /// 报警内容
        /// </summary>
        [XmlElement("alarm_content")]
        public string AlarmContent { get; set; }

        /// <summary>
        /// 报警时间
        /// </summary>
        [XmlElement("alarm_time")]
        public string AlarmTime { get; set; }

        /// <summary>
        /// 告警历史ID
        /// </summary>
        [XmlElement("history_id")]
        public string HistoryId { get; set; }

        /// <summary>
        /// 告警规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }
    }
}
