using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobResumesubmiturlGetResponse.
    /// </summary>
    public class AlipayEbppIndustryJobResumesubmiturlGetResponse : AopResponse
    {
        /// <summary>
        /// 岗位投递url   （前端跳转链接） 格式为 alipays://xxxxxx?appId=xxx&template_id=xxx&job_id=xxx&required_attributes=["xxx","xxx"]&optional_attributes=["xxx","xxx"]&return_rule&source_appId="请求来源appId"
        /// </summary>
        [XmlElement("resume_submit_url")]
        public string ResumeSubmitUrl { get; set; }
    }
}
