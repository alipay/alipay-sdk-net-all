using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterApplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 受理状态
        /// </summary>
        [XmlElement("accept_result")]
        public string AcceptResult { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
