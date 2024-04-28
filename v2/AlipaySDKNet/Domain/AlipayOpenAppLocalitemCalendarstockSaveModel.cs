using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemCalendarstockSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemCalendarstockSaveModel : AopObject
    {
        /// <summary>
        /// 日历库存列表（商品维度），库存设置的总天数不得大于60天
        /// </summary>
        [XmlArray("calendar_stocks")]
        [XmlArrayItem("item_calendar_stock_v_o")]
        public List<ItemCalendarStockVO> CalendarStocks { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。该字段特殊可选，与out_item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。该字段特殊可选，与item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 日历库存列表（sku维度），库存设置的总天数不得大于60天。
        /// </summary>
        [XmlArray("sku_calendar_stocks")]
        [XmlArrayItem("sku_calendar_stock_list_v_o")]
        public List<SkuCalendarStockListVO> SkuCalendarStocks { get; set; }
    }
}
