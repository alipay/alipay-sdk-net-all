using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillInfo : AopObject
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("consumer_loan_bill_info_item")]
        public List<ConsumerLoanBillInfoItem> BillList { get; set; }

        /// <summary>
        /// 借据信息
        /// </summary>
        [XmlElement("loan_info")]
        public ConsumerLoanLoanInfo LoanInfo { get; set; }

        /// <summary>
        /// 待还款期数，单位：笔
        /// </summary>
        [XmlElement("period_count")]
        public long PeriodCount { get; set; }

        /// <summary>
        /// 还款金额，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("repay_amount")]
        public long RepayAmount { get; set; }

        /// <summary>
        /// 消费贷还款账单还款计划
        /// </summary>
        [XmlElement("repay_plan")]
        public ConsumerLoanBillRepayPlanInfo RepayPlan { get; set; }
    }
}
