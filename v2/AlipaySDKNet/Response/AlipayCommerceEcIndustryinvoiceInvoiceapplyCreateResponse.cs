using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcIndustryinvoiceInvoiceapplyCreateResponse.
    /// </summary>
    public class AlipayCommerceEcIndustryinvoiceInvoiceapplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 开票申请创建成功的开票申请ID
        /// </summary>
        [XmlElement("invoice_apply_id")]
        public string InvoiceApplyId { get; set; }
    }
}
