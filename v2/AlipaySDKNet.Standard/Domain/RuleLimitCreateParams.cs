using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleLimitCreateParams Data Structure.
    /// </summary>
    [Serializable]
    public class RuleLimitCreateParams : AopObject
    {
        /// <summary>
        /// 规则内容集合
        /// </summary>
        [XmlArray("limit_list")]
        [XmlArrayItem("rule_limit_content")]
        public List<RuleLimitContent> LimitList { get; set; }

        /// <summary>
        /// 限制规则类型，ALL:全场门店有效，SHOP_LIMIT: 部分门店有效
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }
    }
}
