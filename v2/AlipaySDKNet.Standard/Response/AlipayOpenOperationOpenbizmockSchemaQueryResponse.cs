using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockSchemaQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockSchemaQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("result_open_id")]
        public string ResultOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("result_type")]
        public string ResultType { get; set; }
    }
}
