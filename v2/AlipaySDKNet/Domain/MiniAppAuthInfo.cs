using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppAuthInfo : AopObject
    {
        /// <summary>
        /// 授权小程序id
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }

        /// <summary>
        /// 服务商appid
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 小程序应用授权token
        /// </summary>
        [XmlElement("mini_app_token")]
        public string MiniAppToken { get; set; }
    }
}
