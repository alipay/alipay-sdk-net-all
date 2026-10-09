using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DanmuGameUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DanmuGameUserInfo : AopObject
    {
        /// <summary>
        /// 用户头像url
        /// </summary>
        [XmlElement("head_url")]
        public string HeadUrl { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
