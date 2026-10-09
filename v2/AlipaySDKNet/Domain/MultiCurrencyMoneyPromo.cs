using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyPromo Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyPromo : AopObject
    {
        /// <summary>
        /// 钱，分为单位
        /// </summary>
        [XmlElement("cent")]
        public string Cent { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
    }
}
