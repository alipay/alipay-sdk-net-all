using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantShopAddress Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantShopAddress : AopObject
    {
        /// <summary>
        /// 城市(2022Q2版本)
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区(2022Q2版本)
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

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
        /// 省份(2022Q2版本)
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
