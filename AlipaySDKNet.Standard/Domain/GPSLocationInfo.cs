using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GPSLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GPSLocationInfo : AopObject
    {
        /// <summary>
        /// 1.0
        /// </summary>
        [XmlElement("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

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
        /// 速度
        /// </summary>
        [XmlElement("speed")]
        public string Speed { get; set; }
    }
}
