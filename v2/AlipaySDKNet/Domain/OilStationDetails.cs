using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OilStationDetails Data Structure.
    /// </summary>
    [Serializable]
    public class OilStationDetails : AopObject
    {
        /// <summary>
        /// 油站详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 直降金额
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 油站名称
        /// </summary>
        [XmlElement("oil_station_name")]
        public string OilStationName { get; set; }

        /// <summary>
        /// 油品
        /// </summary>
        [XmlElement("oil_type")]
        public string OilType { get; set; }

        /// <summary>
        /// 高德 poi_id
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 油价，以元为单位
        /// </summary>
        [XmlElement("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 油站门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
