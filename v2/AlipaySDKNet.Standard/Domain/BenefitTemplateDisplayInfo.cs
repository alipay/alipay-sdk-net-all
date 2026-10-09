using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitTemplateDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitTemplateDisplayInfo : AopObject
    {
        /// <summary>
        /// 权益模板活动描述，由业务运营配置
        /// </summary>
        [XmlElement("activity_desc")]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// 权益模板活动名称，由业务运营配置
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 权益模板活动规则说明，由业务运营配置
        /// </summary>
        [XmlElement("activity_rule_desc")]
        public string ActivityRuleDesc { get; set; }
    }
}
