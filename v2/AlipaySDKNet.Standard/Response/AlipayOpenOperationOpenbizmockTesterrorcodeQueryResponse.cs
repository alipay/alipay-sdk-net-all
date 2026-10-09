using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTesterrorcodeQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTesterrorcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// sucesee
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
