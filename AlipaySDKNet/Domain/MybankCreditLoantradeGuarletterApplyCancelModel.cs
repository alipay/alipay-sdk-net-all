using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterApplyCancelModel : AopObject
    {
        /// <summary>
        /// 原开函申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 请求单号，标识每一笔不同的请求
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
