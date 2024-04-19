using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorAlarmhistoryGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMonitorAlarmhistoryGetResponse : AopResponse
    {
        /// <summary>
        /// 报警时间
        /// </summary>
        [XmlElement("alarm_time")]
        public string AlarmTime { get; set; }

        /// <summary>
        /// 报警持续时长(分钟)
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 报警历史ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 恢复时间
        /// </summary>
        [XmlElement("recover_time")]
        public string RecoverTime { get; set; }

        /// <summary>
        /// 报警规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 报警规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }
    }
}
