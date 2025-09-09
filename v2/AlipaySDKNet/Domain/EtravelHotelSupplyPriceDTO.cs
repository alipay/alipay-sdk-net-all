using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtravelHotelSupplyPriceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EtravelHotelSupplyPriceDTO : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 默认CNY
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
