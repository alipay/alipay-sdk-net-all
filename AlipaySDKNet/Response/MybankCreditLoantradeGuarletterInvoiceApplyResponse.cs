using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterInvoiceApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterInvoiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 开发票申请单单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
