using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterRestoreApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterRestoreApplyResponse : AopResponse
    {
        /// <summary>
        /// 受理申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
