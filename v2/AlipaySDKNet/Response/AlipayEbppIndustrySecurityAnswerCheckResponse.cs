using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySecurityAnswerCheckResponse.
    /// </summary>
    public class AlipayEbppIndustrySecurityAnswerCheckResponse : AopResponse
    {
        /// <summary>
        /// 检测结果是否安全
        /// </summary>
        [XmlElement("safe")]
        public bool Safe { get; set; }

        /// <summary>
        /// 会话动作
        /// </summary>
        [XmlElement("session_action")]
        public string SessionAction { get; set; }
    }
}
