using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemSkuCalendarStock Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemSkuCalendarStock : AopObject
    {
        /// <summary>
        /// 日历库存对象列表，记录一段时间的库存信息
        /// </summary>
        [XmlArray("calendar_stocks")]
        [XmlArrayItem("app_item_calendar_stock")]
        public List<AppItemCalendarStock> CalendarStocks { get; set; }

        /// <summary>
        /// 商家侧sku ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
