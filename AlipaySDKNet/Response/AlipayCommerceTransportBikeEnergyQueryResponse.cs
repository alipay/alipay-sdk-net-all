using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportBikeEnergyQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportBikeEnergyQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户是否开启能量开关 1：开启 0：关闭
        /// </summary>
        [XmlElement("energy_open")]
        public string EnergyOpen { get; set; }
    }
}
