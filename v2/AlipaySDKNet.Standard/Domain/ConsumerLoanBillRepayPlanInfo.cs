using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillRepayPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillRepayPlanInfo : AopObject
    {
        /// <summary>
        /// 剩余还款期数
        /// </summary>
        [XmlElement("last_period_count")]
        public long LastPeriodCount { get; set; }

        /// <summary>
        /// 消费贷还款账单还款计划详情
        /// </summary>
        [XmlArray("repay_plan_record")]
        [XmlArrayItem("consumer_loan_bill_repay_plan_info_item")]
        public List<ConsumerLoanBillRepayPlanInfoItem> RepayPlanRecord { get; set; }
    }
}
