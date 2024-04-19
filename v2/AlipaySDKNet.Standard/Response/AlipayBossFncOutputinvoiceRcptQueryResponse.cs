using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceRcptQueryResponse.
    /// </summary>
    public class AlipayBossFncOutputinvoiceRcptQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_page")]
        public string ItemsPage { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("output_invoice_receipt_open_api_response")]
        public List<OutputInvoiceReceiptOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 总条数
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
