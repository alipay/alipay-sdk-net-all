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
        /// 一致性校验是否通过，T/F
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }
    }
}
