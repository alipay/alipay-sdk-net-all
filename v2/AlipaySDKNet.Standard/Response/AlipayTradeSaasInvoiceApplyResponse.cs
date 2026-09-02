using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasInvoiceApplyResponse.
    /// </summary>
    public class AlipayTradeSaasInvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 开票状态： 开票成功:SUCCESS 开票失败:FAILED 开票受理中:SUBMIT
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// saas平台发票申请单号，可以作为后续发票信息查询的依据
        /// </summary>
        [XmlElement("saas_invoice_order_no")]
        public string SaasInvoiceOrderNo { get; set; }
    }
}
