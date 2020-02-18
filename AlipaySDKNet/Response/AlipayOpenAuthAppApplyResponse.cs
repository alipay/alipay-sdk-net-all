using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthAppApplyResponse.
    /// </summary>
    public class AlipayOpenAuthAppApplyResponse : AopResponse
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [XmlElement("app_auth_token")]
        public string AppAuthToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [XmlElement("app_refresh_token")]
        public string AppRefreshToken { get; set; }
    }
}
