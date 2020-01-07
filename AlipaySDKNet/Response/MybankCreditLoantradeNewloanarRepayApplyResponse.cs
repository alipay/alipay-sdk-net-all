using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeNewloanarRepayApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeNewloanarRepayApplyResponse : AopResponse
    {
        /// <summary>
        /// 受理事件编号
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
