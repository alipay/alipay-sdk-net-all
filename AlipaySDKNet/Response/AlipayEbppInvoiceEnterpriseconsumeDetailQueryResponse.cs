using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单信息
        /// </summary>
        [XmlElement("expense_consume_info")]
        public ExpenseConsumeInfo ExpenseConsumeInfo { get; set; }

        /// <summary>
        /// 发票凭证结构化数据
        /// </summary>
        [XmlElement("expense_invoice_info")]
        public ExpenseInvoiceInfo ExpenseInvoiceInfo { get; set; }

        /// <summary>
        /// 凭证基础信息
        /// </summary>
        [XmlElement("voucher_info")]
        public ExpenseVoucherInfo VoucherInfo { get; set; }
    }
}
