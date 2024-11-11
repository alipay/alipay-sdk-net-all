using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRiskSummaryCheckResponse.
    /// </summary>
    public class ZhimaCreditEpRiskSummaryCheckResponse : AopResponse
    {
        /// <summary>
        /// true：有风险；false：无风险
        /// </summary>
        [XmlElement("has_risk")]
        public bool HasRisk { get; set; }
    }
}
