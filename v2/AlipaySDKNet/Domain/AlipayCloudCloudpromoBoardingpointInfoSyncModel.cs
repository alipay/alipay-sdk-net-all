using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoBoardingpointInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoBoardingpointInfoSyncModel : AopObject
    {
        /// <summary>
        /// 1号上车点
        /// </summary>
        [XmlElement("boarding_point_name")]
        public string BoardingPointName { get; set; }

        /// <summary>
        /// 舒适
        /// </summary>
        [XmlElement("comfort_level")]
        public string ComfortLevel { get; set; }

        /// <summary>
        /// 1楼
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 杭州东站
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 位置ID，用于区分不同poi点位的唯一值
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 出租车
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 等候人数，单位：人，5000人
        /// </summary>
        [XmlElement("wait_people_number")]
        public long WaitPeopleNumber { get; set; }

        /// <summary>
        /// 等待时间，整型，单位：分钟
        /// </summary>
        [XmlElement("wait_time")]
        public long WaitTime { get; set; }
    }
}
