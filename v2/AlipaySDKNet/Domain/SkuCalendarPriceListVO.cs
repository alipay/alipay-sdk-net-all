using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCalendarPriceListVO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCalendarPriceListVO : AopObject
    {
        /// <summary>
        /// 日历价格对象列表，用于描述一段时间的价格
        /// </summary>
        [XmlArray("calendar_prices")]
        [XmlArrayItem("item_calendar_price_v_o")]
        public List<ItemCalendarPriceVO> CalendarPrices { get; set; }

        /// <summary>
        /// 商家侧skuId,必须是商家提报商品时所填的商家侧skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
