using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskMobileactivityQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskMobileactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有风险
        /// </summary>
        [XmlElement("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 返回本次模型的infocode
        /// </summary>
        [XmlArray("info_code")]
        [XmlArrayItem("risk_rank_info_code")]
        public List<RiskRankInfoCode> InfoCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_rank")]
        public long RiskRank { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("risk_score")]
        public long RiskScore { get; set; }
    }
}
