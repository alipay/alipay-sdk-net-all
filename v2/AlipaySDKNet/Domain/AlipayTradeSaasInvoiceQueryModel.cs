using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasInvoiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasInvoiceQueryModel : AopObject
    {
        /// <summary>
        /// 开票时外部请求单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 查询模式
        /// </summary>
        [XmlElement("query_mode")]
        public string QueryMode { get; set; }

        /// <summary>
        /// saas平台发票申请单号，可以作为发票信息查询的条件
        /// </summary>
        [XmlElement("saas_invoice_order_no")]
        public string SaasInvoiceOrderNo { get; set; }
    }
}
