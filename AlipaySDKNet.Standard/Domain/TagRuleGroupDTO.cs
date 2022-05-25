using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagRuleGroupDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TagRuleGroupDTO : AopObject
    {
        /// <summary>
        /// 标签取值列表+不唯一
        /// </summary>
        [XmlArray("rule_items")]
        [XmlArrayItem("tag_rule_item_d_t_o")]
        public List<TagRuleItemDTO> RuleItems { get; set; }
    }
}
