using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIsponetestComputertestQuickcreateResponse.
    /// </summary>
    public class AlipayIsponetestComputertestQuickcreateResponse : AopResponse
    {
        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("dddd")]
        public string Dddd { get; set; }
    }
}
