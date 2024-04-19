using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSkillGroupChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSkillGroupChannelInfo : AopObject
    {
        /// <summary>
        /// Cc管理员的id
        /// </summary>
        [XmlElement("admin_id")]
        public string AdminId { get; set; }

        /// <summary>
        /// 渠道账户所属组织架构
        /// </summary>
        [XmlElement("channel_account_ref_organization")]
        public string ChannelAccountRefOrganization { get; set; }

        /// <summary>
        /// 渠道账户所属角色
        /// </summary>
        [XmlElement("channel_account_role")]
        public string ChannelAccountRole { get; set; }

        /// <summary>
        /// 渠道场景id
        /// </summary>
        [XmlElement("channel_scene_id")]
        public string ChannelSceneId { get; set; }

        /// <summary>
        /// 渠道场景名
        /// </summary>
        [XmlElement("channel_scene_name")]
        public string ChannelSceneName { get; set; }

        /// <summary>
        /// 渠道技能组id
        /// </summary>
        [XmlElement("channel_skill_group_id")]
        public string ChannelSkillGroupId { get; set; }

        /// <summary>
        /// 渠道技能组名称
        /// </summary>
        [XmlElement("channel_skill_group_name")]
        public string ChannelSkillGroupName { get; set; }

        /// <summary>
        /// 子渠道
        /// </summary>
        [XmlElement("sub_channel")]
        public string SubChannel { get; set; }

        /// <summary>
        /// 子渠道名称
        /// </summary>
        [XmlElement("sub_channel_name")]
        public string SubChannelName { get; set; }
    }
}
