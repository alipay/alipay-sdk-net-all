using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FriendVO Data Structure.
    /// </summary>
    [Serializable]
    public class FriendVO : AopObject
    {
        /// <summary>
        /// 好友open_id
        /// </summary>
        [XmlElement("friend_openid")]
        public string FriendOpenid { get; set; }

        /// <summary>
        /// 好友头像
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 好友关系，是否双向好友
        /// </summary>
        [XmlElement("relation")]
        public string Relation { get; set; }

        /// <summary>
        /// 好友昵称
        /// </summary>
        [XmlElement("view_name")]
        public string ViewName { get; set; }
    }
}
