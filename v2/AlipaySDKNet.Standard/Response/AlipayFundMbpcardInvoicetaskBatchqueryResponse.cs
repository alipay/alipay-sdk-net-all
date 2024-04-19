using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardInvoicetaskBatchqueryResponse.
    /// </summary>
    public class AlipayFundMbpcardInvoicetaskBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 是否存在下一页，true:存在 false:不存在
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 回票任务详情信息
        /// </summary>
        [XmlArray("invoice_task_list")]
        [XmlArrayItem("invoice_task_info")]
        public List<InvoiceTaskInfo> InvoiceTaskList { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 已回票总金额，单位为元
        /// </summary>
        [XmlElement("total_finish_invoice_amount")]
        public string TotalFinishInvoiceAmount { get; set; }

        /// <summary>
        /// 应回票总金额，单位为元
        /// </summary>
        [XmlElement("total_invoice_amount")]
        public string TotalInvoiceAmount { get; set; }

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
