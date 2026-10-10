using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplateTechnicianPrice Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplateTechnicianPrice : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_price_list")]
        [XmlArrayItem("merchant_card_template_price_date")]
        public List<MerchantCardTemplatePriceDate> DatePriceList { get; set; }

        /// <summary>
        /// 手艺人基础原价，单位为分；如传入，不得小于售价。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 手艺人基础售价，单位为分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 手艺人ID
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_price_list")]
        [XmlArrayItem("merchant_card_template_price_week")]
        public List<MerchantCardTemplatePriceWeek> WeekPriceList { get; set; }
    }
}
