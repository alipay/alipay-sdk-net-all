using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUserpermissiongrantModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUserpermissiongrantModifyModel : AopObject
    {
        /// <summary>
        /// 工作台技能组id列表
        /// </summary>
        [XmlArray("clv_skill_group_ids")]
        [XmlArrayItem("string")]
        public List<string> ClvSkillGroupIds { get; set; }

        /// <summary>
        /// 工作台用户id
        /// </summary>
        [XmlElement("clv_user_id")]
        public long ClvUserId { get; set; }

        /// <summary>
        /// true，赋权; false，回收
        /// </summary>
        [XmlElement("grant")]
        public bool Grant { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
