using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIOuterTaxInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIOuterTaxInfoDetail : AopObject
    {
        /// <summary>
        /// 外部计税传入高精度税金。 需要处理为税金所属币种的最小单位。如人民币需要处理为分，日币需要处理最小单位元
        /// </summary>
        [XmlElement("hd_tax_amount")]
        public string HdTaxAmount { get; set; }

        /// <summary>
        /// 外部计税传入税额
        /// </summary>
        [XmlElement("tax_amount")]
        public MultiCurrencyMoneyOpenApi TaxAmount { get; set; }

        /// <summary>
        /// 外部计税传入税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税种。 支持，增值税：01，营业税：02，消费税：03等等
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }
    }
}
