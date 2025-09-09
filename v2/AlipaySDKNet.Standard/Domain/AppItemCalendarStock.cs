using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemCalendarStock Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemCalendarStock : AopObject
    {
        /// <summary>
        /// 库存的有效开始日期。 等于或晚于当前日期且在120天内(即不接收120天后的数据) 。格式：yyyy-MM-dd 如2023-09-26
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 目前支持库存区间0~99999
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }
    }
}
