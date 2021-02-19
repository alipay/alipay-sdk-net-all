using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JourneyLocation Data Structure.
    /// </summary>
    [Serializable]
    public class JourneyLocation : AopObject
    {
        /// <summary>
        /// 支付宝域内aoiId
        /// </summary>
        [XmlElement("aoi_id")]
        public string AoiId { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 支付宝侧地点id
        /// </summary>
        [XmlElement("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// 地点id类型
        /// </summary>
        [XmlElement("location_id_type")]
        public string LocationIdType { get; set; }

        /// <summary>
        /// 商户侧行政区划代码
        /// </summary>
        [XmlElement("merchant_division_id")]
        public string MerchantDivisionId { get; set; }

        /// <summary>
        /// (废弃)商户侧地点id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户侧poi信息
        /// </summary>
        [XmlElement("merchant_poi")]
        public string MerchantPoi { get; set; }

        /// <summary>
        /// 地点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝域内poiId
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }
    }
}
