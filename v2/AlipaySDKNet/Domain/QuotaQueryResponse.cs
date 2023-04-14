using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaQueryResponse : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 单个协议查询结果错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 单个协议响应错误描述
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 额度明细列表
        /// </summary>
        [XmlElement("quota_details")]
        public AccountQuotaDetail QuotaDetails { get; set; }

        /// <summary>
        /// 单个协议查询结果是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
