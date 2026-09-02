using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplatePriceItem Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplatePriceItem : AopObject
    {
        /// <summary>
        /// 市级区域价对应的行政区划码。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_price_list")]
        [XmlArrayItem("merchant_card_template_price_date_rule_v_o")]
        public List<MerchantCardTemplatePriceDateRuleVO> DatePriceList { get; set; }

        /// <summary>
        /// 区级区域价对应的行政区划码。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 基础原价，单位为分。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 动态价格模式：2为普通日历价，3为区域价，4为门店价。
        /// </summary>
        [XmlElement("price_mode")]
        public string PriceMode { get; set; }

        /// <summary>
        /// 省级区域价对应的行政区划码。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 区域价的行政区划层级。
        /// </summary>
        [XmlElement("region_level")]
        public string RegionLevel { get; set; }

        /// <summary>
        /// 基础售价，单位为分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 门店价对应的门店ID。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_price_list")]
        [XmlArrayItem("merchant_card_template_price_week_rule_v_o")]
        public List<MerchantCardTemplatePriceWeekRuleVO> WeekPriceList { get; set; }
    }
}
