using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborProjectJob Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborProjectJob : AopObject
    {
        /// <summary>
        /// 学历要求
        /// </summary>
        [XmlElement("edu_level")]
        public string EduLevel { get; set; }

        /// <summary>
        /// 工作经验要求
        /// </summary>
        [XmlElement("experience_level")]
        public string ExperienceLevel { get; set; }

        /// <summary>
        /// 服务商岗位 Id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位类型
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 服务商项目 Id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 用户登记认证跳转地址
        /// </summary>
        [XmlElement("register_url")]
        public string RegisterUrl { get; set; }

        /// <summary>
        /// 项目状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
