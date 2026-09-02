using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardTemplateShopPrice Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardTemplateShopPrice : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("date_price_list")]
        [XmlArrayItem("merchant_card_template_price_date_rule")]
        public List<MerchantCardTemplatePriceDateRule> DatePriceList { get; set; }

        /// <summary>
        /// 门店基础原价，单位为分；如传入，不得小于售价。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 门店基础售价，单位为分。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 当前商户名下的有效门店ID。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_price_list")]
        [XmlArrayItem("merchant_card_template_price_week_rule")]
        public List<MerchantCardTemplatePriceWeekRule> WeekPriceList { get; set; }
    }
}
