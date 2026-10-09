using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppMemberInfo : AopObject
    {
        /// <summary>
        /// 邀请时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_invite")]
        public string GmtInvite { get; set; }

        /// <summary>
        /// 加入时间，格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("gmt_join")]
        public string GmtJoin { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 头像地址fileId(完整地址需自行拼接)
        /// </summary>
        [XmlElement("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 成员的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
