using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopAreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopAreaInfo : AopObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
