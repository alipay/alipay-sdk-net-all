using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdSecdeviceCertifyResponse.
    /// </summary>
    public class AlipaySecurityProdSecdeviceCertifyResponse : AopResponse
    {
        /// <summary>
        /// iifaa响应数据
        /// </summary>
        [XmlElement("server_response")]
        public string ServerResponse { get; set; }
    }
}
