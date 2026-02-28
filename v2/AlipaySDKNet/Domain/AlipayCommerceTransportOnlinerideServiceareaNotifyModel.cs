using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOnlinerideServiceareaNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOnlinerideServiceareaNotifyModel : AopObject
    {
        /// <summary>
        /// 变更动作，1:启用 2:停运
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 停运原因,动作为停运时必填
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("region_id")]
        public string RegionId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("time_ranges")]
        [XmlArrayItem("robo_downtime_info")]
        public List<RoboDowntimeInfo> TimeRanges { get; set; }
    }
}
