using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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
        /// 入群方式。BY_TOKEN - 通过吱口令入群；BY_INV - 通过被邀请或者被选择入群；BY_COD - 通过扫码入群；BY_FTF- 通过面对面入群；BY_ADD - 外部添加来源；BY_CHAT_ROOM - 聊天室；BY_OPENAPI - 开放平台；BY_SHARE_INV - 通过分享的邀请链接进群；BY_BIZ_INVOKE - 通过业务系统调用进群；BY_SELF_ENTER -通过自主进群；DIS - 讨论组进群；SOCIAL - 社区业务调用进群；BY_UNKNOW -未知来源。其余的属于商户自定义的入群方式！！！
        /// </summary>
        [XmlElement("join_scene")]
        public string JoinScene { get; set; }

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
        /// 用户推广入群的渠道列表，可有多个渠道code，按列表顺序为：第一渠道、第二渠道依次存储
        /// </summary>
        [XmlArray("promote_channel_keys")]
        [XmlArrayItem("string")]
        public List<string> PromoteChannelKeys { get; set; }

        /// <summary>
        /// 邀请者uid对应的unionId
        /// </summary>
        [XmlElement("union_id_from_invite_id")]
        public string UnionIdFromInviteId { get; set; }

        /// <summary>
        /// 用户uid对应的unionId
        /// </summary>
        [XmlElement("union_id_from_user_id")]
        public string UnionIdFromUserId { get; set; }

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
