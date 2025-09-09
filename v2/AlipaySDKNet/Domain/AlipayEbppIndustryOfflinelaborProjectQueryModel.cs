using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborProjectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOfflinelaborProjectQueryModel : AopObject
    {
        /// <summary>
        /// 服务商内部岗位 Id 对应项目岗位创建接口请求参数的岗位 ID
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名（迷糊搜索）
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 页码（从 1 开始）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面记录（最大50 ）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务商内部项目id 对应项目岗位创建接口请求参数的项目 ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名（模糊搜索）
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
