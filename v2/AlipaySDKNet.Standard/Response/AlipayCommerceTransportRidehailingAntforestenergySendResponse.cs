using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportRidehailingAntforestenergySendResponse.
    /// </summary>
    public class AlipayCommerceTransportRidehailingAntforestenergySendResponse : AopResponse
    {
        /// <summary>
        /// 发放能量总额
        /// </summary>
        [XmlElement("full_energy")]
        public long FullEnergy { get; set; }
    }
}
