using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfcreditcontrolRiskdetectionserviceQueryResponse.
    /// </summary>
    public class AlipayBossFncGfcreditcontrolRiskdetectionserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险检测结果
        /// </summary>
        [XmlElement("result_set")]
        public RiskDetectionResultOpenApiDTO ResultSet { get; set; }
    }
}
