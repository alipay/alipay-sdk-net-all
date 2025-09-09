using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgAutoreplyRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgAutoreplyRuleVO : AopObject
    {
        /// <summary>
        /// 行动配置
        /// </summary>
        [XmlElement("action_config")]
        public GroupMsgAutoreplyActionConfigVO ActionConfig { get; set; }

        /// <summary>
        /// 触发规则
        /// </summary>
        [XmlElement("trigger_rule")]
        public GroupMsgAutoreplyTriggerRuleVO TriggerRule { get; set; }
    }
}
