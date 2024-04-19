using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupDetailVO : AopObject
    {
        /// <summary>
        /// 群组基础信息。群组基础信息。包含群组id、群组名称、群组管理员列表等信息。
        /// </summary>
        [XmlElement("group_base_info")]
        public GroupBaseInfoVO GroupBaseInfo { get; set; }

        /// <summary>
        /// 群信息。包含群id、群名称、群介绍、欢迎语等群配置信息。
        /// </summary>
        [XmlElement("group_instance_info")]
        public GroupInstanceInfoVO GroupInstanceInfo { get; set; }

        /// <summary>
        /// 入群欢迎语。
        /// </summary>
        [XmlElement("welcome_msg")]
        public GroupWelcomeMsgVO WelcomeMsg { get; set; }
    }
}
