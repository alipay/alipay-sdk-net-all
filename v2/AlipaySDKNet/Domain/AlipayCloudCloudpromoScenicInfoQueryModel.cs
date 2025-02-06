using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoScenicInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoScenicInfoQueryModel : AopObject
    {
        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 景点id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 景点名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
