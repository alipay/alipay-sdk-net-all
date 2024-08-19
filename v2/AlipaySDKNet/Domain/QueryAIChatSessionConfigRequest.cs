using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryAIChatSessionConfigRequest Data Structure.
    /// </summary>
    [Serializable]
    public class QueryAIChatSessionConfigRequest : AopObject
    {
        /// <summary>
        /// 是否需要返回智能体内容
        /// </summary>
        [XmlElement("need_agent_content")]
        public bool NeedAgentContent { get; set; }

        /// <summary>
        /// 是否需要返回智能体信息
        /// </summary>
        [XmlElement("need_agent_info")]
        public bool NeedAgentInfo { get; set; }

        /// <summary>
        /// 是否查询用户使用习惯
        /// </summary>
        [XmlElement("need_customer_like")]
        public bool NeedCustomerLike { get; set; }

        /// <summary>
        /// 是否需要查询猜你想问问题列表
        /// </summary>
        [XmlElement("need_guess_question")]
        public bool NeedGuessQuestion { get; set; }

        /// <summary>
        /// 是否需要查询欢迎语
        /// </summary>
        [XmlElement("need_welcome_message")]
        public bool NeedWelcomeMessage { get; set; }
    }
}
