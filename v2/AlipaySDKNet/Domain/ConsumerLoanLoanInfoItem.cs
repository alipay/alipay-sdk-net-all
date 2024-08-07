using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanLoanInfoItem Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanLoanInfoItem : AopObject
    {
        /// <summary>
        /// 是否可提前还款，true-允许，false-不允许
        /// </summary>
        [XmlElement("allowed_pay_off_early")]
        public bool AllowedPayOffEarly { get; set; }

        /// <summary>
        /// 剩余待还担保费或保险费，单位为分，1000代表10.00元，若无该项费用可填0
        /// </summary>
        [XmlElement("last_insurance_amount")]
        public long LastInsuranceAmount { get; set; }

        /// <summary>
        /// 剩余待还利息，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("last_interest_amount")]
        public long LastInterestAmount { get; set; }

        /// <summary>
        /// 剩余待还罚息，单位为分，1000代表10.00元，若无该项费用可填0
        /// </summary>
        [XmlElement("last_penalty_interest_amount")]
        public long LastPenaltyInterestAmount { get; set; }

        /// <summary>
        /// 剩余期数
        /// </summary>
        [XmlElement("last_period_count")]
        public long LastPeriodCount { get; set; }

        /// <summary>
        /// 剩余待还本金，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("last_principal_amount")]
        public long LastPrincipalAmount { get; set; }

        /// <summary>
        /// 总借款金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("loan_amount")]
        public long LoanAmount { get; set; }

        /// <summary>
        /// 贷款时间
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 借据ID
        /// </summary>
        [XmlElement("loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// 还款方式，包含等额本息（EQUAL），先息后本（NOT_EQUAL）
        /// </summary>
        [XmlElement("repay_method")]
        public string RepayMethod { get; set; }

        /// <summary>
        /// selectType = ALL 默认勾选全部逾期，不可取消 其它可还款还款账单默认不勾选 支持多选 selectType = PART 默认勾选首条逾期，不可取消 勾选逾期账单有次序限制 其它可还款账单默认不勾选 支持多选 selectType = SINGLE 默认勾选首条逾期，不可取消 若没有逾期，其它可还款账单默认勾选首条 支持单选 selectType = UN_LIMIT 不限制
        /// </summary>
        [XmlElement("select_type")]
        public string SelectType { get; set; }

        /// <summary>
        /// 借款记录状态，如果包含有逾期账单，就是逾期，没有就是正常 NORMAL：正常 OVER_DUE：逾期
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
