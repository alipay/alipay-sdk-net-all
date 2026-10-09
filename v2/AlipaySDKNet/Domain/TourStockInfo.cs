using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourStockInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TourStockInfo : AopObject
    {
        /// <summary>
        /// 库存日期，格式为YYYY-MM-DD
        /// </summary>
        [XmlElement("stock_date")]
        public string StockDate { get; set; }

        /// <summary>
        /// 库存状态，值为EMPTY时，表示要清空指定日期的库存状态
        /// </summary>
        [XmlElement("stock_status")]
        public string StockStatus { get; set; }
    }
}
