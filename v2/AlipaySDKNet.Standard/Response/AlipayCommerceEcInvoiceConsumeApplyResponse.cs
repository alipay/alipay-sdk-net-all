using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcInvoiceConsumeApplyResponse.
    /// </summary>
    public class AlipayCommerceEcInvoiceConsumeApplyResponse : AopResponse
    {
        /// <summary>
        /// 开票申请创建成功的开票申请id
        /// </summary>
        [XmlElement("invoice_apply_id")]
        public string InvoiceApplyId { get; set; }
    }
}
