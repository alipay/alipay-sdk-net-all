using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupUserVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupUserVO : AopObject
    {
        /// <summary>
        /// 邀请者的user_id，2088开头的16位数字。
        /// </summary>
        [XmlElement("invite_id")]
        public string InviteId { get; set; }

        /// <summary>
        /// 邀请者的open_id，2088开头的16位数字。
        /// </summary>
        [XmlElement("invite_open_id")]
        public string InviteOpenId { get; set; }

        /// <summary>
        /// 入群时间
        /// </summary>
        [XmlElement("join_time")]
        public string JoinTime { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户openid，2088开头的16位数字。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户user_id，2088开头的16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称（花名 or  昵称），后台会校验是否是真实姓名。
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
