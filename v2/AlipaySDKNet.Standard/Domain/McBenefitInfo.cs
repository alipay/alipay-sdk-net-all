using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// McBenefitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class McBenefitInfo : AopObject
    {
        /// <summary>
        /// 权益code
        /// </summary>
        [XmlElement("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// 权益过期时间
        /// </summary>
        [XmlElement("benefit_expire_time")]
        public string BenefitExpireTime { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益开通时间
        /// </summary>
        [XmlElement("benefit_open_time")]
        public string BenefitOpenTime { get; set; }

        /// <summary>
        /// 权益状态
        /// </summary>
        [XmlElement("benefit_status")]
        public string BenefitStatus { get; set; }

        /// <summary>
        /// 权益总次数
        /// </summary>
        [XmlElement("benefit_total_count")]
        public long BenefitTotalCount { get; set; }

        /// <summary>
        /// 权益使用次数
        /// </summary>
        [XmlElement("benefit_use_count")]
        public long BenefitUseCount { get; set; }
    }
}
