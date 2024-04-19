using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolRuleQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度防控规则列表
        /// </summary>
        [XmlArray("rules")]
        [XmlArrayItem("quota_control_rule")]
        public List<QuotaControlRule> Rules { get; set; }
    }
}
