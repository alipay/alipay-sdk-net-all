using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_test")]
        public string OutTest { get; set; }
    }
}
