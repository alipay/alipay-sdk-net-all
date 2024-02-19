using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardInvoicetasktradeBatchqueryResponse.
    /// </summary>
    public class AlipayFundMbpcardInvoicetasktradeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 是否还有下一页，true:有，false:没有
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 发票关联的交易列表信息
        /// </summary>
        [XmlArray("invoice_trade_list")]
        [XmlArrayItem("invoice_task_trade_info")]
        public List<InvoiceTaskTradeInfo> InvoiceTradeList { get; set; }

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
