using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUserquerybyclvuidsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUserquerybyclvuidsQueryModel : AopObject
    {
        /// <summary>
        /// 旧平台的用户id
        /// </summary>
        [XmlArray("clv_user_ids")]
        [XmlArrayItem("number")]
        public List<long> ClvUserIds { get; set; }

        /// <summary>
        /// 是否查询角色
        /// </summary>
        [XmlElement("query_role")]
        public bool QueryRole { get; set; }

        /// <summary>
        /// 是否查询技能组
        /// </summary>
        [XmlElement("query_skill_group")]
        public bool QuerySkillGroup { get; set; }

        /// <summary>
        /// 是否查询用户资源信息
        /// </summary>
        [XmlElement("query_user_resource")]
        public bool QueryUserResource { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
