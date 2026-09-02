using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EffectBusStationObject Data Structure.
    /// </summary>
    [Serializable]
    public class EffectBusStationObject : AopObject
    {
        /// <summary>
        /// 影响类型: 吸引量(rise)或流失量(fail)
        /// </summary>
        [XmlElement("impact_type")]
        public string ImpactType { get; set; }

        /// <summary>
        /// 客流量，单位：人次
        /// </summary>
        [XmlElement("passenger_volume")]
        public string PassengerVolume { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }
    }
}
