using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterApplyCheckModel : AopObject
    {
        /// <summary>
        /// 保函单号
        /// </summary>
        [XmlElement("guar_letter_order_no")]
        public string GuarLetterOrderNo { get; set; }

        /// <summary>
        /// 请求单号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 方案合约号
        /// </summary>
        [XmlElement("scheme_ar_no")]
        public string SchemeArNo { get; set; }
    }
}
