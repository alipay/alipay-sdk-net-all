using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolutionRiskConsultResponse.
    /// </summary>
    public class AlipayMerchantSolutionRiskConsultResponse : AopResponse
    {
        /// <summary>
        /// 风险提示信息，若存在多个服务商有风险，则返回list，若不存在服务商有风险，则不返回
        /// </summary>
        [XmlArray("risk_warning_info")]
        [XmlArrayItem("risk_warning_info")]
        public List<RiskWarningInfo> RiskWarningInfo { get; set; }

        /// <summary>
        /// 标识唯一的解决方案
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
