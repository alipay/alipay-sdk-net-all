using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GroupDetail : AopObject
    {
        /// <summary>
        /// 管理员商家id
        /// </summary>
        [XmlArray("admin_open_ids")]
        [XmlArrayItem("string")]
        public List<string> AdminOpenIds { get; set; }

        /// <summary>
        /// 群管理员user_id
        /// </summary>
        [XmlArray("admin_user_ids")]
        [XmlArrayItem("string")]
        public List<string> AdminUserIds { get; set; }

        /// <summary>
        /// 群创建的时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付宝群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群头像url
        /// </summary>
        [XmlElement("group_img")]
        public string GroupImg { get; set; }

        /// <summary>
        /// 支付宝群名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群主商家openId
        /// </summary>
        [XmlElement("master_open_id")]
        public string MasterOpenId { get; set; }

        /// <summary>
        /// 群主的user_id
        /// </summary>
        [XmlElement("master_user_id")]
        public string MasterUserId { get; set; }

        /// <summary>
        /// 群成员个数
        /// </summary>
        [XmlElement("member_count")]
        public long MemberCount { get; set; }

        /// <summary>
        /// 支付宝内群成员列表
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("group_member_detail")]
        public List<GroupMemberDetail> Members { get; set; }

        /// <summary>
        /// 群公告
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }
    }
}
