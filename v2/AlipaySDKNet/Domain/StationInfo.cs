using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StationInfo : AopObject
    {
        /// <summary>
        /// 可扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 站点维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 站点经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 当前站点距离上一站点的距离，单位:米
        /// </summary>
        [XmlElement("station_distance")]
        public long StationDistance { get; set; }

        /// <summary>
        /// 站点id，同一个公交企业应唯一
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点在线路中的序号
        /// </summary>
        [XmlElement("station_index")]
        public long StationIndex { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 站点客流量
        /// </summary>
        [XmlElement("station_volume")]
        public long StationVolume { get; set; }
    }
}
