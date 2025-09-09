using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobResumeauthloginurlGetResponse.
    /// </summary>
    public class AlipayEbppIndustryJobResumeauthloginurlGetResponse : AopResponse
    {
        /// <summary>
        /// alipays://xxxxxx?appId=xxx&template_id=xxx&out_user_id=xxx&required_attributes=["xxx","xxx"]&source_app_id="请求来源appId"
        /// </summary>
        [XmlElement("resume_auth_login_url")]
        public string ResumeAuthLoginUrl { get; set; }
    }
}
