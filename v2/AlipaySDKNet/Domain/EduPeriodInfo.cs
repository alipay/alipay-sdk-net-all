using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduPeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduPeriodInfo : AopObject
    {
        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 课时配置列表
        /// </summary>
        [XmlArray("period_config_list")]
        [XmlArrayItem("edu_period_config")]
        public List<EduPeriodConfig> PeriodConfigList { get; set; }

        /// <summary>
        /// 课时配置描述
        /// </summary>
        [XmlElement("period_desc")]
        public string PeriodDesc { get; set; }

        /// <summary>
        /// 课时配置ID
        /// </summary>
        [XmlElement("period_id")]
        public string PeriodId { get; set; }

        /// <summary>
        /// 课时配置名称
        /// </summary>
        [XmlElement("period_name")]
        public string PeriodName { get; set; }
    }
}
