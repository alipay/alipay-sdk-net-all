using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiCurrencyMoney Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoney : AopObject
    {
        /// <summary>
        /// 金额，默认单位是人民币，精确到小数点两位..
        /// </summary>
        [XmlElement("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
