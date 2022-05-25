using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudResumeWorkExperience Data Structure.
    /// </summary>
    [Serializable]
    public class CloudResumeWorkExperience : AopObject
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 职业id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 职业
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
        /// 工作描述
        /// </summary>
        [XmlElement("work_desc")]
        public string WorkDesc { get; set; }

        /// <summary>
        /// 工作结束时间
        /// </summary>
        [XmlElement("work_end_time")]
        public long WorkEndTime { get; set; }

        /// <summary>
        /// 工作开始日期
        /// </summary>
        [XmlElement("work_start_time")]
        public long WorkStartTime { get; set; }
    }
}
