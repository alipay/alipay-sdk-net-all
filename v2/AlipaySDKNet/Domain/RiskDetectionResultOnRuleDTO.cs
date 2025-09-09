using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionResultOnRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionResultOnRuleDTO : AopObject
    {
        /// <summary>
        /// 检测模型
        /// </summary>
        [XmlElement("detection_model")]
        public string DetectionModel { get; set; }

        /// <summary>
        /// 是否阻断
        /// </summary>
        [XmlElement("need_break")]
        public bool NeedBreak { get; set; }

        /// <summary>
        /// 子规则检测结果列表
        /// </summary>
        [XmlArray("risk_detection_result_on_sub_rule_dto_list")]
        [XmlArrayItem("risk_detection_result_on_sub_rule_d_t_o")]
        public List<RiskDetectionResultOnSubRuleDTO> RiskDetectionResultOnSubRuleDtoList { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险点code
        /// </summary>
        [XmlElement("risk_point_code")]
        public string RiskPointCode { get; set; }

        /// <summary>
        /// 风险规则ID
        /// </summary>
        [XmlElement("risk_rule_id")]
        public string RiskRuleId { get; set; }

        /// <summary>
        /// 风险规则名称
        /// </summary>
        [XmlElement("risk_rule_name")]
        public string RiskRuleName { get; set; }
    }
}
