using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrencyVO Data Structure.
    /// </summary>
    [Serializable]
    public class CurrencyVO : AopObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
