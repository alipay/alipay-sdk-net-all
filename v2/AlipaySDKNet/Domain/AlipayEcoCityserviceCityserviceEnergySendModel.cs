using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceCityserviceEnergySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceCityserviceEnergySendModel : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("energy_ext_request")]
        public List<EnergyExtRequest> ExtInfo { get; set; }

        /// <summary>
        /// 外部业务号，用作幂等。 自定义传入，同一场景下，一条外部业务号只可消费一次。
        /// </summary>
        [XmlElement("outer_no")]
        public string OuterNo { get; set; }

        /// <summary>
        /// 能量发放场景，如：医院-挂号
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
