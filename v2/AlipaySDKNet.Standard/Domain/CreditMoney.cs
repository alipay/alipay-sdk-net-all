using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditMoney Data Structure.
    /// </summary>
    [Serializable]
    public class CreditMoney : AopObject
    {
        /// <summary>
        /// 金额-分
        /// </summary>
        [XmlElement("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
