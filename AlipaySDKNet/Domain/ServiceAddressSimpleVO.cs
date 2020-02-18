using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceAddressSimpleVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceAddressSimpleVO : AopObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// poi详细地址
        /// </summary>
        [XmlElement("poi_address")]
        public string PoiAddress { get; set; }

        /// <summary>
        /// 高德的poi code
        /// </summary>
        [XmlElement("poi_code")]
        public string PoiCode { get; set; }

        /// <summary>
        /// poi的名称
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }
    }
}
