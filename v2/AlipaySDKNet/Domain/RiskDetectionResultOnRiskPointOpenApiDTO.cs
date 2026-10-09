using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionResultOnRiskPointOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionResultOnRiskPointOpenApiDTO : AopObject
    {
        /// <summary>
        /// 本风险点下，该业务单据后续流程是否需要阻断：true/false
        /// </summary>
        [XmlElement("need_break")]
        public bool NeedBreak { get; set; }

        /// <summary>
        /// 风险检测结果Map列表
        /// </summary>
        [XmlArray("risk_detection_result_on_risk_rules_map_dto_list")]
        [XmlArrayItem("risk_detection_result_on_risk_rules_map_d_t_o")]
        public List<RiskDetectionResultOnRiskRulesMapDTO> RiskDetectionResultOnRiskRulesMapDtoList { get; set; }

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
    }
}
