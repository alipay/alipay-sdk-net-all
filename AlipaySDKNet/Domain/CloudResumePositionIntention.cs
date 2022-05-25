using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudResumePositionIntention Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumePositionIntention : AopObject
    {
        /// <summary>
        /// 意向城市
        /// </summary>
        [XmlElement("intention_city")]
        public string IntentionCity { get; set; }

        /// <summary>
        /// 职业id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 职业名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 行业id
        /// </summary>
        [XmlElement("profession_id")]
        public string ProfessionId { get; set; }

        /// <summary>
        /// 行业名称
        /// </summary>
        [XmlElement("profession_name")]
        public string ProfessionName { get; set; }

        /// <summary>
        /// 最大工资
        /// </summary>
        [XmlElement("salary_max")]
        public string SalaryMax { get; set; }

        /// <summary>
        /// 最小薪资
        /// </summary>
        [XmlElement("salary_min")]
        public string SalaryMin { get; set; }

        /// <summary>
        /// 工资单位，/月 /日
        /// </summary>
        [XmlElement("salary_unit")]
        public string SalaryUnit { get; set; }

        /// <summary>
        /// 工作属性
        /// </summary>
        [XmlElement("work_property")]
        public string WorkProperty { get; set; }
    }
}
