using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PeriodPayBillingRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PeriodPayBillingRuleDTO : AopObject
    {
        /// <summary>
        /// 每期动态类型必填
        /// </summary>
        [XmlElement("dynamic")]
        public PeriodPayBillingRuleDynamicDTO Dynamic { get; set; }

        /// <summary>
        /// 每期固定类型必填
        /// </summary>
        [XmlElement("fixed")]
        public PeriodPayBillingRuleFixedDTO Fixed { get; set; }

        /// <summary>
        /// FIXED 每期固定：FIXED 每期动态：DYNAMIC
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
