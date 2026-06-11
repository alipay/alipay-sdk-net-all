using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEbikeChargestationsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEbikeChargestationsQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码,高德标准
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 合作方编码
        /// </summary>
        [XmlElement("partner_code")]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 搜索经纬度,高德坐标系
        /// </summary>
        [XmlElement("search_location")]
        public LocationParam SearchLocation { get; set; }

        /// <summary>
        /// 搜索半径，单位：km, 99999是上限，每个合作方上限根据配置有所不同
        /// </summary>
        [XmlElement("search_radius")]
        public long SearchRadius { get; set; }

        /// <summary>
        /// 用户定位经纬度，高德坐标系
        /// </summary>
        [XmlElement("user_location")]
        public LocationParam UserLocation { get; set; }
    }
}
