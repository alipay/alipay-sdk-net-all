using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DelOauthDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DelOauthDetail : AopObject
    {
        /// <summary>
        /// 数据入库的时间
        /// </summary>
        [XmlElement("del_auth_time")]
        public string DelAuthTime { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
