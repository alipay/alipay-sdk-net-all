using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanUnclearQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanUnclearQueryResponse : AopResponse
    {
        /// <summary>
        /// 贷款申请预算信息列表
        /// </summary>
        [XmlArray("loan_apply_budget_list")]
        [XmlArrayItem("loan_apply_budget_v_o")]
        public List<LoanApplyBudgetVO> LoanApplyBudgetList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
