using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeRepayCustApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeRepayCustApplyResponse : AopResponse
    {
        /// <summary>
        /// 受理事件编号
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 贷款合约编号
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
