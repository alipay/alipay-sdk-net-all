using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTimeoutTestQueryResponse.
    /// </summary>
    public class AlipayOpenAppTimeoutTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 秒
        /// </summary>
        [XmlElement("timeout")]
        public string Timeout { get; set; }
    }
}
