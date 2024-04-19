using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceGrpquerybyclvgrpidsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceGrpquerybyclvgrpidsQueryModel : AopObject
    {
        /// <summary>
        /// 根据clv技能组id查询技能组信息
        /// </summary>
        [XmlArray("clv_skill_group_ids")]
        [XmlArrayItem("string")]
        public List<string> ClvSkillGroupIds { get; set; }

        /// <summary>
        /// 是否查询场景实例信息
        /// </summary>
        [XmlElement("query_scene_instance")]
        public bool QuerySceneInstance { get; set; }

        /// <summary>
        /// 是否查询转接技能组
        /// </summary>
        [XmlElement("query_transfer_skill_groups")]
        public bool QueryTransferSkillGroups { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
