using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborProjectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOfflinelaborProjectCreateModel : AopObject
    {
        /// <summary>
        /// 教育经验
        /// </summary>
        [XmlElement("edu_level")]
        public string EduLevel { get; set; }

        /// <summary>
        /// 工作经验
        /// </summary>
        [XmlElement("experience_level")]
        public string ExperienceLevel { get; set; }

        /// <summary>
        /// 服务商内部岗位 id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位类型清单
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 服务商内部项目 id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
