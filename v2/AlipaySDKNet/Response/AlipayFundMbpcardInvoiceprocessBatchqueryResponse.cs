using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardInvoiceprocessBatchqueryResponse.
    /// </summary>
    public class AlipayFundMbpcardInvoiceprocessBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 回票事件列表
        /// </summary>
        [XmlArray("invoice_event_list")]
        [XmlArrayItem("invoice_event_info")]
        public List<InvoiceEventInfo> InvoiceEventList { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_num")]
        public string TotalNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
