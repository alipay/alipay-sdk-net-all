using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceTaxcategoryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceTaxcategoryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
