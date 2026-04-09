using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeserviceItemCalendarPrice Data Structure.
    /// </summary>
    [Serializable]
    public class LifeserviceItemCalendarPrice : AopObject
    {
        /// <summary>
        /// 按日期定价。如果和星期定价冲突，以日期定价为准。
        /// </summary>
        [XmlArray("date_price_list")]
        [XmlArrayItem("lifeservice_item_date_price")]
        public List<LifeserviceItemDatePrice> DatePriceList { get; set; }

        /// <summary>
        /// 基础原价，单位分。日历价未覆盖的日期兜底取当前值
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 基础售价，单位分。日历价未覆盖到的日期兜底取当前值
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 按星期x定价。如果和日期定价冲突，以日期定价为准。
        /// </summary>
        [XmlArray("week_price_list")]
        [XmlArrayItem("lifeservice_item_week_price")]
        public List<LifeserviceItemWeekPrice> WeekPriceList { get; set; }
    }
}
