using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockDeleteQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockDeleteQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
