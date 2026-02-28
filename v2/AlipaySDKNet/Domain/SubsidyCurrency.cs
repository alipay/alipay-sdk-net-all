using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubsidyCurrency Data Structure.
    /// </summary>
    [Serializable]
    public class SubsidyCurrency : AopObject
    {
        /// <summary>
        /// 该货币的ISO 4217货币代码。
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 该货币的默认小数位数。根据货币数据表设置。
        /// </summary>
        [XmlElement("default_fraction_digits")]
        public long DefaultFractionDigits { get; set; }

        /// <summary>
        /// 该货币的ISO 4217数字代码。根据货币数据表设置。
        /// </summary>
        [XmlElement("numeric_code")]
        public long NumericCode { get; set; }
    }
}
