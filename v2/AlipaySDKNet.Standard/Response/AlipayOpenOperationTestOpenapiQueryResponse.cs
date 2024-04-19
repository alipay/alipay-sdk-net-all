using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationTestOpenapiQueryResponse.
    /// </summary>
    public class AlipayOpenOperationTestOpenapiQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_type")]
        public string OutType { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("out_uid")]
        public string OutUid { get; set; }
    }
}
