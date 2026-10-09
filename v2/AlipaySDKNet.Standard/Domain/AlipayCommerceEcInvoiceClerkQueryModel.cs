using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceClerkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceClerkQueryModel : AopObject
    {
        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
