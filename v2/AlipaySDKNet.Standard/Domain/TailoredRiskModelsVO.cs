using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TailoredRiskModelsVO Data Structure.
    /// </summary>
    [Serializable]
    public class TailoredRiskModelsVO : AopObject
    {
        /// <summary>
        /// 长租定制综合风险等级 (D1-D10)
        /// </summary>
        [XmlElement("tailored_risk_level")]
        public string TailoredRiskLevel { get; set; }
    }
}
