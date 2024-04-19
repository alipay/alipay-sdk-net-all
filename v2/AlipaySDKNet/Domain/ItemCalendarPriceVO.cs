using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCalendarPriceVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCalendarPriceVO : AopObject
    {
        /// <summary>
        /// 价格的有效截止日期。 等于或晚于当前日期且在365天内(即不接收365天后的数据) ，有效开始日期和有效结束日期之间的间隔最大为60天。格式：yyyy-MM-dd 如2023-09-26
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 日历中排除某些日期，如["2023-10-01","2023-10-02","2023-10-03"]
        /// </summary>
        [XmlArray("exclude_dates")]
        [XmlArrayItem("string")]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// 原价，单位:分，为非负数。为空则不创建或更新。
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位:分，为非负数。为空则不创建或更新。
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 价格的有效开始日期。 等于或晚于当前日期且在365天内(即不接收365天后的数据)， 有效开始日期和有效结束日期之间的间隔最大为60天。格式：yyyy-MM-dd 如2023-09-26
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 价格的状态，1:有效/0:删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
