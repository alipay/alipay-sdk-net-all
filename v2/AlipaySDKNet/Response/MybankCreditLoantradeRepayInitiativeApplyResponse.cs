using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeRepayInitiativeApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeRepayInitiativeApplyResponse : AopResponse
    {
        /// <summary>
        /// 受理事件单编号。
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
