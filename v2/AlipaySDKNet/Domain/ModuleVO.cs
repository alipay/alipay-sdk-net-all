using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class ModuleVO : AopObject
    {
        /// <summary>
        /// 模块code
        /// </summary>
        [XmlElement("module_code")]
        public string ModuleCode { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [XmlElement("module_name")]
        public string ModuleName { get; set; }

        /// <summary>
        /// 模块值
        /// </summary>
        [XmlArray("module_value_items")]
        [XmlArrayItem("module_value_v_o")]
        public List<ModuleValueVO> ModuleValueItems { get; set; }

        /// <summary>
        /// 规则子表达式
        /// </summary>
        [XmlElement("rule_conditions")]
        public string RuleConditions { get; set; }
    }
}
