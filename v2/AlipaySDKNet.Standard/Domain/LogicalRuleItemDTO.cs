using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogicalRuleItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogicalRuleItemDTO : AopObject
    {
        /// <summary>
        /// 人群名称+不唯一
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群Key+唯一
        /// </summary>
        [XmlElement("ext_crowd_key")]
        public string ExtCrowdKey { get; set; }

        /// <summary>
        /// 人群有效期+不唯一
        /// </summary>
        [XmlElement("gmt_expired_time")]
        public string GmtExpiredTime { get; set; }

        /// <summary>
        /// 人群导出调度方式+不唯一
        /// </summary>
        [XmlElement("schedule_type")]
        public string ScheduleType { get; set; }

        /// <summary>
        /// 逻辑规则方式+不唯一
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
