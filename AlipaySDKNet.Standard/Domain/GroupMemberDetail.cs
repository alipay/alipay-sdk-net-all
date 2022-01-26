using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMemberDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMemberDetail : AopObject
    {
        /// <summary>
        /// 支付宝聊天群内昵称
        /// </summary>
        [XmlElement("group_nick_name")]
        public string GroupNickName { get; set; }

        /// <summary>
        /// 邀请者的user_id
        /// </summary>
        [XmlElement("invite_id")]
        public string InviteId { get; set; }

        /// <summary>
        /// 入群方式。 1 - 由群成员邀请入群（直接邀请入群） 2 - 由群成员邀请入群（通过邀请链接入群） 3 - 通过扫描群二维码入群
        /// </summary>
        [XmlElement("join_scene")]
        public string JoinScene { get; set; }

        /// <summary>
        /// 入群时间
        /// </summary>
        [XmlElement("join_time")]
        public string JoinTime { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
