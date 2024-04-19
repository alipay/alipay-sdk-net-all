using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceRiskApplyResponse : AopResponse
    {
        /// <summary>
        /// 外部风控编号
        /// </summary>
        [XmlElement("out_risk_id")]
        public string OutRiskId { get; set; }

        /// <summary>
        /// 风控申请结果返回
        /// </summary>
        [XmlElement("risk_info")]
        public string RiskInfo { get; set; }
    }
}
