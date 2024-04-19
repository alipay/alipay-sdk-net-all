using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupWelcomeMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupWelcomeMsgVO : AopObject
    {
        /// <summary>
        /// 欢迎消息。支持发图文消息、小程序消息等。
        /// </summary>
        [XmlElement("welcome_group_msg")]
        public GroupMsgVO WelcomeGroupMsg { get; set; }

        /// <summary>
        /// 用户进群时，群聊自动触发欢迎语，仅加群用户和群主可见，建议介绍日常活动或引导用户尝试互动。
        /// </summary>
        [XmlElement("welcome_text")]
        public string WelcomeText { get; set; }
    }
}
