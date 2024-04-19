using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudTraasCloudriskRentriskQueryResponse.
    /// </summary>
    public class AlipayCloudTraasCloudriskRentriskQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险查询结果
        /// </summary>
        [XmlElement("risk_result")]
        public RentRiskResult RiskResult { get; set; }
    }
}
