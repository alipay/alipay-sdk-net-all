using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterReencryptApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterReencryptApplyResponse : AopResponse
    {
        /// <summary>
        /// 重新加密保函申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
