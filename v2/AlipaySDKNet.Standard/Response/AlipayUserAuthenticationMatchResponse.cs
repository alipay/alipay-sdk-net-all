using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAuthenticationMatchResponse.
    /// </summary>
    public class AlipayUserAuthenticationMatchResponse : AopResponse
    {
        /// <summary>
        /// 一致性校验是否通过，T/F
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }
    }
}
