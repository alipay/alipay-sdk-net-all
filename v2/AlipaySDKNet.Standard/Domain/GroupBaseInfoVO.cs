using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupBaseInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupBaseInfoVO : AopObject
    {
        /// <summary>
        /// 是否禁言，true：已经被禁言了，false：未被禁言。
        /// </summary>
        [XmlElement("forbid_send_msg")]
        public bool ForbidSendMsg { get; set; }

        /// <summary>
        /// 传入已经有群组权限的用户user_id，2088开头的16位数字。有群组权限的角色：主账号、群超级管理员、群组管理员。
        /// </summary>
        [XmlArray("group_admin_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupAdminOpenIdList { get; set; }

        /// <summary>
        /// 传入已经有群组权限的用户user_id，2088开头的16位数字。有群组权限的角色：主账号、群超级管理员、群组管理员。
        /// </summary>
        [XmlArray("group_admin_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupAdminUserIdList { get; set; }

        /// <summary>
        /// 群数量
        /// </summary>
        [XmlElement("group_count")]
        public string GroupCount { get; set; }

        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成，编辑群组必填
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群组下群成员总数
        /// </summary>
        [XmlElement("group_member_count")]
        public string GroupMemberCount { get; set; }

        /// <summary>
        /// 定义群组分类，便于后台管理运营识别，可与下面设置的群名称保持一致；例：xx门店群，内部测试群
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 小程序id。用于群头像展示。
        /// </summary>
        [XmlElement("related_app_id")]
        public string RelatedAppId { get; set; }

        /// <summary>
        /// 小程序logo。用于商家群头像展示。
        /// </summary>
        [XmlElement("related_app_logo")]
        public string RelatedAppLogo { get; set; }
    }
}
