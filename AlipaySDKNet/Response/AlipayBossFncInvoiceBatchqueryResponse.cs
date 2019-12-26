using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 发票总金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_page")]
        public long ItemsPage { get; set; }

        /// <summary>
        /// 结果对象,发票对象的集合
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ar_invoice_open_api_response")]
        public List<ArInvoiceOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 查询到的结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
