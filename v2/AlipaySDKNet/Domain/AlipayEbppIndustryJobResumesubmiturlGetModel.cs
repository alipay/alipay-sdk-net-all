using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobResumesubmiturlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobResumesubmiturlGetModel : AopObject
    {
        /// <summary>
        /// 机构同步给岗位后返回的jobId out_job_id 为空时必传
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 外部job_id job_id 为空时必传
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// 招聘平台名称
        /// </summary>
        [XmlElement("recruitment_platform_name")]
        public string RecruitmentPlatformName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("required_attributes")]
        [XmlArrayItem("string")]
        public List<string> RequiredAttributes { get; set; }

        /// <summary>
        /// 简历投递完成回跳链接
        /// </summary>
        [XmlElement("source_return_url")]
        public string SourceReturnUrl { get; set; }

        /// <summary>
        /// 简历模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
