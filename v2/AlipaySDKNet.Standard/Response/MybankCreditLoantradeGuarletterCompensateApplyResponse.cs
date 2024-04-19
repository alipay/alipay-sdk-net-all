using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterCompensateApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterCompensateApplyResponse : AopResponse
    {
        /// <summary>
        /// 赔付申请单单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
