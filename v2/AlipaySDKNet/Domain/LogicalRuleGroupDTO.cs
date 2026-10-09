using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogicalRuleGroupDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogicalRuleGroupDTO : AopObject
    {
        /// <summary>
        /// 逻辑规则+不唯一
        /// </summary>
        [XmlArray("logical_rules")]
        [XmlArrayItem("logical_rule_item_d_t_o")]
        public List<LogicalRuleItemDTO> LogicalRules { get; set; }
    }
}
