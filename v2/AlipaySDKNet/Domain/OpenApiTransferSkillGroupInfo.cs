using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiTransferSkillGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiTransferSkillGroupInfo : AopObject
    {
        /// <summary>
        /// 旧平台技能组id
        /// </summary>
        [XmlElement("clv_meta_organization_id")]
        public string ClvMetaOrganizationId { get; set; }

        /// <summary>
        /// 旧平台技能组id
        /// </summary>
        [XmlElement("clv_skill_group_id")]
        public string ClvSkillGroupId { get; set; }

        /// <summary>
        /// 技能组类型
        /// </summary>
        [XmlElement("clv_skill_group_type")]
        public long ClvSkillGroupType { get; set; }

        /// <summary>
        /// 场景实例信息
        /// </summary>
        [XmlElement("scene_instance_info")]
        public OpenApiSceneInstanceInfo SceneInstanceInfo { get; set; }

        /// <summary>
        /// 技能组渠道信息
        /// </summary>
        [XmlElement("skill_group_channel")]
        public OpenApiSkillGroupChannelInfo SkillGroupChannel { get; set; }

        /// <summary>
        /// 技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 技能组名称
        /// </summary>
        [XmlElement("skill_group_name")]
        public string SkillGroupName { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
