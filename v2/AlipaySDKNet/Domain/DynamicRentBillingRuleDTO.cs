using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DynamicRentBillingRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DynamicRentBillingRuleDTO : AopObject
    {
        /// <summary>
        /// 多阶段必填
        /// </summary>
        [XmlElement("multi_stage")]
        public DynamicRentBillingRuleMultiStageDTO MultiStage { get; set; }

        /// <summary>
        /// 单阶段必填
        /// </summary>
        [XmlElement("single_stage")]
        public DynamicRentBillingRuleSingleStageDTO SingleStage { get; set; }

        /// <summary>
        /// 多阶段:MULTI_STAGE 单阶段:SINGLE_STAGE
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
