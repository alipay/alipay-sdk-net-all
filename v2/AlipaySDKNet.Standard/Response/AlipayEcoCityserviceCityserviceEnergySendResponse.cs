using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceCityserviceEnergySendResponse.
    /// </summary>
    public class AlipayEcoCityserviceCityserviceEnergySendResponse : AopResponse
    {
        /// <summary>
        /// 发放的能量总额，单位：克
        /// </summary>
        [XmlElement("total_energy")]
        public long TotalEnergy { get; set; }
    }
}
