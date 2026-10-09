using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthResauthCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthResauthCheckModel : AopObject
    {
        /// <summary>
        /// 授权场景
        /// </summary>
        [XmlElement("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 授权方pid
        /// </summary>
        [XmlElement("authorize_pid")]
        public string AuthorizePid { get; set; }

        /// <summary>
        /// 被授权方pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
