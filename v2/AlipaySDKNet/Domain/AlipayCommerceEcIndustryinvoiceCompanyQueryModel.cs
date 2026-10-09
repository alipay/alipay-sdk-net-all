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

        /// <summary>
        /// 是否更新税务信息，默认 false。 为 true会先同步税务信息后，返回最新的税务信息
        /// </summary>
        [XmlElement("update_tax_info")]
        public bool UpdateTaxInfo { get; set; }
    }
}
