using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplateRegionPrice Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplateRegionPrice : AopObject
    {
        /// <summary>
        /// 市级行政区划码，与省、区编码三选一。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_price_list")]
        [XmlArrayItem("merchant_card_template_price_date_rule")]
        public List<MerchantCardTemplatePriceDateRule> DatePriceList { get; set; }

        /// <summary>
        /// 区级行政区划码，与省、市编码三选一。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区域基础原价，单位为分；如传入，不得小于售价。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 省级行政区划码，与市、区编码三选一。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 区域基础售价，单位为分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_price_list")]
        [XmlArrayItem("merchant_card_template_price_week_rule")]
        public List<MerchantCardTemplatePriceWeekRule> WeekPriceList { get; set; }
    }
}
