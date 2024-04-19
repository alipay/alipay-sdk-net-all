using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentChatInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgentChatInfo : AopObject
    {
        /// <summary>
        /// 数据权限id(租户实例id)
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线扩展技能组id列表
        /// </summary>
        [XmlArray("extended_group_ids")]
        [XmlArrayItem("string")]
        public List<string> ExtendedGroupIds { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 在线服务等级
        /// </summary>
        [XmlElement("level_id")]
        public string LevelId { get; set; }
    }
}
