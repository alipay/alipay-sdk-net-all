using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditJhjtestGrayQueryResponse.
    /// </summary>
    public class AlipayPcreditJhjtestGrayQueryResponse : AopResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("out_a")]
        public string OutA { get; set; }
    }
}
