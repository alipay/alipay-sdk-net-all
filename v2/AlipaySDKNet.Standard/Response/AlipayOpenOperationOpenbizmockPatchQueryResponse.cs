using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockPatchQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockPatchQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
