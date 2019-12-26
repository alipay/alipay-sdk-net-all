using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanBudgetQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 贷前还款分期计划列表
        /// </summary>
        [XmlArray("pre_repay_plan_term_list")]
        [XmlArrayItem("pre_repay_plan_term_v_o")]
        public List<PreRepayPlanTermVO> PreRepayPlanTermList { get; set; }

        /// <summary>
        /// 应还总额=应还本金+应还利息
        /// </summary>
        [XmlElement("repay_amt_total")]
        public string RepayAmtTotal { get; set; }

        /// <summary>
        /// 应还利息总额
        /// </summary>
        [XmlElement("repay_int_amt_total")]
        public string RepayIntAmtTotal { get; set; }

        /// <summary>
        /// 应还本金总额
        /// </summary>
        [XmlElement("repay_prin_amt_total")]
        public string RepayPrinAmtTotal { get; set; }
    }
}
