using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RateCurrency Data Structure.
    /// </summary>
    [Serializable]
    public class RateCurrency : AopObject
    {
        /// <summary>
        /// 货币编码，ISO标准alpha-3币种编码
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 币种中文名称
        /// </summary>
        [XmlElement("currency_chinese_name")]
        public string CurrencyChineseName { get; set; }

        /// <summary>
        /// 币种图标
        /// </summary>
        [XmlElement("currency_icon")]
        public string CurrencyIcon { get; set; }
    }
}
