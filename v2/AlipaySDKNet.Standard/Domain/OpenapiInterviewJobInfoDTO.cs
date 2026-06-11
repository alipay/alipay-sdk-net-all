using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenapiInterviewJobInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenapiInterviewJobInfoDTO : AopObject
    {
        /// <summary>
        /// 岗位描述
        /// </summary>
        [XmlElement("job_description")]
        public string JobDescription { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位要求
        /// </summary>
        [XmlElement("job_requirement")]
        public string JobRequirement { get; set; }
    }
}
