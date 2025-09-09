using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtravelHotelSupplyDayPrice Data Structure.
    /// </summary>
    [Serializable]
    public class EtravelHotelSupplyDayPrice : AopObject
    {
        /// <summary>
        /// 日期，格式：yyyy-MM-DD 如：2024-01-01
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 最终价格
        /// </summary>
        [XmlElement("price")]
        public EtravelHotelSupplyPriceDTO Price { get; set; }
    }
}
