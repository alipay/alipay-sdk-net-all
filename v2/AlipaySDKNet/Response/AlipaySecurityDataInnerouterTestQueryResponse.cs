using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataInnerouterTestQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInnerouterTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("one")]
        public string One { get; set; }
    }
}
