using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StockQuantity Data Structure.
    /// </summary>
    [Serializable]
    public class StockQuantity : AopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
