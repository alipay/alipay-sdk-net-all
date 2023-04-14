using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterReencryptApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterReencryptApplyModel : AopObject
    {
        /// <summary>
        /// 新的公钥值
        /// </summary>
        [XmlElement("apply_user_public_key")]
        public string ApplyUserPublicKey { get; set; }

        /// <summary>
        /// 保函单号
        /// </summary>
        [XmlElement("guar_letter_order_no")]
        public string GuarLetterOrderNo { get; set; }

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
