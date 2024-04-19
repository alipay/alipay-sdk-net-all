using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserDInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserDInfo : AopObject
    {
        /// <summary>
        /// 用户登陆号（手机号）
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户蚂蚁身份id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
