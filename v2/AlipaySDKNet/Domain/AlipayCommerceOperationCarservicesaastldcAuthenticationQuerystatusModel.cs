using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationCarservicesaastldcAuthenticationQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationCarservicesaastldcAuthenticationQuerystatusModel : AopObject
    {
        /// <summary>
        /// query请求返回的身份认证编号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }
    }
}
