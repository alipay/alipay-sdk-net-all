using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionResultOnRiskRulesMapDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionResultOnRiskRulesMapDTO : AopObject
    {
        /// <summary>
        /// 风险检测规则业务分组key
        /// </summary>
        [XmlElement("group_key")]
        public string GroupKey { get; set; }

        /// <summary>
        /// 风险检测规则级别的检测结果列表
        /// </summary>
        [XmlArray("risk_detection_result_on_rule_dto_list")]
        [XmlArrayItem("risk_detection_result_on_rule_d_t_o")]
        public List<RiskDetectionResultOnRuleDTO> RiskDetectionResultOnRuleDtoList { get; set; }
    }
}
