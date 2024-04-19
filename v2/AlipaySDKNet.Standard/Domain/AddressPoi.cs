using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddressPoi Data Structure.
    /// </summary>
    [Serializable]
    public class AddressPoi : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("county_code")]
        public string CountyCode { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 位置id
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }
    }
}
