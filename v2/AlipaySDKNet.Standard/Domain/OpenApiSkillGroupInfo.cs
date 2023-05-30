using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSkillGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSkillGroupInfo : AopObject
    {
        /// <summary>
        /// 旧平台组织节点id
        /// </summary>
        [XmlElement("clv_meta_organization_id")]
        public string ClvMetaOrganizationId { get; set; }

        /// <summary>
        /// 旧平台的技能组id
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
        /// 租户
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 转接技能组信息
        /// </summary>
        [XmlArray("transfer_skill_groups")]
        [XmlArrayItem("open_api_transfer_skill_group_info")]
        public List<OpenApiTransferSkillGroupInfo> TransferSkillGroups { get; set; }
    }
}
