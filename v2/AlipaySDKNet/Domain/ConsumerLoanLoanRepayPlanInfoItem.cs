using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanLoanRepayPlanInfoItem Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanLoanRepayPlanInfoItem : AopObject
    {
        /// <summary>
        /// 担保费或保险费，单位为分，1000代表10.00元，若无该项费用可填0
        /// </summary>
        [XmlElement("insurance_amount")]
        public long InsuranceAmount { get; set; }

        /// <summary>
        /// 利息，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("interest_amount")]
        public long InterestAmount { get; set; }

        /// <summary>
        /// 罚息，单位为分，1000代表10.00元，若无该项费用可填0
        /// </summary>
        [XmlElement("penalty_interest_amount")]
        public long PenaltyInterestAmount { get; set; }

        /// <summary>
        /// 还款计划周期数
        /// </summary>
        [XmlElement("period_number")]
        public long PeriodNumber { get; set; }

        /// <summary>
        /// 本金，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("principal_amount")]
        public long PrincipalAmount { get; set; }

        /// <summary>
        /// 还款金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("repay_amount")]
        public long RepayAmount { get; set; }

        /// <summary>
        /// 还款日期（YYYY-MM-DD hh:mm:ss）
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// 还款计划状态，包含逾期（OVER_DUE）或正常（NORMAL）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
