using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateItem Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateItem : AopObject
    {
        /// <summary>
        /// 凭证码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商户的凭证码
        /// </summary>
        [XmlElement("out_code")]
        public string OutCode { get; set; }

        /// <summary>
        /// 退款金额，单位分
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 凭证的总可用次数
        /// </summary>
        [XmlElement("total_times")]
        public long TotalTimes { get; set; }

        /// <summary>
        /// 凭证已使用的次数
        /// </summary>
        [XmlElement("used_times")]
        public long UsedTimes { get; set; }
    }
}
