using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceInvoiceapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcIndustryinvoiceInvoiceapplyQueryModel : AopObject
    {
        /// <summary>
        /// 开票申请ID
        /// </summary>
        [XmlElement("invoice_apply_id")]
        public string InvoiceApplyId { get; set; }

        /// <summary>
        /// 外部开票申请ID
        /// </summary>
        [XmlElement("outer_apply_id")]
        public string OuterApplyId { get; set; }

        /// <summary>
        /// 发票产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
