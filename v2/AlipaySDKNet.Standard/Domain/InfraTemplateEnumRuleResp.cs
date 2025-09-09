using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InfraTemplateEnumRuleResp Data Structure.
    /// </summary>
    [Serializable]
    public class InfraTemplateEnumRuleResp : AopObject
    {
        /// <summary>
        /// 元素可选值对象集合
        /// </summary>
        [XmlArray("options")]
        [XmlArrayItem("infra_template_enum_rule_option_resp")]
        public List<InfraTemplateEnumRuleOptionResp> Options { get; set; }
    }
}
