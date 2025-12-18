using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StationLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StationLocationInfo : AopObject
    {
        /// <summary>
        /// 站点纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 站点经度
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 站点Id
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }
    }
}
