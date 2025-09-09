using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborProjectModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOfflinelaborProjectModifyModel : AopObject
    {
        /// <summary>
        /// 学历要求 非空更新
        /// </summary>
        [XmlElement("edu_level")]
        public string EduLevel { get; set; }

        /// <summary>
        /// 工作经验要求 非空更新
        /// </summary>
        [XmlElement("experience_level")]
        public string ExperienceLevel { get; set; }

        /// <summary>
        /// 服务商内部岗位 Id 对应项目岗位创建接口请求参数中的岗位Id  如果存在则更新岗位信息
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名 非空更新
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位类型 非空更新 与 岗位类型清单 进行校验
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 服务商内部项目 Id 对应项目岗位创建接口请求参数中的项目Id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名（非空更新）
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目状态（非空更新）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
