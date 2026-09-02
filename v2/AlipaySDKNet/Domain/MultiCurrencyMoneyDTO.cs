using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyDTO : AopObject
    {
        /// <summary>
        /// 金额值，对应类型long，单位为币种最小金额，各币种不同，如CNY为分
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
