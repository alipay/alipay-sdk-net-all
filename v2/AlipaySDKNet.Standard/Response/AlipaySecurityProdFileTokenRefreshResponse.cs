using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdFileTokenRefreshResponse.
    /// </summary>
    public class AlipaySecurityProdFileTokenRefreshResponse : AopResponse
    {
        /// <summary>
        /// token刷新结果
        /// </summary>
        [XmlElement("refresh_weboffice_token_response")]
        public RefreshWebofficeTokenResponse RefreshWebofficeTokenResponse { get; set; }
    }
}
