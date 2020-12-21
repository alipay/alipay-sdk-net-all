using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class UserInfoVO : AopObject
    {
        /// <summary>
        /// 孩子生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 头像路径，如果无头像需要有兜底图
        /// </summary>
        [XmlElement("head_url")]
        public string HeadUrl { get; set; }

        /// <summary>
        /// 孩子昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 孩子UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
