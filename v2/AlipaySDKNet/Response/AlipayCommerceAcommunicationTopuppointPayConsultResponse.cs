using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationTopuppointPayConsultResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationTopuppointPayConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否通过
        /// </summary>
        [XmlElement("access")]
        public bool Access { get; set; }
    }
}
