using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StationVO Data Structure.
    /// </summary>
    [Serializable]
    public class StationVO : AopObject
    {
        /// <summary>
        /// 跨线路的全局站点编码（换乘站不同线路同站编码一致）。
        /// </summary>
        [XmlElement("global_station_code")]
        public string GlobalStationCode { get; set; }

        /// <summary>
        /// 站点中文名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 站点在线路上的序号（字符串形式）。
        /// </summary>
        [XmlElement("order")]
        public string Order { get; set; }

        /// <summary>
        /// 站点编码
        /// </summary>
        [XmlElement("station_code")]
        public string StationCode { get; set; }
    }
}
