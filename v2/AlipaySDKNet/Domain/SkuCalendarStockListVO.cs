using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuCalendarStockListVO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCalendarStockListVO : AopObject
    {
        /// <summary>
        /// 日历价格对象列表，记录一段时间的价格信息
        /// </summary>
        [XmlArray("calendar_stocks")]
        [XmlArrayItem("item_calendar_stock_v_o")]
        public List<ItemCalendarStockVO> CalendarStocks { get; set; }

        /// <summary>
        /// 外部skuId，必须为商家提报商品时自定义填写的商家侧skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
