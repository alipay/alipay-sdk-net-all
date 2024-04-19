using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthTestTestaQueryResponse.
    /// </summary>
    public class AlipayOpenAuthTestTestaQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
