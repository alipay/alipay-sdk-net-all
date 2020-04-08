using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskWarningAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceRiskWarningAddModel : AopObject
    {
        /// <summary>
        /// 外部风控编号
        /// </summary>
        [XmlElement("out_risk_id")]
        public string OutRiskId { get; set; }

        /// <summary>
        /// 风控详情
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }
    }
}
