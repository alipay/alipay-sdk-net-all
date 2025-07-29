using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgAutoreplyTriggerRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgAutoreplyTriggerRuleVO : AopObject
    {
        /// <summary>
        /// 触发规则
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }
    }
}
