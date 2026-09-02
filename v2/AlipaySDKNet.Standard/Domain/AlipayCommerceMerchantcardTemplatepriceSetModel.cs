using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatepriceSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplatepriceSetModel : AopObject
    {
        /// <summary>
        /// 普通日历价配置，至少包含一条星期固定价或日期固定价。
        /// </summary>
        [XmlElement("calendar_price")]
        public MerchantCardTemplateCalendarPrice CalendarPrice { get; set; }

        /// <summary>
        /// 需要设置动态价格的商品模板ID。
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("region_price_list")]
        [XmlArrayItem("merchant_card_template_region_price")]
        public List<MerchantCardTemplateRegionPrice> RegionPriceList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_price_list")]
        [XmlArrayItem("merchant_card_template_shop_price")]
        public List<MerchantCardTemplateShopPrice> ShopPriceList { get; set; }
    }
}
