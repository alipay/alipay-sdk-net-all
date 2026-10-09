using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopDataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ShopDataDetail : AopObject
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
        /// 高德poi或蚂蚁poi等，有则传，用于精准匹配，可扩展其他poi
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店得分结果
        /// </summary>
        [XmlElement("shop_score_result")]
        public ShopScoreResultInfo ShopScoreResult { get; set; }
    }
}
