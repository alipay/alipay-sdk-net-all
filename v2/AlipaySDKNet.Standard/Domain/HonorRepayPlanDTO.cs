using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorRepayPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorRepayPlanDTO : AopObject
    {
        /// <summary>
        /// 荣耀侧借款申请订单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 预算类型 ADVANCE_REPAY-结清预算 OVD_AND_CURRENT_REPAY-到期逾期预算
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 当前期次
        /// </summary>
        [XmlElement("current_term")]
        public long CurrentTerm { get; set; }

        /// <summary>
        /// 剩余应还总额，单位：分
        /// </summary>
        [XmlElement("duerepay")]
        public string Duerepay { get; set; }

        /// <summary>
        /// 借款金额，单位：分
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 不可还款的toast
        /// </summary>
        [XmlElement("non_repayable_desc")]
        public string NonRepayableDesc { get; set; }

        /// <summary>
        /// 蚂蚁侧借款订单单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 借据逾期未还金额，单位分，有逾期时必传
        /// </summary>
        [XmlElement("overdue_amount")]
        public string OverdueAmount { get; set; }

        /// <summary>
        /// 借据逾期天数，有逾期时必传。
        /// </summary>
        [XmlElement("overdue_days")]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 放款日期,yyyyMMdd
        /// </summary>
        [XmlElement("paydate")]
        public string Paydate { get; set; }

        /// <summary>
        /// 还款计划期次列表 (不含已还期次)
        /// </summary>
        [XmlArray("repay_plan_terms")]
        [XmlArrayItem("honor_repay_plan_term_d_t_o")]
        public List<HonorRepayPlanTermDTO> RepayPlanTerms { get; set; }

        /// <summary>
        /// 可还款状态，2-正常还款中，7-禁还期
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 支持的还款类型列表，不支持还款时返回空列表，6-去还款
        /// </summary>
        [XmlArray("support_repay_type")]
        [XmlArrayItem("number")]
        public List<long> SupportRepayType { get; set; }

        /// <summary>
        /// 借款期数
        /// </summary>
        [XmlElement("total_term")]
        public long TotalTerm { get; set; }
    }
}
