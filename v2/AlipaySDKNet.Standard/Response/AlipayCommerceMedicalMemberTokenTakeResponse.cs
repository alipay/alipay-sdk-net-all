using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberTokenTakeResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberTokenTakeResponse : AopResponse
    {
        /// <summary>
        /// token码
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// token到期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
