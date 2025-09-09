using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ETCTripItemDto Data Structure.
    /// </summary>
    [Serializable]
    public class ETCTripItemDto : AopObject
    {
        /// <summary>
        /// 高速收费站出口
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 用户离开高速时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当前明细费用
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 费用类目
        /// </summary>
        [XmlElement("item_category")]
        public string ItemCategory { get; set; }

        /// <summary>
        /// 外部行程唯一流水号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 高速收费站入口
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 用户进入高速时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
