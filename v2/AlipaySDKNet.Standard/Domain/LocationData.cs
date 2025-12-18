using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocationData Data Structure.
    /// </summary>
    [Serializable]
    public class LocationData : AopObject
    {
        /// <summary>
        /// 0-宽松，1-较拥挤，2-非常拥挤，3-不宜进入
        /// </summary>
        [XmlElement("crowding_level")]
        public long CrowdingLevel { get; set; }

        /// <summary>
        /// 子景点ID
        /// </summary>
        [XmlElement("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// 子景点名称
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 地点类型
        /// </summary>
        [XmlElement("location_type")]
        public string LocationType { get; set; }

        /// <summary>
        /// 当日累计访问人数
        /// </summary>
        [XmlElement("max_capacity")]
        public long MaxCapacity { get; set; }

        /// <summary>
        /// 当日累计访问人数
        /// </summary>
        [XmlElement("visitor_day_count")]
        public long VisitorDayCount { get; set; }

        /// <summary>
        /// 访客实时人数
        /// </summary>
        [XmlElement("visitor_real_count")]
        public long VisitorRealCount { get; set; }

        /// <summary>
        /// 访客实时时间数据
        /// </summary>
        [XmlElement("visitor_real_time")]
        public string VisitorRealTime { get; set; }
    }
}
