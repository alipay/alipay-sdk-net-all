using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartRuleQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 规则查询结果
        /// </summary>
        [XmlElement("data")]
        public RuleQueryResult Data { get; set; }
    }
}
