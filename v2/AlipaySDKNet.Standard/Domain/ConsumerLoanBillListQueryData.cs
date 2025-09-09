using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillListQueryData Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillListQueryData : AopObject
    {
        /// <summary>
        /// 账单信息
        /// </summary>
        [XmlElement("bill_data")]
        public ConsumerLoanBillInfo BillData { get; set; }

        /// <summary>
        /// 不匹配的用户信息
        /// </summary>
        [XmlElement("not_match_data")]
        public ConsumerLoanNotMatchData NotMatchData { get; set; }
    }
}
