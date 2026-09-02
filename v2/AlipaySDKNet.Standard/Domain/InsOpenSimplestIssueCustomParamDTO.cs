using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenSimplestIssueCustomParamDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenSimplestIssueCustomParamDTO : AopObject
    {
        /// <summary>
        /// 职业类别
        /// </summary>
        [XmlElement("job_category")]
        public string JobCategory { get; set; }

        /// <summary>
        /// 是否跳过风控核保
        /// </summary>
        [XmlElement("skip_risk_underwrite")]
        public bool SkipRiskUnderwrite { get; set; }
    }
}
