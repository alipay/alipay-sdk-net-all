using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdSecdeviceInitializeResponse.
    /// </summary>
    public class AlipaySecurityProdSecdeviceInitializeResponse : AopResponse
    {
        /// <summary>
        /// 验证令牌
        /// </summary>
        [XmlElement("ifaa_token")]
        public string IfaaToken { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("server_response")]
        public string ServerResponse { get; set; }
    }
}
