using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DialogueAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class DialogueAuditResult : AopObject
    {
        /// <summary>
        /// 解语花内部对审核工单的唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 规则匹配信息
        /// </summary>
        [XmlArray("rule_hit_results")]
        [XmlArrayItem("rule_hit_result")]
        public List<RuleHitResult> RuleHitResults { get; set; }
    }
}
