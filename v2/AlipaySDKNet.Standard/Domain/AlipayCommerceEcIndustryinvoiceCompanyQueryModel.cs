using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceCompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcIndustryinvoiceCompanyQueryModel : AopObject
    {
        /// <summary>
        /// 企业税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
