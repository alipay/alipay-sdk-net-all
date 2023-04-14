using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestEnergyQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestEnergyQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前用户可用能量值（单位是g)
        /// </summary>
        [XmlElement("current_energy")]
        public long CurrentEnergy { get; set; }

        /// <summary>
        /// 用户当前总能量（单位是g)
        /// </summary>
        [XmlElement("total_energy")]
        public long TotalEnergy { get; set; }
    }
}
