using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentHotlineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AgentHotlineInfo : AopObject
    {
        /// <summary>
        /// 数据权限id(租户实例id)
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 热线技能组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }
    }
}
