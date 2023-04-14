using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyCreateResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterApplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 受理单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }
    }
}
