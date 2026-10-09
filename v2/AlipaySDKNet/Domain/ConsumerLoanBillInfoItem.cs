using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillInfoItem Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillInfoItem : AopObject
    {
        /// <summary>
        /// 可提前还款的日期，日期格式为YYYY-MM-DD hh:mm:ss
        /// </summary>
        [XmlElement("allowed_pay_off_early_date")]
        public string AllowedPayOffEarlyDate { get; set; }

        /// <summary>
        /// 账单ID
        /// </summary>
        [XmlElement("bill_id")]
        public string BillId { get; set; }

        /// <summary>
        /// 手续费金额，单位为分（如1000代表10.00元）
        /// </summary>
        [XmlElement("commission_amount")]
        public long CommissionAmount { get; set; }

        /// <summary>
        /// 本期还款金额，单位为分，1000代表10.00元，状态为“本期已还”时必填，其余状态选填
        /// </summary>
        [XmlElement("current_period_paid_amount")]
        public long CurrentPeriodPaidAmount { get; set; }

        /// <summary>
        /// 本期账单还清时间，若状态非“本期已结”可不传
        /// </summary>
        [XmlElement("current_period_paid_time")]
        public string CurrentPeriodPaidTime { get; set; }

        /// <summary>
        /// 罚息或违约金，单位为分，1000代表10.00元，若无该项费用填0
        /// </summary>
        [XmlElement("damage_amount")]
        public long DamageAmount { get; set; }

        /// <summary>
        /// 账单出账日，日期格式为YYYY-MM-DD hh:mm:ss，若无出账日概念可不填写
        /// </summary>
        [XmlElement("expanditure_publish_date")]
        public string ExpanditurePublishDate { get; set; }

        /// <summary>
        /// 合同ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 担保费及(或)保险费，单位为分，1000代表10.00元，若无该项费用填0
        /// </summary>
        [XmlElement("insurance_amount")]
        public long InsuranceAmount { get; set; }

        /// <summary>
        /// 单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("interest_amount")]
        public long InterestAmount { get; set; }

        /// <summary>
        /// 该笔账单（账单为按照还款日聚合的还款计划），涉及到的借据笔数
        /// </summary>
        [XmlElement("loan_count")]
        public long LoanCount { get; set; }

        /// <summary>
        /// 单位为分，1000代表10.00元，若无该项费用填0
        /// </summary>
        [XmlElement("penalty_interest_amount")]
        public long PenaltyInterestAmount { get; set; }

        /// <summary>
        /// 单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("principal_amount")]
        public long PrincipalAmount { get; set; }

        /// <summary>
        /// 当前账单和借据的关系
        /// </summary>
        [XmlArray("related_loan_info")]
        [XmlArrayItem("consumer_loan_bill_loan_relation")]
        public List<ConsumerLoanBillLoanRelation> RelatedLoanInfo { get; set; }

        /// <summary>
        /// 单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("repay_amount")]
        public long RepayAmount { get; set; }

        /// <summary>
        /// 账单待还金额，单位为分（1000代表10.00元），不包含手续费，仅包含账单本身金额（如本金、利息、罚息等）
        /// </summary>
        [XmlElement("repay_bill_amount")]
        public long RepayBillAmount { get; set; }

        /// <summary>
        /// 账单还款日，日期格式为YYYY-MM-DD hh:mm:ss
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// selectType = ALL 默认勾选全部逾期，不可取消 其它可还款还款账单默认不勾选 支持多选 selectType = PART 默认勾选首条逾期，不可取消 勾选逾期账单有次序限制 其它可还款账单默认不勾选 支持多选 selectType = SINGLE 默认勾选首条逾期，不可取消 若没有逾期，其它可还款账单默认勾选首条 支持单选 selectType = UN_LIMIT 不限制
        /// </summary>
        [XmlElement("select_type")]
        public string SelectType { get; set; }

        /// <summary>
        /// 账单状态，可根据实际情况填充，如无出账概念可不传未出账和已出账状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
