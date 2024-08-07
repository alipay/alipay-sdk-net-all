using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanLoanRepayPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanLoanRepayPlanInfo : AopObject
    {
        /// <summary>
        /// 剩余还款期数
        /// </summary>
        [XmlElement("last_period_count")]
        public long LastPeriodCount { get; set; }

        /// <summary>
        /// 剩余待还本金，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("last_principal_amount")]
        public long LastPrincipalAmount { get; set; }

        /// <summary>
        /// 借据金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("loan_amount")]
        public long LoanAmount { get; set; }

        /// <summary>
        /// 贷款日期
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 所属借据ID
        /// </summary>
        [XmlElement("loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// 还款方式，包含等额本息（EQUAL），先息后本（NOT_EQUAL）
        /// </summary>
        [XmlElement("repay_method")]
        public string RepayMethod { get; set; }

        /// <summary>
        /// 借据还款计划详情列表
        /// </summary>
        [XmlArray("repay_plan_record")]
        [XmlArrayItem("consumer_loan_loan_repay_plan_info_item")]
        public List<ConsumerLoanLoanRepayPlanInfoItem> RepayPlanRecord { get; set; }

        /// <summary>
        /// 总还款期数
        /// </summary>
        [XmlElement("total_period_count")]
        public long TotalPeriodCount { get; set; }
    }
}
