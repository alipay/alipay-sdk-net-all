using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceGreenItemenergySendResponse.
    /// </summary>
    public class AlipayCommerceGreenItemenergySendResponse : AopResponse
    {
        /// <summary>
        /// 发放的能量数
        /// </summary>
        [XmlElement("energy_amount")]
        public long EnergyAmount { get; set; }
    }
}
