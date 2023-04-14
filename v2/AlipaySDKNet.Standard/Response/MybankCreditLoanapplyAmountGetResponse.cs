using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyAmountGetResponse.
    /// </summary>
    public class MybankCreditLoanapplyAmountGetResponse : AopResponse
    {
        /// <summary>
        /// 提额失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 提额成功或失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
