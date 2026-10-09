using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanBillLoanRelation Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanBillLoanRelation : AopObject
    {
        /// <summary>
        /// 机构借据号
        /// </summary>
        [XmlElement("loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// 当前账单在对应借据里的期号
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }
    }
}
