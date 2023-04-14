using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransportAuthStatusData Data Structure.
    /// </summary>
    [Serializable]
    public class TransportAuthStatusData : AopObject
    {
        /// <summary>
        /// 授权状态。取值枚举为authed、unauthed。分别表示已授权、未授权
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 若用户已经授权，根据需要，某些场景下会返回用户授权时间。
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 蚂蚁会员id（对外）。当授权状态为已授权时，需要返回本字段。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁会员id。当授权状态为已授权时，需要返回本字段。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
