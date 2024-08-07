using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillSumQueryData Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillSumQueryData : AopObject
    {
        /// <summary>
        /// 消费贷还款账单聚合信息
        /// </summary>
        [XmlElement("bill_data")]
        public ConsumerLoanBillAggInfo BillData { get; set; }

        /// <summary>
        /// 不匹配的用户信息
        /// </summary>
        [XmlElement("not_match_data")]
        public ConsumerLoanNotMatchData NotMatchData { get; set; }
    }
}
