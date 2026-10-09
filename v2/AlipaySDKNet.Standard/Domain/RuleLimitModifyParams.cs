using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RuleLimitModifyParams Data Structure.
    /// </summary>
    [Serializable]
    public class RuleLimitModifyParams : AopObject
    {
        /// <summary>
        /// 规则内容集合
        /// </summary>
        [XmlArray("limit_list")]
        [XmlArrayItem("rule_limit_content")]
        public List<RuleLimitContent> LimitList { get; set; }

        /// <summary>
        /// 规则操作类型，ADD:新增一个商圈门店规则，DELETE：删除商圈下门店规则
        /// </summary>
        [XmlElement("limit_modify_type")]
        public string LimitModifyType { get; set; }
    }
}
