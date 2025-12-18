using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityUserUsageLimitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityUserUsageLimitInfo : AopObject
    {
        /// <summary>
        /// 限制活动的可用次数
        /// </summary>
        [XmlElement("limit_count")]
        public string LimitCount { get; set; }

        /// <summary>
        /// 用户使用限制
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 可用的用户类型
        /// </summary>
        [XmlElement("usage_rule_type")]
        public string UsageRuleType { get; set; }

        /// <summary>
        /// 可用的时间类型
        /// </summary>
        [XmlElement("usage_time_type")]
        public string UsageTimeType { get; set; }
    }
}
