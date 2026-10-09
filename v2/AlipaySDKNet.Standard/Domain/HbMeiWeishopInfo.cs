using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbMeiWeishopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HbMeiWeishopInfo : AopObject
    {
        /// <summary>
        /// 所在城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 所在城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 门店logo地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 平均金额,单位为分
        /// </summary>
        [XmlElement("pirce_per_avg_shop")]
        public long PircePerAvgShop { get; set; }

        /// <summary>
        /// 商圈信息
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// 所在省份code
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 商家经纬度地址
        /// </summary>
        [XmlElement("shop_gis")]
        public string ShopGis { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家星级
        /// </summary>
        [XmlElement("star_rate_shop")]
        public string StarRateShop { get; set; }

        /// <summary>
        /// 1代表有效，0代表无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
