using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagRuleCrowdDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TagRuleCrowdDTO : AopObject
    {
        /// <summary>
        /// 人群名称+不唯一
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群场景Code+唯一
        /// </summary>
        [XmlElement("crowd_scene")]
        public string CrowdScene { get; set; }

        /// <summary>
        /// 是否需要导出沟通+不唯一
        /// </summary>
        [XmlElement("export_to_gotone")]
        public bool ExportToGotone { get; set; }

        /// <summary>
        /// 人群有效期+不唯一
        /// </summary>
        [XmlElement("gmt_expired_time")]
        public string GmtExpiredTime { get; set; }

        /// <summary>
        /// 标签组规则+不唯一
        /// </summary>
        [XmlArray("rules")]
        [XmlArrayItem("tag_rule_group_d_t_o")]
        public List<TagRuleGroupDTO> Rules { get; set; }

        /// <summary>
        /// 人群导出调度时间+不唯一
        /// </summary>
        [XmlElement("schedule_time")]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 人群导出调度方式+不唯一
        /// </summary>
        [XmlElement("schedule_type")]
        public string ScheduleType { get; set; }

        /// <summary>
        /// 人群来源+不唯一
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
