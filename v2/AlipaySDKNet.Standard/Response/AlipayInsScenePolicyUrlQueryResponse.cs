using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsScenePolicyUrlQueryResponse.
    /// </summary>
    public class AlipayInsScenePolicyUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 过期时间，格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 保单详情url
        /// </summary>
        [XmlElement("policy_url")]
        public string PolicyUrl { get; set; }
    }
}
