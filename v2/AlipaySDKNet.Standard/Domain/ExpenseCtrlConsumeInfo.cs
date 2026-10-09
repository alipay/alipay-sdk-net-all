using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseCtrlConsumeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseCtrlConsumeInfo : AopObject
    {
        /// <summary>
        /// 账单基本信息
        /// </summary>
        [XmlElement("expense_consume_info")]
        public ExpenseConsumeInfo ExpenseConsumeInfo { get; set; }

        /// <summary>
        /// 关联凑票账单列表（开票限额，多次消费后合并开票）
        /// </summary>
        [XmlArray("related_enterprise_consume_list")]
        [XmlArrayItem("expense_consume_info")]
        public List<ExpenseConsumeInfo> RelatedEnterpriseConsumeList { get; set; }

        /// <summary>
        /// 关联发票凭证对象
        /// </summary>
        [XmlArray("related_enterprise_invoice_list")]
        [XmlArrayItem("expense_invoice_info")]
        public List<ExpenseInvoiceInfo> RelatedEnterpriseInvoiceList { get; set; }
    }
}
