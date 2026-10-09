using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketYcstestQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketYcstestQueryResponse : AopResponse
    {
        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("out_1")]
        public string Out1 { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [XmlElement("out_2")]
        public string Out2 { get; set; }
    }
}
