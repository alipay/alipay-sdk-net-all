using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportData Data Structure.
    /// </summary>
    [Serializable]
    public class ReportData : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 线路编码
        /// </summary>
        [XmlElement("line_code")]
        public string LineCode { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 播放次数
        /// </summary>
        [XmlElement("pv")]
        public long Pv { get; set; }

        /// <summary>
        /// 触达人数
        /// </summary>
        [XmlElement("uv")]
        public long Uv { get; set; }
    }
}
