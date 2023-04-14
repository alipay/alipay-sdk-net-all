using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单凭证关联信息
        /// </summary>
        [XmlElement("expense_ctrl_consume_info")]
        public ExpenseCtrlConsumeInfo ExpenseCtrlConsumeInfo { get; set; }
    }
}
