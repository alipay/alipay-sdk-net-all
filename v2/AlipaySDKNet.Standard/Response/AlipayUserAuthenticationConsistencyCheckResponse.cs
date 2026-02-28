using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAuthenticationConsistencyCheckResponse.
    /// </summary>
    public class AlipayUserAuthenticationConsistencyCheckResponse : AopResponse
    {
        /// <summary>
        /// 未认证时的引导跳转链接
        /// </summary>
        [XmlElement("certify_url")]
        public string CertifyUrl { get; set; }

        /// <summary>
        /// 一致性校验是否通过，T/F
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }

        /// <summary>
        /// 未认证提示文案
        /// </summary>
        [XmlElement("not_certify_msg")]
        public string NotCertifyMsg { get; set; }

        /// <summary>
        /// 1688场景核验不一致的错误码
        /// </summary>
        [XmlElement("not_match_code")]
        public string NotMatchCode { get; set; }

        /// <summary>
        /// 1688场景核验不一致的错误原因
        /// </summary>
        [XmlElement("not_match_msg")]
        public string NotMatchMsg { get; set; }
    }
}
