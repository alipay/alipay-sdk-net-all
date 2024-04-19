using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAuthorizationTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceEcAuthorizationTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 授权令牌信息
        /// </summary>
        [XmlElement("open_access_token_dto")]
        public OpenAccessTokenDTO OpenAccessTokenDto { get; set; }
    }
}
