using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifyUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifyUserInfo : AopObject
    {
        /// <summary>
        /// 指定主体appid
        /// </summary>
        [XmlElement("specify_app_id")]
        public string SpecifyAppId { get; set; }

        /// <summary>
        /// 用户在指定主体appid对应的openid
        /// </summary>
        [XmlElement("specify_open_id")]
        public string SpecifyOpenId { get; set; }
    }
}
