using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AddressInfoDTO : AopObject
    {
        /// <summary>
        /// 共同账户id和enterprise_id二选一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 市(国家统一行政规划编码)
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 小区/楼宇
        /// </summary>
        [XmlElement("community")]
        public string Community { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

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
        /// 备注
        /// </summary>
        [XmlElement("mark")]
        public string Mark { get; set; }

        /// <summary>
        /// 地图poi
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }
    }
}
