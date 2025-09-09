using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanLoanListQueryData Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanLoanListQueryData : AopObject
    {
        /// <summary>
        /// 消费贷还款借据信息
        /// </summary>
        [XmlElement("bill_data")]
        public ConsumerLoanLoanInfo BillData { get; set; }

        /// <summary>
        /// 不匹配的用户信息
        /// </summary>
        [XmlElement("not_match_data")]
        public ConsumerLoanNotMatchData NotMatchData { get; set; }
    }
}
