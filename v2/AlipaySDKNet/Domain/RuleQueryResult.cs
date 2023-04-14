using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class RuleQueryResult : AopObject
    {
        /// <summary>
        /// 规则详情信息
        /// </summary>
        [XmlArray("rule_info_list")]
        [XmlArrayItem("rule_info")]
        public List<RuleInfo> RuleInfoList { get; set; }
    }
}
