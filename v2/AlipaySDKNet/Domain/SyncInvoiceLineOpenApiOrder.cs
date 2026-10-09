using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncInvoiceLineOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SyncInvoiceLineOpenApiOrder : AopObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public string TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
