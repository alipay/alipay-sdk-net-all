using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDateInfo : AopObject
    {
        /// <summary>
        /// 激活时间
        /// </summary>
        [XmlElement("benefit_active_time")]
        public string BenefitActiveTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("benefit_expired_time")]
        public string BenefitExpiredTime { get; set; }

        /// <summary>
        /// 发放时间
        /// </summary>
        [XmlElement("benefit_issue_time")]
        public string BenefitIssueTime { get; set; }
    }
}
