using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoutingThresholdDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RoutingThresholdDTO : AopObject
    {
        /// <summary>
        /// 境外切境内阈值
        /// </summary>
        [XmlElement("offshore_to_onshore_bps")]
        public long OffshoreToOnshoreBps { get; set; }

        /// <summary>
        /// 境内切境外阈值
        /// </summary>
        [XmlElement("onshore_to_offshore_bps")]
        public long OnshoreToOffshoreBps { get; set; }
    }
}
