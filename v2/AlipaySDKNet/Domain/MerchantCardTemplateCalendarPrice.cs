using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplateCalendarPrice Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplateCalendarPrice : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_price_list")]
        [XmlArrayItem("merchant_card_template_price_date_rule")]
        public List<MerchantCardTemplatePriceDateRule> DatePriceList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_price_list")]
        [XmlArrayItem("merchant_card_template_price_week_rule")]
        public List<MerchantCardTemplatePriceWeekRule> WeekPriceList { get; set; }
    }
}
