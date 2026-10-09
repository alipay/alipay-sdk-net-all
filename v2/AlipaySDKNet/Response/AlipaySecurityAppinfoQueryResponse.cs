using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityAppinfoQueryResponse.
    /// </summary>
    public class AlipaySecurityAppinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("bbb")]
        public string Bbb { get; set; }
    }
}
