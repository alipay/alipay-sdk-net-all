using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceIndustryEnergySendResponse.
    /// </summary>
    public class AlipayEcoCityserviceIndustryEnergySendResponse : AopResponse
    {
        /// <summary>
        /// 发放的能量总额，单位：克
        /// </summary>
        [XmlElement("total_energy")]
        public string TotalEnergy { get; set; }
    }
}
