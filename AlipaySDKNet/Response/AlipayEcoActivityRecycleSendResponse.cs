using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoActivityRecycleSendResponse.
    /// </summary>
    public class AlipayEcoActivityRecycleSendResponse : AopResponse
    {
        /// <summary>
        /// 发放的能量总额，单位克: g
        /// </summary>
        [XmlElement("full_energy")]
        public long FullEnergy { get; set; }
    }
}
