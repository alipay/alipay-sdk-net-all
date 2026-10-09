using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanRepayPlanQueryData Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanRepayPlanQueryData : AopObject
    {
        /// <summary>
        /// 还款计划信息
        /// </summary>
        [XmlElement("bill_data")]
        public ConsumerLoanLoanRepayPlanInfo BillData { get; set; }

        /// <summary>
        /// 不匹配的用户信息
        /// </summary>
        [XmlElement("not_match_data")]
        public ConsumerLoanNotMatchData NotMatchData { get; set; }
    }
}
