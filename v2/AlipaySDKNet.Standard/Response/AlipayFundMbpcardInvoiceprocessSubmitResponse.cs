using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardInvoiceprocessSubmitResponse.
    /// </summary>
    public class AlipayFundMbpcardInvoiceprocessSubmitResponse : AopResponse
    {
        /// <summary>
        /// 发票外部索引信息
        /// </summary>
        [XmlArray("invoice_list")]
        [XmlArrayItem("invoice_out_index_info")]
        public List<InvoiceOutIndexInfo> InvoiceList { get; set; }

        /// <summary>
        /// 流程ID
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 流程状态
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }
    }
}
