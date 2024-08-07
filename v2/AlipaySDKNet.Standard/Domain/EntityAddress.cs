using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EntityAddress Data Structure.
    /// </summary>
    [Serializable]
    public class EntityAddress : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 省市辖区的区域代码，参考GB/T 2260- 2007
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家，不传默认中国
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 国家编码，不传默认CN-中国
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 纬度，GCJ-02坐标系，保留数点后6位。。单位度(°)
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，GCJ-02坐标系，保留数点后6位。单位度(°)
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
