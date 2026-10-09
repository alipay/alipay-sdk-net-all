using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponse : AopResponse
    {
        /// <summary>
        /// 员工已绑定费控规则列表
        /// </summary>
        [XmlArray("employee_rules")]
        [XmlArrayItem("expense_ctrl_employee_rule_info")]
        public List<ExpenseCtrlEmployeeRuleInfo> EmployeeRules { get; set; }

        /// <summary>
        /// 客户端输入的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 客户端输入的每页行数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询到的实例总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
