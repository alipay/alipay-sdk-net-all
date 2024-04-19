using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvSkillGroup Data Structure.
    /// </summary>
    [Serializable]
    public class IsvSkillGroup : AopObject
    {
        /// <summary>
        /// isv定义的热线技能组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// isv定义的热线技能组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
