using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanarCreateResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanarCreateResponse : AopResponse
    {
        /// <summary>
        /// 事件流水号
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 贷款合约号
        /// </summary>
        [XmlElement("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
