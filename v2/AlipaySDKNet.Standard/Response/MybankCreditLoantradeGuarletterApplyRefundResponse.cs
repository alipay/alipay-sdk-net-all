using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyRefundResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterApplyRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
