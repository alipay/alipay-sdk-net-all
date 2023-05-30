using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAuthorizationCodeCreateResponse.
    /// </summary>
    public class AlipayCommerceEcAuthorizationCodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 授权码authCode信息
        /// </summary>
        [XmlElement("open_access_code_dto")]
        public OpenAccessCodeDTO OpenAccessCodeDto { get; set; }
    }
}
