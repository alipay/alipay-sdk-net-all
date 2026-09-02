using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LbsVO Data Structure.
    /// </summary>
    [Serializable]
    public class LbsVO : AopObject
    {
        /// <summary>
        /// 纬度（单位：度，WGS84 坐标系，字符串形式）。
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度（单位：度，WGS84 坐标系，字符串形式）。
        /// </summary>
        [XmlElement("lng")]
        public string Lng { get; set; }
    }
}
