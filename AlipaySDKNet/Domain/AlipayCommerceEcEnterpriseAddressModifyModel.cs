using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAddressModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseAddressModifyModel : AopObject
    {
        /// <summary>
        /// 共同账户id和enterprise_id二选一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 详细地址最长50个字符
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 协议号，如果填共同账户id，则该字段必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 市(国家统一行政规划编码)
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 小区/楼宇
        /// </summary>
        [XmlElement("community")]
        public string Community { get; set; }

        /// <summary>
        /// 企业id和account_id二选一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

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
        /// 备注
        /// </summary>
        [XmlElement("mark")]
        public string Mark { get; set; }

        /// <summary>
        /// 高德地图poi
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 状态(生效/失效) NORMAL INVALID
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
