using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipaySubscribePortalSessionCreateResponse.
    /// </summary>
    public class AlipayAipaySubscribePortalSessionCreateResponse : AopResponse
    {
        /// <summary>
        /// 跳转url过期时间时间戳(毫秒)
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 直接透出给用户的跳转url
        /// </summary>
        [XmlElement("portal_url")]
        public string PortalUrl { get; set; }
    }
}
