using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardInvoiceprocessQueryResponse.
    /// </summary>
    public class AlipayFundMbpcardInvoiceprocessQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票审核列表
        /// </summary>
        [XmlArray("invoice_list")]
        [XmlArrayItem("invoice_audit_info")]
        public List<InvoiceAuditInfo> InvoiceList { get; set; }

        /// <summary>
        /// 回票处理流程id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 回票处理流程状态
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }
    }
}
