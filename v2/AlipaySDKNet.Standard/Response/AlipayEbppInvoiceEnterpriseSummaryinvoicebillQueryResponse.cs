using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseSummaryinvoicebillQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseSummaryinvoicebillQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页行数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("summary_invoice_bill_list")]
        [XmlArrayItem("summary_invoice_bill_open_d_t_o")]
        public List<SummaryInvoiceBillOpenDTO> SummaryInvoiceBillList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
