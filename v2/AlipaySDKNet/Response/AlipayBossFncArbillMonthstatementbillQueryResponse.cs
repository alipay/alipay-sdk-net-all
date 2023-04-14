using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncArbillMonthstatementbillQueryResponse.
    /// </summary>
    public class AlipayBossFncArbillMonthstatementbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_page")]
        public string ItemsPage { get; set; }

        /// <summary>
        /// 对账单开放平台返回结果
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("ar_monthly_statement_bill_open_api_response")]
        public List<ArMonthlyStatementBillOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 汇总服务费总调整金额
        /// </summary>
        [XmlElement("total_adj_amt")]
        public MultiCurrencyMoneyOpenApi TotalAdjAmt { get; set; }

        /// <summary>
        /// 汇总服务费总金额
        /// </summary>
        [XmlElement("total_bill_amt")]
        public MultiCurrencyMoneyOpenApi TotalBillAmt { get; set; }

        /// <summary>
        /// 汇总可开票总金额
        /// </summary>
        [XmlElement("total_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvAmt { get; set; }

        /// <summary>
        /// 汇总已开票总金额
        /// </summary>
        [XmlElement("total_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvedAmt { get; set; }

        /// <summary>
        /// 查询到的结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 汇总已关联票总金额
        /// </summary>
        [XmlElement("total_link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi TotalLinkInvoiceAmt { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 对账单开放平台查询返回结果
        /// </summary>
        [XmlElement("total_received_amt")]
        public MultiCurrencyMoneyOpenApi TotalReceivedAmt { get; set; }
    }
}
