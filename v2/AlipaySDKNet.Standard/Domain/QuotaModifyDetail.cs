using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaModifyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaModifyDetail : AopObject
    {
        /// <summary>
        /// 授权协议号，和入参的协议号对应
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 明细处理错误码，当success为false时有值
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述，当success为false时有值
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 当前协议下的明细处理结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
