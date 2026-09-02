using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterRuleQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// true：命中规则 false：未命中规则
        /// </summary>
        [XmlElement("hit")]
        public bool Hit { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("rule_check_res_list")]
        [XmlArrayItem("rule_check_result")]
        public List<RuleCheckResult> RuleCheckResList { get; set; }
    }
}
