using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationCarservicesaastldcAuthenticationQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationCarservicesaastldcAuthenticationQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证编号，需要在2个小时内发起认证，过期无效。
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }
    }
}
