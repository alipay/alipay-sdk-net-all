using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmHistory Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmHistory : AopObject
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
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 报警恢复时间
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

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
