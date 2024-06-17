using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AutoRentPhaseRiskDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AutoRentPhaseRiskDetail : AopObject
    {
        /// <summary>
        /// 多个风控厂商的风控结果详情
        /// </summary>
        [XmlArray("auto_rent_single_risk_details")]
        [XmlArrayItem("auto_rent_single_risk_detail")]
        public List<AutoRentSingleRiskDetail> AutoRentSingleRiskDetails { get; set; }

        /// <summary>
        /// 当前风控的阶段
        /// </summary>
        [XmlElement("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 当前自动审核的汇总风险等级
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }
    }
}
