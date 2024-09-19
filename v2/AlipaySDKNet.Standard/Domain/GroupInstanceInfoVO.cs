using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupInstanceInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupInstanceInfoVO : AopObject
    {
        /// <summary>
        /// 请一定打开，开启后获得满500人自动裂变新群聊功能。true：开启；false：关闭。
        /// </summary>
        [XmlElement("auto_create_group_instance")]
        public bool AutoCreateGroupInstance { get; set; }

        /// <summary>
        /// 允许管理员与群员私聊：建议开启。true：关闭；false：开启。
        /// </summary>
        [XmlElement("forbid_admin_chat")]
        public bool ForbidAdminChat { get; set; }

        /// <summary>
        /// 允许群员发起私聊：建议关闭；关闭后群员将不能主动添加群主或其它群内用户好友。true：关闭；false：开启。
        /// </summary>
        [XmlElement("forbid_member_chat")]
        public bool ForbidMemberChat { get; set; }

        /// <summary>
        /// 群创建的时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成，编辑群组必填
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 输入群管理员的个人支付宝账号、真实姓名、登录账号，自动建群时会将该账号默认设为群管理员；如需多个可“添加管理员”，最多可设置10个。
        /// </summary>
        [XmlArray("group_instance_admin_user_list")]
        [XmlArrayItem("group_user_v_o")]
        public List<GroupUserVO> GroupInstanceAdminUserList { get; set; }

        /// <summary>
        /// 用户在加群页面可见的群相关介绍信息。建议填写日常活动以及群友福利。
        /// </summary>
        [XmlElement("group_instance_desc")]
        public string GroupInstanceDesc { get; set; }

        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_instance_id")]
        public string GroupInstanceId { get; set; }

        /// <summary>
        /// 群主。群主的个人支付宝uid、真实姓名、登录账号，自动建群时会将该账号默认设为群主。
        /// </summary>
        [XmlElement("group_instance_master")]
        public GroupUserVO GroupInstanceMaster { get; set; }

        /// <summary>
        /// 群成员总数
        /// </summary>
        [XmlElement("group_instance_member_count")]
        public string GroupInstanceMemberCount { get; set; }

        /// <summary>
        /// 用户在支付宝APP可见的群名称，自动建群时会使用“该名称+X群”来命名，无需手动输入群号。建议以品牌名称+分类方式命名，请勿添加数字。
        /// </summary>
        [XmlElement("group_instance_name")]
        public string GroupInstanceName { get; set; }

        /// <summary>
        /// 群头像url
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 支付宝内群成员列表
        /// </summary>
        [XmlArray("member_list")]
        [XmlArrayItem("group_user_v_o")]
        public List<GroupUserVO> MemberList { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 允许群员邀请其他用户入群：建议开启。true：开启；false：关闭。
        /// </summary>
        [XmlElement("open_invite")]
        public bool OpenInvite { get; set; }
    }
}
